namespace Bai2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fullName = new System.Windows.Forms.TextBox();
            this.addr = new System.Windows.Forms.TextBox();
            this.dob = new System.Windows.Forms.MaskedTextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.countries = new System.Windows.Forms.ComboBox();
            this.quali = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.MaskedTextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.dateJoin = new System.Windows.Forms.DateTimePicker();
            this.linkVN = new System.Windows.Forms.LinkLabel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fullName
            // 
            this.fullName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fullName.Location = new System.Drawing.Point(208, 42);
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(219, 27);
            this.fullName.TabIndex = 0;
            this.fullName.TextChanged += new System.EventHandler(this.fullName_TextChanged);
            this.fullName.Enter += new System.EventHandler(this.fullName_Enter);
            this.fullName.Leave += new System.EventHandler(this.fullName_Leave);
            this.fullName.Validated += new System.EventHandler(this.fullName_Validated);
            // 
            // addr
            // 
            this.addr.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addr.Location = new System.Drawing.Point(208, 148);
            this.addr.Name = "addr";
            this.addr.Size = new System.Drawing.Size(219, 27);
            this.addr.TabIndex = 1;
            // 
            // dob
            // 
            this.dob.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dob.Location = new System.Drawing.Point(208, 95);
            this.dob.Mask = "00/00/0000";
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(142, 27);
            this.dob.TabIndex = 2;
            this.dob.ValidatingType = typeof(System.DateTime);
            this.dob.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.dob_MaskInputRejected);
            this.dob.Leave += new System.EventHandler(this.dob_Leave);
            this.dob.Validating += new System.ComponentModel.CancelEventHandler(this.dob_Validating);
            this.dob.Validated += new System.EventHandler(this.dob_Validated);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(208, 203);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(219, 27);
            this.textBox3.TabIndex = 3;
            // 
            // countries
            // 
            this.countries.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.countries.FormattingEnabled = true;
            this.countries.Location = new System.Drawing.Point(207, 256);
            this.countries.Name = "countries";
            this.countries.Size = new System.Drawing.Size(121, 28);
            this.countries.TabIndex = 4;
            // 
            // quali
            // 
            this.quali.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quali.Location = new System.Drawing.Point(207, 311);
            this.quali.Name = "quali";
            this.quali.Size = new System.Drawing.Size(219, 27);
            this.quali.TabIndex = 5;
            // 
            // phone
            // 
            this.phone.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phone.Location = new System.Drawing.Point(208, 362);
            this.phone.Mask = "000-0000000";
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(218, 27);
            this.phone.TabIndex = 6;
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.email.Location = new System.Drawing.Point(207, 417);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(219, 27);
            this.email.TabIndex = 7;
            // 
            // dateJoin
            // 
            this.dateJoin.CalendarFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateJoin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateJoin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateJoin.Location = new System.Drawing.Point(207, 473);
            this.dateJoin.Name = "dateJoin";
            this.dateJoin.Size = new System.Drawing.Size(219, 27);
            this.dateJoin.TabIndex = 8;
            // 
            // linkVN
            // 
            this.linkVN.AutoSize = true;
            this.linkVN.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkVN.Location = new System.Drawing.Point(65, 548);
            this.linkVN.Name = "linkVN";
            this.linkVN.Size = new System.Drawing.Size(126, 20);
            this.linkVN.TabIndex = 9;
            this.linkVN.TabStop = true;
            this.linkVN.Text = "Link to VNExpress";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.Location = new System.Drawing.Point(208, 526);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(86, 42);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(340, 526);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 42);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(65, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Employee Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(90, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Date of Birth: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(88, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "(mm/dd/yyyy)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(122, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Address: ";
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.city.Location = new System.Drawing.Point(150, 203);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(41, 20);
            this.city.TabIndex = 16;
            this.city.Text = "City: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(128, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Country:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(94, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Qualification:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(138, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Phone:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(142, 420);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Email:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(74, 473);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Date of Joining: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(88, 502);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "(mm/dd/yyyy)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 594);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.city);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.linkVN);
            this.Controls.Add(this.dateJoin);
            this.Controls.Add(this.email);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.quali);
            this.Controls.Add(this.countries);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.addr);
            this.Controls.Add(this.fullName);
            this.Name = "Form1";
            this.Text = "Employee Details";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox fullName;
        private TextBox addr;
        private MaskedTextBox dob;
        private TextBox textBox3;
        private ComboBox countries;
        private TextBox quali;
        private MaskedTextBox phone;
        private TextBox email;
        private DateTimePicker dateJoin;
        private LinkLabel linkVN;
        private Button btnSubmit;
        private Button btnExit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label city;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}