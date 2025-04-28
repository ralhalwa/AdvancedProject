﻿using ClassLibrary.Models;
using ClassLibrary.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Rental.Controllers
{
    public class RentalRequestController : BaseController
    {
        public RentalRequestController(DBContext context) : base(context) { }

        public IActionResult Index()
        {
            int? userId = GetUserObject()?.Id;

            if (userId == null)
            {
                TempData["ErrorMessage"] = "You must be logged in.";
                return RedirectToAction("Index", "SignIn");
            }

            var rentalHistory = _context.RentalRequests
                .Where(r => r.UserId == userId)
                .Include(r => r.Equipment)
                .Include(r => r.RentalStatus1)
                .ToList();

            return View(rentalHistory);
        }
        public async Task<IActionResult> CreateRequestFromDetails(int equipmentId)
        {
            var user = GetUserObject();
            if (user == null)
            {
                TempData["ErrorMessage"] = "Please log in.";
                return RedirectToAction("Index", "SignIn");
            }

            var equipment = await _context.Equipment.FindAsync(equipmentId);
            if (equipment == null)
            {
                TempData["ErrorMessage"] = "Equipment not found.";
                return RedirectToAction("Index", "Equipment");
            }

            var request = new RentalRequest
            {
                EquipmentId = equipment.Id,
                UserId = user.Id,
                StartDate = DateTime.Now,
                ReturnDate = DateTime.Now.AddDays(7),
                Cost = equipment.Price * 7,
                RentalStatus = 1 // Pending
            };

            try
            {
                await _context.RentalRequests.AddAsync(request);
                await _context.SaveChangesAsync();

                // ✅ Save log
                await SaveLogAsync("Create Rental Request", $"Request created for Equipment: {equipment.Name}", "Web");

                TempData["SuccessMessage"] = "Rental request created and is now pending approval.";
                return RedirectToAction("Index"); // Go to My Requests page
            }
            catch (DbUpdateException ex)
            {
                TempData["ErrorMessage"] = $"Error creating rental request: {ex.InnerException?.Message ?? ex.Message}";
                return RedirectToAction("Index");
            }
        }


        [HttpPost]
        public async Task<IActionResult> Create(int equipmentId)
        {
            var user = GetUserObject();
            if (user == null)
            {
                TempData["ErrorMessage"] = "Please log in first.";
                return RedirectToAction("Index", "SignIn");
            }

            var equipment = await _context.Equipment.FindAsync(equipmentId);
            if (equipment == null)
            {
                TempData["ErrorMessage"] = "Equipment not found.";
                return RedirectToAction("Index", "Equipment");
            }

            var request = new RentalRequest
            {
                EquipmentId = equipment.Id,
                UserId = user.Id,
                StartDate = DateTime.Now,
                ReturnDate = DateTime.Now.AddDays(7),
                Cost = equipment.Price * 7,
                RentalStatus = 1 // Pending
            };

            try
            {
                await _context.RentalRequests.AddAsync(request);
                await _context.SaveChangesAsync();

                // ✅ Log action
                await SaveLogAsync("Create Rental Request", $"Request created for EquipmentID: {equipment.Id}", "Web");

                TempData["SuccessMessage"] = "Rental request submitted successfully!";
                return RedirectToAction("Index");
            }
            catch (DbUpdateException ex)
            {
                TempData["ErrorMessage"] = $"Error creating rental request: {ex.InnerException?.Message ?? ex.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Approve(int requestId)
        {
            var request = await _context.RentalRequests.FindAsync(requestId);
            if (request == null) return NotFound("Rental request not found.");

            request.RentalStatus = 2; // Approved
            await _context.SaveChangesAsync();

            // ✅ Log action
            await SaveLogAsync("Approve Rental Request", $"RequestID: {requestId} approved", "Web");

            TempData["SuccessMessage"] = "Rental request approved successfully!";
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Reject(int requestId)
        {
            var request = await _context.RentalRequests.FindAsync(requestId);
            if (request == null) return NotFound("Rental request not found.");

            request.RentalStatus = 3; // Rejected
            await _context.SaveChangesAsync();

            // ✅ Log action
            await SaveLogAsync("Reject Rental Request", $"RequestID: {requestId} rejected", "Web");

            TempData["ErrorMessage"] = "Rental request has been rejected.";
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Complete(int requestId)
        {
            var request = await _context.RentalRequests.FindAsync(requestId);
            if (request == null) return NotFound("Rental request not found.");

            request.RentalStatus = 8; // Completed
            await _context.SaveChangesAsync();

            // ✅ Log action
            await SaveLogAsync("Complete Rental", $"Rental completed for RequestID: {requestId}", "Web");

            TempData["SuccessMessage"] = "Rental marked as completed!";
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Payment(int requestId)
        {
            var rentalRequest = await _context.RentalRequests
                .Include(r => r.Equipment)
                .FirstOrDefaultAsync(r => r.Id == requestId);

            if (rentalRequest == null)
            {
                TempData["ErrorMessage"] = "Rental request not found.";
                return RedirectToAction("Index");
            }

            ViewBag.RentalRequest = rentalRequest;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ConfirmPayment(int requestId)
        {
            var rentalRequest = await _context.RentalRequests.FindAsync(requestId);
            if (rentalRequest == null)
            {
                TempData["ErrorMessage"] = "Rental request not found.";
                return RedirectToAction("Index");
            }

            // Update status to Completed (Paid)
            rentalRequest.RentalStatus = 8;
            await _context.SaveChangesAsync();

            await SaveLogAsync("Payment Completed", $"Rental request {requestId} marked as paid.", "Web");

            TempData["SuccessMessage"] = "Payment successful!";
            return RedirectToAction("Index");
        }


    
        // Show all users' rental requests for Admin
        public async Task<IActionResult> UserRequests()
        {
            var requests = await _context.RentalRequests
                .Include(r => r.User)
                .Include(r => r.Equipment)
                .Include(r => r.RentalStatus1)
                .ToListAsync();

            return View(requests);
        }


        [HttpPost]
        public async Task<IActionResult> AdminApprove(int requestId)
        {
            var request = await _context.RentalRequests.FindAsync(requestId);
            if (request == null)
            {
                return NotFound();
            }

            request.RentalStatus = 2; // Approved
            await _context.SaveChangesAsync();

            TempData["SuccessMessage"] = "Request approved successfully.";
            return RedirectToAction("UserRequests");
        }

        [HttpPost]
        public async Task<IActionResult> AdminReject(int requestId)
        {
            var request = await _context.RentalRequests.FindAsync(requestId);
            if (request == null)
            {
                return NotFound();
            }

            request.RentalStatus = 3; // Rejected
            await _context.SaveChangesAsync();

            TempData["ErrorMessage"] = "Request rejected.";
            return RedirectToAction("UserRequests");
        }

    }
}
