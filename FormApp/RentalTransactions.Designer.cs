namespace FormApp
{
    partial class RentalTransactions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentalTransactions));
            flowLayoutPanel2 = new FlowLayoutPanel();
            lblName = new Label();
            lblPosition = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            btnReturnRecords = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            panel3 = new Panel();
            btnReject = new Button();
            btnCreate = new Button();
            dataGridView1 = new DataGridView();
            btnFilter = new Button();
            btnSearch = new Button();
            textBox1 = new TextBox();
            btnAccept = new Button();
            flowLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(lblName);
            flowLayoutPanel2.Controls.Add(lblPosition);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(0, 1);
            flowLayoutPanel2.Margin = new Padding(0, 4, 0, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(3);
            flowLayoutPanel2.Size = new Size(811, 65);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(6, 3);
            lblName.Name = "lblName";
            lblName.Size = new Size(104, 31);
            lblName.TabIndex = 0;
            lblName.Text = "Sharmin";
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Location = new Point(6, 34);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(53, 20);
            lblPosition.TabIndex = 1;
            lblPosition.Text = "Admin";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(6, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(806, 3);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Location = new Point(217, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(3, 383);
            panel2.TabIndex = 8;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(btnReturnRecords);
            flowLayoutPanel1.Controls.Add(button5);
            flowLayoutPanel1.Controls.Add(button6);
            flowLayoutPanel1.Controls.Add(button7);
            flowLayoutPanel1.Controls.Add(button8);
            flowLayoutPanel1.Controls.Add(button9);
            flowLayoutPanel1.Controls.Add(button10);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(6, 62);
            flowLayoutPanel1.Margin = new Padding(10);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(0, 15, 0, 0);
            flowLayoutPanel1.Size = new Size(211, 398);
            flowLayoutPanel1.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(3, 18);
            button1.Name = "button1";
            button1.Size = new Size(208, 29);
            button1.TabIndex = 0;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Location = new Point(3, 53);
            button2.Name = "button2";
            button2.Size = new Size(208, 29);
            button2.TabIndex = 1;
            button2.Text = "Rental Requests";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(3, 88);
            button3.Name = "button3";
            button3.Size = new Size(208, 29);
            button3.TabIndex = 2;
            button3.Text = "Rental Transactions";
            button3.UseVisualStyleBackColor = false;
            // 
            // btnReturnRecords
            // 
            btnReturnRecords.Location = new Point(3, 123);
            btnReturnRecords.Name = "btnReturnRecords";
            btnReturnRecords.Size = new Size(208, 29);
            btnReturnRecords.TabIndex = 3;
            btnReturnRecords.Text = "Return Records";
            btnReturnRecords.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(3, 158);
            button5.Name = "button5";
            button5.Size = new Size(208, 29);
            button5.TabIndex = 4;
            button5.Text = "Equipment Management";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(3, 193);
            button6.Name = "button6";
            button6.Size = new Size(208, 29);
            button6.TabIndex = 5;
            button6.Text = "View Audit Logs";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(3, 228);
            button7.Name = "button7";
            button7.Size = new Size(208, 29);
            button7.TabIndex = 6;
            button7.Text = "Perform Database Backup";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(3, 263);
            button8.Name = "button8";
            button8.Size = new Size(208, 29);
            button8.TabIndex = 7;
            button8.Text = "Generate Report";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(3, 298);
            button9.Name = "button9";
            button9.Size = new Size(208, 29);
            button9.TabIndex = 8;
            button9.Text = "Log Out";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(3, 333);
            button10.Name = "button10";
            button10.Size = new Size(208, 29);
            button10.TabIndex = 9;
            button10.Text = "Exit";
            button10.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.Location = new Point(223, 74);
            panel3.Name = "panel3";
            panel3.Size = new Size(3, 393);
            panel3.TabIndex = 10;
            // 
            // btnReject
            // 
            btnReject.BackColor = Color.Red;
            btnReject.ForeColor = Color.White;
            btnReject.Location = new Point(529, 397);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(123, 39);
            btnReject.TabIndex = 22;
            btnReject.Text = "Reject";
            btnReject.UseVisualStyleBackColor = false;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.Black;
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(242, 397);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(123, 39);
            btnCreate.TabIndex = 21;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(242, 138);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(531, 242);
            dataGridView1.TabIndex = 20;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.FromArgb(255, 128, 0);
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(691, 86);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(94, 29);
            btnFilter.TabIndex = 19;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(255, 128, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(591, 86);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 18;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.ForeColor = SystemColors.ScrollBar;
            textBox1.Location = new Point(242, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(320, 27);
            textBox1.TabIndex = 17;
            textBox1.Text = "Transaction ID";
            // 
            // btnAccept
            // 
            btnAccept.BackColor = Color.Black;
            btnAccept.ForeColor = Color.White;
            btnAccept.Location = new Point(387, 397);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(123, 39);
            btnAccept.TabIndex = 23;
            btnAccept.Text = "Accept";
            btnAccept.UseVisualStyleBackColor = false;
            // 
            // RentalTransactions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAccept);
            Controls.Add(btnReject);
            Controls.Add(btnCreate);
            Controls.Add(dataGridView1);
            Controls.Add(btnFilter);
            Controls.Add(btnSearch);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RentalTransactions";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RentalTransactions";
            Load += RentalTransactions_Load;
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel2;
        private Label lblName;
        private Label lblPosition;
        private Panel panel1;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button btnReturnRecords;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Panel panel3;
        private Button btnReject;
        private Button btnCreate;
        private DataGridView dataGridView1;
        private Button btnFilter;
        private Button btnSearch;
        private TextBox textBox1;
        private Button btnAccept;
    }
}