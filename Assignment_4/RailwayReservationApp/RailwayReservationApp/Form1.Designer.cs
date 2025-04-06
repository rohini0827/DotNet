namespace RailwayReservationApp
{
    partial class Form1
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPassengerName = new System.Windows.Forms.Label();
            this.txtPassengerName = new System.Windows.Forms.TextBox();
            this.lblSource = new System.Windows.Forms.Label();
            this.cmbSource = new System.Windows.Forms.ComboBox();
            this.lblDestination = new System.Windows.Forms.Label();
            this.cmbDestination = new System.Windows.Forms.ComboBox();
            this.lblTrain = new System.Windows.Forms.Label();
            this.cmbTrain = new System.Windows.Forms.ComboBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.rdoAC = new System.Windows.Forms.RadioButton();
            this.rdoNonAC = new System.Windows.Forms.RadioButton();
            this.lblTickets = new System.Windows.Forms.Label();
            this.numTickets = new System.Windows.Forms.NumericUpDown();
            this.lblTotalFare = new System.Windows.Forms.Label();
            this.txtTotalFare = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpJourneyDate = new System.Windows.Forms.DateTimePicker();
            this.lstSummary = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(186, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(318, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Railway Reservation Form";
            // 
            // lblPassengerName
            // 
            this.lblPassengerName.AutoSize = true;
            this.lblPassengerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassengerName.Location = new System.Drawing.Point(46, 80);
            this.lblPassengerName.Name = "lblPassengerName";
            this.lblPassengerName.Size = new System.Drawing.Size(127, 16);
            this.lblPassengerName.TabIndex = 9;
            this.lblPassengerName.Text = "Passenger Name";
            // 
            // txtPassengerName
            // 
            this.txtPassengerName.Location = new System.Drawing.Point(247, 74);
            this.txtPassengerName.Name = "txtPassengerName";
            this.txtPassengerName.Size = new System.Drawing.Size(120, 22);
            this.txtPassengerName.TabIndex = 10;
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSource.Location = new System.Drawing.Point(46, 116);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(156, 16);
            this.lblSource.TabIndex = 11;
            this.lblSource.Text = "Select Source Station";
            // 
            // cmbSource
            // 
            this.cmbSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSource.FormattingEnabled = true;
            this.cmbSource.Items.AddRange(new object[] {
            "Pune ",
            "Mumbai",
            "Kolkata",
            "Delhi",
            "Hyderabad",
            "Chennai",
            "Bengaluru"});
            this.cmbSource.Location = new System.Drawing.Point(247, 113);
            this.cmbSource.Name = "cmbSource";
            this.cmbSource.Size = new System.Drawing.Size(121, 24);
            this.cmbSource.TabIndex = 12;
            this.cmbSource.SelectedIndexChanged += new System.EventHandler(this.cmbSource_SelectedIndexChanged);
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestination.Location = new System.Drawing.Point(46, 152);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(133, 16);
            this.lblDestination.TabIndex = 13;
            this.lblDestination.Text = "Select Destination";
            // 
            // cmbDestination
            // 
            this.cmbDestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestination.FormattingEnabled = true;
            this.cmbDestination.Items.AddRange(new object[] {
            "Pune ",
            "Mumbai",
            "Kolkata",
            "Delhi",
            "Hyderabad",
            "Chennai",
            "Bengaluru"});
            this.cmbDestination.Location = new System.Drawing.Point(247, 152);
            this.cmbDestination.Name = "cmbDestination";
            this.cmbDestination.Size = new System.Drawing.Size(121, 24);
            this.cmbDestination.TabIndex = 14;
            this.cmbDestination.SelectedIndexChanged += new System.EventHandler(this.cmbDestination_SelectedIndexChanged);
            // 
            // lblTrain
            // 
            this.lblTrain.AutoSize = true;
            this.lblTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrain.Location = new System.Drawing.Point(46, 194);
            this.lblTrain.Name = "lblTrain";
            this.lblTrain.Size = new System.Drawing.Size(91, 16);
            this.lblTrain.TabIndex = 15;
            this.lblTrain.Text = "Select Train";
            // 
            // cmbTrain
            // 
            this.cmbTrain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrain.FormattingEnabled = true;
            this.cmbTrain.Items.AddRange(new object[] {
            "Express Train",
            "Superfast Train",
            "Local Train"});
            this.cmbTrain.Location = new System.Drawing.Point(247, 186);
            this.cmbTrain.Name = "cmbTrain";
            this.cmbTrain.Size = new System.Drawing.Size(121, 24);
            this.cmbTrain.TabIndex = 16;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(46, 235);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(186, 16);
            this.lblClass.TabIndex = 17;
            this.lblClass.Text = "Select Class (AC/Non-AC)";
            // 
            // rdoAC
            // 
            this.rdoAC.AutoSize = true;
            this.rdoAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAC.Location = new System.Drawing.Point(266, 233);
            this.rdoAC.Name = "rdoAC";
            this.rdoAC.Size = new System.Drawing.Size(91, 20);
            this.rdoAC.TabIndex = 18;
            this.rdoAC.TabStop = true;
            this.rdoAC.Text = "AC Class";
            this.rdoAC.UseVisualStyleBackColor = true;
            // 
            // rdoNonAC
            // 
            this.rdoNonAC.AutoSize = true;
            this.rdoNonAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNonAC.Location = new System.Drawing.Point(406, 231);
            this.rdoNonAC.Name = "rdoNonAC";
            this.rdoNonAC.Size = new System.Drawing.Size(124, 20);
            this.rdoNonAC.TabIndex = 19;
            this.rdoNonAC.TabStop = true;
            this.rdoNonAC.Text = "Non-AC Class";
            this.rdoNonAC.UseVisualStyleBackColor = true;
            // 
            // lblTickets
            // 
            this.lblTickets.AutoSize = true;
            this.lblTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTickets.Location = new System.Drawing.Point(46, 270);
            this.lblTickets.Name = "lblTickets";
            this.lblTickets.Size = new System.Drawing.Size(173, 16);
            this.lblTickets.TabIndex = 20;
            this.lblTickets.Text = "Enter Number of Tickets";
            // 
            // numTickets
            // 
            this.numTickets.Location = new System.Drawing.Point(247, 264);
            this.numTickets.Name = "numTickets";
            this.numTickets.Size = new System.Drawing.Size(120, 22);
            this.numTickets.TabIndex = 21;
            // 
            // lblTotalFare
            // 
            this.lblTotalFare.AutoSize = true;
            this.lblTotalFare.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFare.Location = new System.Drawing.Point(46, 307);
            this.lblTotalFare.Name = "lblTotalFare";
            this.lblTotalFare.Size = new System.Drawing.Size(136, 16);
            this.lblTotalFare.TabIndex = 22;
            this.lblTotalFare.Text = "Display Total Fare";
            // 
            // txtTotalFare
            // 
            this.txtTotalFare.Cursor = System.Windows.Forms.Cursors.No;
            this.txtTotalFare.Location = new System.Drawing.Point(247, 301);
            this.txtTotalFare.Name = "txtTotalFare";
            this.txtTotalFare.ReadOnly = true;
            this.txtTotalFare.Size = new System.Drawing.Size(121, 22);
            this.txtTotalFare.TabIndex = 23;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(52, 347);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(115, 23);
            this.btnCalculate.TabIndex = 24;
            this.btnCalculate.Text = "Calculate Fare";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnBook
            // 
            this.btnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.Location = new System.Drawing.Point(232, 347);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(110, 23);
            this.btnBook.TabIndex = 25;
            this.btnBook.Text = "Book Ticket";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(393, 347);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(111, 23);
            this.btnReset.TabIndex = 26;
            this.btnReset.Text = "Reset Form";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(403, 186);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(164, 16);
            this.lblDate.TabIndex = 28;
            this.lblDate.Text = "Select Date of Journey";
            // 
            // dtpJourneyDate
            // 
            this.dtpJourneyDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpJourneyDate.Location = new System.Drawing.Point(552, 186);
            this.dtpJourneyDate.Name = "dtpJourneyDate";
            this.dtpJourneyDate.Size = new System.Drawing.Size(200, 22);
            this.dtpJourneyDate.TabIndex = 29;
            // 
            // lstSummary
            // 
            this.lstSummary.FormattingEnabled = true;
            this.lstSummary.ItemHeight = 16;
            this.lstSummary.Location = new System.Drawing.Point(82, 397);
            this.lstSummary.Name = "lstSummary";
            this.lstSummary.Size = new System.Drawing.Size(320, 84);
            this.lstSummary.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 493);
            this.Controls.Add(this.lstSummary);
            this.Controls.Add(this.dtpJourneyDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTotalFare);
            this.Controls.Add(this.lblTotalFare);
            this.Controls.Add(this.numTickets);
            this.Controls.Add(this.lblTickets);
            this.Controls.Add(this.rdoNonAC);
            this.Controls.Add(this.rdoAC);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.cmbTrain);
            this.Controls.Add(this.lblTrain);
            this.Controls.Add(this.cmbDestination);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.cmbSource);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.txtPassengerName);
            this.Controls.Add(this.lblPassengerName);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPassengerName;
        private System.Windows.Forms.TextBox txtPassengerName;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.ComboBox cmbSource;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.ComboBox cmbDestination;
        private System.Windows.Forms.Label lblTrain;
        private System.Windows.Forms.ComboBox cmbTrain;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.RadioButton rdoAC;
        private System.Windows.Forms.RadioButton rdoNonAC;
        private System.Windows.Forms.Label lblTickets;
        private System.Windows.Forms.NumericUpDown numTickets;
        private System.Windows.Forms.Label lblTotalFare;
        private System.Windows.Forms.TextBox txtTotalFare;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpJourneyDate;
        private System.Windows.Forms.ListBox lstSummary;
    }
}

