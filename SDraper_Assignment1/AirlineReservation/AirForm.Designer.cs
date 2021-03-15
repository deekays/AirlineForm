namespace AirlineReservation
{
    partial class AirForm
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
            this.btnShowWaitingList = new System.Windows.Forms.Button();
            this.btnAllSeats = new System.Windows.Forms.Button();
            this.txtShowWaitingList = new System.Windows.Forms.TextBox();
            this.txtAllSeats = new System.Windows.Forms.TextBox();
            this.grbBooking = new System.Windows.Forms.GroupBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnFillAll = new System.Windows.Forms.Button();
            this.btnWaitingList = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.grbSeats = new System.Windows.Forms.GroupBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.rdbD5 = new System.Windows.Forms.RadioButton();
            this.rdbC5 = new System.Windows.Forms.RadioButton();
            this.rdbB5 = new System.Windows.Forms.RadioButton();
            this.rdbA5 = new System.Windows.Forms.RadioButton();
            this.rdbD4 = new System.Windows.Forms.RadioButton();
            this.rdbC4 = new System.Windows.Forms.RadioButton();
            this.rdbB4 = new System.Windows.Forms.RadioButton();
            this.rdbA4 = new System.Windows.Forms.RadioButton();
            this.rdbD3 = new System.Windows.Forms.RadioButton();
            this.rdbC3 = new System.Windows.Forms.RadioButton();
            this.rdbB3 = new System.Windows.Forms.RadioButton();
            this.rdbA3 = new System.Windows.Forms.RadioButton();
            this.rdbD2 = new System.Windows.Forms.RadioButton();
            this.rdbC2 = new System.Windows.Forms.RadioButton();
            this.rdbB2 = new System.Windows.Forms.RadioButton();
            this.rdbA2 = new System.Windows.Forms.RadioButton();
            this.rdbD1 = new System.Windows.Forms.RadioButton();
            this.rdbC1 = new System.Windows.Forms.RadioButton();
            this.rdbB1 = new System.Windows.Forms.RadioButton();
            this.rdbA1 = new System.Windows.Forms.RadioButton();
            this.grbBooking.SuspendLayout();
            this.grbSeats.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowWaitingList
            // 
            this.btnShowWaitingList.Location = new System.Drawing.Point(288, 262);
            this.btnShowWaitingList.Name = "btnShowWaitingList";
            this.btnShowWaitingList.Size = new System.Drawing.Size(213, 23);
            this.btnShowWaitingList.TabIndex = 11;
            this.btnShowWaitingList.Text = "Show Waiting List";
            this.btnShowWaitingList.UseVisualStyleBackColor = true;
            this.btnShowWaitingList.Click += new System.EventHandler(this.btnShowWaitingList_Click);
            // 
            // btnAllSeats
            // 
            this.btnAllSeats.Location = new System.Drawing.Point(36, 262);
            this.btnAllSeats.Name = "btnAllSeats";
            this.btnAllSeats.Size = new System.Drawing.Size(213, 23);
            this.btnAllSeats.TabIndex = 10;
            this.btnAllSeats.Text = "Show All Seats";
            this.btnAllSeats.UseVisualStyleBackColor = true;
            this.btnAllSeats.Click += new System.EventHandler(this.btnAllSeats_Click);
            // 
            // txtShowWaitingList
            // 
            this.txtShowWaitingList.Location = new System.Drawing.Point(288, 291);
            this.txtShowWaitingList.Multiline = true;
            this.txtShowWaitingList.Name = "txtShowWaitingList";
            this.txtShowWaitingList.ReadOnly = true;
            this.txtShowWaitingList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtShowWaitingList.Size = new System.Drawing.Size(213, 224);
            this.txtShowWaitingList.TabIndex = 9;
            // 
            // txtAllSeats
            // 
            this.txtAllSeats.Location = new System.Drawing.Point(36, 291);
            this.txtAllSeats.Multiline = true;
            this.txtAllSeats.Name = "txtAllSeats";
            this.txtAllSeats.ReadOnly = true;
            this.txtAllSeats.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAllSeats.Size = new System.Drawing.Size(213, 224);
            this.txtAllSeats.TabIndex = 8;
            // 
            // grbBooking
            // 
            this.grbBooking.Controls.Add(this.lblOutput);
            this.grbBooking.Controls.Add(this.btnFillAll);
            this.grbBooking.Controls.Add(this.btnWaitingList);
            this.grbBooking.Controls.Add(this.btnCancel);
            this.grbBooking.Controls.Add(this.btnBook);
            this.grbBooking.Controls.Add(this.lblName);
            this.grbBooking.Controls.Add(this.txtName);
            this.grbBooking.Location = new System.Drawing.Point(256, 12);
            this.grbBooking.Name = "grbBooking";
            this.grbBooking.Size = new System.Drawing.Size(276, 232);
            this.grbBooking.TabIndex = 7;
            this.grbBooking.TabStop = false;
            this.grbBooking.Text = "Booking and Cancellation";
            // 
            // lblOutput
            // 
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutput.Location = new System.Drawing.Point(9, 143);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(255, 75);
            this.lblOutput.TabIndex = 2;
            // 
            // btnFillAll
            // 
            this.btnFillAll.Location = new System.Drawing.Point(173, 77);
            this.btnFillAll.Name = "btnFillAll";
            this.btnFillAll.Size = new System.Drawing.Size(91, 53);
            this.btnFillAll.TabIndex = 5;
            this.btnFillAll.Text = "Fill All Seats (debug)";
            this.btnFillAll.UseVisualStyleBackColor = true;
            this.btnFillAll.Click += new System.EventHandler(this.btnFillAll_Click);
            // 
            // btnWaitingList
            // 
            this.btnWaitingList.Location = new System.Drawing.Point(9, 107);
            this.btnWaitingList.Name = "btnWaitingList";
            this.btnWaitingList.Size = new System.Drawing.Size(157, 23);
            this.btnWaitingList.TabIndex = 4;
            this.btnWaitingList.Text = "Add to Waiting List";
            this.btnWaitingList.UseVisualStyleBackColor = true;
            this.btnWaitingList.Click += new System.EventHandler(this.btnWaitingList_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(91, 76);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(9, 77);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(75, 23);
            this.btnBook.TabIndex = 2;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(50, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(214, 20);
            this.txtName.TabIndex = 0;
            // 
            // grbSeats
            // 
            this.grbSeats.Controls.Add(this.lbl5);
            this.grbSeats.Controls.Add(this.lbl4);
            this.grbSeats.Controls.Add(this.lbl3);
            this.grbSeats.Controls.Add(this.lbl2);
            this.grbSeats.Controls.Add(this.lbl1);
            this.grbSeats.Controls.Add(this.lblD);
            this.grbSeats.Controls.Add(this.lblC);
            this.grbSeats.Controls.Add(this.lblB);
            this.grbSeats.Controls.Add(this.lblA);
            this.grbSeats.Controls.Add(this.rdbD5);
            this.grbSeats.Controls.Add(this.rdbC5);
            this.grbSeats.Controls.Add(this.rdbB5);
            this.grbSeats.Controls.Add(this.rdbA5);
            this.grbSeats.Controls.Add(this.rdbD4);
            this.grbSeats.Controls.Add(this.rdbC4);
            this.grbSeats.Controls.Add(this.rdbB4);
            this.grbSeats.Controls.Add(this.rdbA4);
            this.grbSeats.Controls.Add(this.rdbD3);
            this.grbSeats.Controls.Add(this.rdbC3);
            this.grbSeats.Controls.Add(this.rdbB3);
            this.grbSeats.Controls.Add(this.rdbA3);
            this.grbSeats.Controls.Add(this.rdbD2);
            this.grbSeats.Controls.Add(this.rdbC2);
            this.grbSeats.Controls.Add(this.rdbB2);
            this.grbSeats.Controls.Add(this.rdbA2);
            this.grbSeats.Controls.Add(this.rdbD1);
            this.grbSeats.Controls.Add(this.rdbC1);
            this.grbSeats.Controls.Add(this.rdbB1);
            this.grbSeats.Controls.Add(this.rdbA1);
            this.grbSeats.Location = new System.Drawing.Point(12, 12);
            this.grbSeats.Name = "grbSeats";
            this.grbSeats.Size = new System.Drawing.Size(214, 232);
            this.grbSeats.TabIndex = 6;
            this.grbSeats.TabStop = false;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(20, 169);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(19, 20);
            this.lbl5.TabIndex = 29;
            this.lbl5.Text = "5";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(20, 138);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(19, 20);
            this.lbl4.TabIndex = 28;
            this.lbl4.Text = "4";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(20, 107);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(19, 20);
            this.lbl3.TabIndex = 27;
            this.lbl3.Text = "3";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(20, 76);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(19, 20);
            this.lbl2.TabIndex = 26;
            this.lbl2.Text = "2";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(20, 45);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(19, 20);
            this.lbl1.TabIndex = 25;
            this.lbl1.Text = "1";
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblD.Location = new System.Drawing.Point(159, 21);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(22, 20);
            this.lblD.TabIndex = 24;
            this.lblD.Text = "D";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.Location = new System.Drawing.Point(132, 21);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(21, 20);
            this.lblC.TabIndex = 23;
            this.lblC.Text = "C";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.Location = new System.Drawing.Point(78, 21);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(21, 20);
            this.lblB.TabIndex = 22;
            this.lblB.Text = "B";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(51, 21);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(21, 20);
            this.lblA.TabIndex = 21;
            this.lblA.Text = "A";
            // 
            // rdbD5
            // 
            this.rdbD5.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbD5.AutoSize = true;
            this.rdbD5.Location = new System.Drawing.Point(159, 168);
            this.rdbD5.MinimumSize = new System.Drawing.Size(25, 25);
            this.rdbD5.Name = "rdbD5";
            this.rdbD5.Size = new System.Drawing.Size(25, 25);
            this.rdbD5.TabIndex = 20;
            this.rdbD5.Tag = "43";
            this.rdbD5.UseVisualStyleBackColor = true;
            this.rdbD5.Click += new System.EventHandler(this.Seat_Click);
            // 
            // rdbC5
            // 
            this.rdbC5.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbC5.AutoSize = true;
            this.rdbC5.Location = new System.Drawing.Point(128, 168);
            this.rdbC5.MinimumSize = new System.Drawing.Size(25, 25);
            this.rdbC5.Name = "rdbC5";
            this.rdbC5.Size = new System.Drawing.Size(25, 25);
            this.rdbC5.TabIndex = 19;
            this.rdbC5.Tag = "42";
            this.rdbC5.UseVisualStyleBackColor = true;
            this.rdbC5.Click += new System.EventHandler(this.Seat_Click);
            // 
            // rdbB5
            // 
            this.rdbB5.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbB5.AutoSize = true;
            this.rdbB5.Location = new System.Drawing.Point(78, 168);
            this.rdbB5.MinimumSize = new System.Drawing.Size(25, 25);
            this.rdbB5.Name = "rdbB5";
            this.rdbB5.Size = new System.Drawing.Size(25, 25);
            this.rdbB5.TabIndex = 18;
            this.rdbB5.Tag = "41";
            this.rdbB5.UseVisualStyleBackColor = true;
            this.rdbB5.Click += new System.EventHandler(this.Seat_Click);
            // 
            // rdbA5
            // 
            this.rdbA5.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbA5.AutoSize = true;
            this.rdbA5.Location = new System.Drawing.Point(47, 168);
            this.rdbA5.MinimumSize = new System.Drawing.Size(25, 25);
            this.rdbA5.Name = "rdbA5";
            this.rdbA5.Size = new System.Drawing.Size(25, 25);
            this.rdbA5.TabIndex = 17;
            this.rdbA5.Tag = "40";
            this.rdbA5.UseVisualStyleBackColor = true;
            this.rdbA5.Click += new System.EventHandler(this.Seat_Click);
            // 
            // rdbD4
            // 
            this.rdbD4.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbD4.AutoSize = true;
            this.rdbD4.Location = new System.Drawing.Point(159, 137);
            this.rdbD4.MinimumSize = new System.Drawing.Size(25, 25);
            this.rdbD4.Name = "rdbD4";
            this.rdbD4.Size = new System.Drawing.Size(25, 25);
            this.rdbD4.TabIndex = 16;
            this.rdbD4.Tag = "33";
            this.rdbD4.UseVisualStyleBackColor = true;
            this.rdbD4.Click += new System.EventHandler(this.Seat_Click);
            // 
            // rdbC4
            // 
            this.rdbC4.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbC4.AutoSize = true;
            this.rdbC4.Location = new System.Drawing.Point(128, 137);
            this.rdbC4.MinimumSize = new System.Drawing.Size(25, 25);
            this.rdbC4.Name = "rdbC4";
            this.rdbC4.Size = new System.Drawing.Size(25, 25);
            this.rdbC4.TabIndex = 15;
            this.rdbC4.Tag = "32";
            this.rdbC4.UseVisualStyleBackColor = true;
            this.rdbC4.Click += new System.EventHandler(this.Seat_Click);
            // 
            // rdbB4
            // 
            this.rdbB4.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbB4.AutoSize = true;
            this.rdbB4.Location = new System.Drawing.Point(78, 137);
            this.rdbB4.MinimumSize = new System.Drawing.Size(25, 25);
            this.rdbB4.Name = "rdbB4";
            this.rdbB4.Size = new System.Drawing.Size(25, 25);
            this.rdbB4.TabIndex = 14;
            this.rdbB4.Tag = "31";
            this.rdbB4.UseVisualStyleBackColor = true;
            this.rdbB4.Click += new System.EventHandler(this.Seat_Click);
            // 
            // rdbA4
            // 
            this.rdbA4.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbA4.AutoSize = true;
            this.rdbA4.Location = new System.Drawing.Point(47, 137);
            this.rdbA4.MinimumSize = new System.Drawing.Size(25, 25);
            this.rdbA4.Name = "rdbA4";
            this.rdbA4.Size = new System.Drawing.Size(25, 25);
            this.rdbA4.TabIndex = 13;
            this.rdbA4.Tag = "30";
            this.rdbA4.UseVisualStyleBackColor = true;
            this.rdbA4.Click += new System.EventHandler(this.Seat_Click);
            // 
            // rdbD3
            // 
            this.rdbD3.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbD3.AutoSize = true;
            this.rdbD3.Location = new System.Drawing.Point(159, 106);
            this.rdbD3.MinimumSize = new System.Drawing.Size(25, 25);
            this.rdbD3.Name = "rdbD3";
            this.rdbD3.Size = new System.Drawing.Size(25, 25);
            this.rdbD3.TabIndex = 12;
            this.rdbD3.Tag = "23";
            this.rdbD3.UseVisualStyleBackColor = true;
            this.rdbD3.Click += new System.EventHandler(this.Seat_Click);
            // 
            // rdbC3
            // 
            this.rdbC3.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbC3.AutoSize = true;
            this.rdbC3.Location = new System.Drawing.Point(128, 106);
            this.rdbC3.MinimumSize = new System.Drawing.Size(25, 25);
            this.rdbC3.Name = "rdbC3";
            this.rdbC3.Size = new System.Drawing.Size(25, 25);
            this.rdbC3.TabIndex = 11;
            this.rdbC3.Tag = "22";
            this.rdbC3.UseVisualStyleBackColor = true;
            this.rdbC3.Click += new System.EventHandler(this.Seat_Click);
            // 
            // rdbB3
            // 
            this.rdbB3.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbB3.AutoSize = true;
            this.rdbB3.Location = new System.Drawing.Point(78, 106);
            this.rdbB3.MinimumSize = new System.Drawing.Size(25, 25);
            this.rdbB3.Name = "rdbB3";
            this.rdbB3.Size = new System.Drawing.Size(25, 25);
            this.rdbB3.TabIndex = 10;
            this.rdbB3.Tag = "21";
            this.rdbB3.UseVisualStyleBackColor = true;
            this.rdbB3.Click += new System.EventHandler(this.Seat_Click);
            // 
            // rdbA3
            // 
            this.rdbA3.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbA3.AutoSize = true;
            this.rdbA3.Location = new System.Drawing.Point(47, 106);
            this.rdbA3.MinimumSize = new System.Drawing.Size(25, 25);
            this.rdbA3.Name = "rdbA3";
            this.rdbA3.Size = new System.Drawing.Size(25, 25);
            this.rdbA3.TabIndex = 9;
            this.rdbA3.Tag = "20";
            this.rdbA3.UseVisualStyleBackColor = true;
            this.rdbA3.Click += new System.EventHandler(this.Seat_Click);
            // 
            // rdbD2
            // 
            this.rdbD2.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbD2.AutoSize = true;
            this.rdbD2.Location = new System.Drawing.Point(159, 75);
            this.rdbD2.MinimumSize = new System.Drawing.Size(25, 25);
            this.rdbD2.Name = "rdbD2";
            this.rdbD2.Size = new System.Drawing.Size(25, 25);
            this.rdbD2.TabIndex = 8;
            this.rdbD2.Tag = "13";
            this.rdbD2.UseVisualStyleBackColor = true;
            this.rdbD2.Click += new System.EventHandler(this.Seat_Click);
            // 
            // rdbC2
            // 
            this.rdbC2.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbC2.AutoSize = true;
            this.rdbC2.Location = new System.Drawing.Point(128, 75);
            this.rdbC2.MinimumSize = new System.Drawing.Size(25, 25);
            this.rdbC2.Name = "rdbC2";
            this.rdbC2.Size = new System.Drawing.Size(25, 25);
            this.rdbC2.TabIndex = 7;
            this.rdbC2.Tag = "12";
            this.rdbC2.UseVisualStyleBackColor = true;
            this.rdbC2.Click += new System.EventHandler(this.Seat_Click);
            // 
            // rdbB2
            // 
            this.rdbB2.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbB2.AutoSize = true;
            this.rdbB2.Location = new System.Drawing.Point(78, 75);
            this.rdbB2.MinimumSize = new System.Drawing.Size(25, 25);
            this.rdbB2.Name = "rdbB2";
            this.rdbB2.Size = new System.Drawing.Size(25, 25);
            this.rdbB2.TabIndex = 6;
            this.rdbB2.Tag = "11";
            this.rdbB2.UseVisualStyleBackColor = true;
            this.rdbB2.Click += new System.EventHandler(this.Seat_Click);
            // 
            // rdbA2
            // 
            this.rdbA2.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbA2.AutoSize = true;
            this.rdbA2.Location = new System.Drawing.Point(47, 75);
            this.rdbA2.MinimumSize = new System.Drawing.Size(25, 25);
            this.rdbA2.Name = "rdbA2";
            this.rdbA2.Size = new System.Drawing.Size(25, 25);
            this.rdbA2.TabIndex = 5;
            this.rdbA2.Tag = "10";
            this.rdbA2.UseVisualStyleBackColor = true;
            this.rdbA2.Click += new System.EventHandler(this.Seat_Click);
            // 
            // rdbD1
            // 
            this.rdbD1.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbD1.AutoSize = true;
            this.rdbD1.Location = new System.Drawing.Point(159, 44);
            this.rdbD1.MinimumSize = new System.Drawing.Size(25, 25);
            this.rdbD1.Name = "rdbD1";
            this.rdbD1.Size = new System.Drawing.Size(25, 25);
            this.rdbD1.TabIndex = 4;
            this.rdbD1.Tag = "03";
            this.rdbD1.UseVisualStyleBackColor = true;
            this.rdbD1.Click += new System.EventHandler(this.Seat_Click);
            // 
            // rdbC1
            // 
            this.rdbC1.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbC1.AutoSize = true;
            this.rdbC1.Location = new System.Drawing.Point(128, 44);
            this.rdbC1.MinimumSize = new System.Drawing.Size(25, 25);
            this.rdbC1.Name = "rdbC1";
            this.rdbC1.Size = new System.Drawing.Size(25, 25);
            this.rdbC1.TabIndex = 3;
            this.rdbC1.Tag = "02";
            this.rdbC1.UseVisualStyleBackColor = true;
            this.rdbC1.Click += new System.EventHandler(this.Seat_Click);
            // 
            // rdbB1
            // 
            this.rdbB1.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbB1.AutoSize = true;
            this.rdbB1.Location = new System.Drawing.Point(78, 44);
            this.rdbB1.MinimumSize = new System.Drawing.Size(25, 25);
            this.rdbB1.Name = "rdbB1";
            this.rdbB1.Size = new System.Drawing.Size(25, 25);
            this.rdbB1.TabIndex = 2;
            this.rdbB1.Tag = "01";
            this.rdbB1.UseVisualStyleBackColor = true;
            this.rdbB1.Click += new System.EventHandler(this.Seat_Click);
            // 
            // rdbA1
            // 
            this.rdbA1.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbA1.AutoSize = true;
            this.rdbA1.Location = new System.Drawing.Point(47, 44);
            this.rdbA1.MinimumSize = new System.Drawing.Size(25, 25);
            this.rdbA1.Name = "rdbA1";
            this.rdbA1.Size = new System.Drawing.Size(25, 25);
            this.rdbA1.TabIndex = 1;
            this.rdbA1.Tag = "00";
            this.rdbA1.UseVisualStyleBackColor = true;
            this.rdbA1.Click += new System.EventHandler(this.Seat_Click);
            // 
            // AirForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 542);
            this.Controls.Add(this.btnShowWaitingList);
            this.Controls.Add(this.btnAllSeats);
            this.Controls.Add(this.txtShowWaitingList);
            this.Controls.Add(this.txtAllSeats);
            this.Controls.Add(this.grbBooking);
            this.Controls.Add(this.grbSeats);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AirForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Airline Reservation";
            this.grbBooking.ResumeLayout(false);
            this.grbBooking.PerformLayout();
            this.grbSeats.ResumeLayout(false);
            this.grbSeats.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowWaitingList;
        private System.Windows.Forms.Button btnAllSeats;
        private System.Windows.Forms.TextBox txtShowWaitingList;
        private System.Windows.Forms.TextBox txtAllSeats;
        private System.Windows.Forms.GroupBox grbBooking;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnFillAll;
        private System.Windows.Forms.Button btnWaitingList;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox grbSeats;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.RadioButton rdbD5;
        private System.Windows.Forms.RadioButton rdbC5;
        private System.Windows.Forms.RadioButton rdbB5;
        private System.Windows.Forms.RadioButton rdbA5;
        private System.Windows.Forms.RadioButton rdbD4;
        private System.Windows.Forms.RadioButton rdbC4;
        private System.Windows.Forms.RadioButton rdbB4;
        private System.Windows.Forms.RadioButton rdbA4;
        private System.Windows.Forms.RadioButton rdbD3;
        private System.Windows.Forms.RadioButton rdbC3;
        private System.Windows.Forms.RadioButton rdbB3;
        private System.Windows.Forms.RadioButton rdbA3;
        private System.Windows.Forms.RadioButton rdbD2;
        private System.Windows.Forms.RadioButton rdbC2;
        private System.Windows.Forms.RadioButton rdbB2;
        private System.Windows.Forms.RadioButton rdbA2;
        private System.Windows.Forms.RadioButton rdbD1;
        private System.Windows.Forms.RadioButton rdbC1;
        private System.Windows.Forms.RadioButton rdbB1;
        private System.Windows.Forms.RadioButton rdbA1;
    }
}

