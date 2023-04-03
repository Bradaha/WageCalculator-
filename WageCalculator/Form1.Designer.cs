namespace WageCalculator
{
    partial class FrmWages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWages));
            this.trkBarHourly = new System.Windows.Forms.TrackBar();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblCurrentHourlyRate = new System.Windows.Forms.Label();
            this.lblHourlyRate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSelectCurrency = new System.Windows.Forms.Label();
            this.grpBoxCurrency = new System.Windows.Forms.GroupBox();
            this.lblNote2 = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblEUR = new System.Windows.Forms.Label();
            this.lblUSD = new System.Windows.Forms.Label();
            this.lblGBP = new System.Windows.Forms.Label();
            this.rdoCurrencyEUR = new System.Windows.Forms.RadioButton();
            this.rdoCurrencyUSD = new System.Windows.Forms.RadioButton();
            this.rdoCurrencyGBP = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTotalEarnedDisplay = new System.Windows.Forms.Label();
            this.lblHoursWorkedDisplay = new System.Windows.Forms.Label();
            this.lblBreakPaidDisplay = new System.Windows.Forms.Label();
            this.lblBreakLengthDisplay = new System.Windows.Forms.Label();
            this.lblHourlyOverview = new System.Windows.Forms.Label();
            this.lblDateOverview = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblHourlyRateOverview = new System.Windows.Forms.Label();
            this.lblHoursWorkedHours = new System.Windows.Forms.Label();
            this.lblHoursWorkedOverview = new System.Windows.Forms.Label();
            this.lblBreakLengthOverview = new System.Windows.Forms.Label();
            this.lblBreakLengthMinutes = new System.Windows.Forms.Label();
            this.lblTotalEarned = new System.Windows.Forms.Label();
            this.lblGBP1 = new System.Windows.Forms.Label();
            this.lblEUR1 = new System.Windows.Forms.Label();
            this.lblUSD1 = new System.Windows.Forms.Label();
            this.lblUSD2 = new System.Windows.Forms.Label();
            this.lblEUR2 = new System.Windows.Forms.Label();
            this.lblGBP2 = new System.Windows.Forms.Label();
            this.grpInvis2 = new System.Windows.Forms.GroupBox();
            this.txtDateFile = new System.Windows.Forms.TextBox();
            this.btnCalculateWage = new System.Windows.Forms.Button();
            this.lblBreakFalse = new System.Windows.Forms.Label();
            this.lblBreakTrue = new System.Windows.Forms.Label();
            this._radioContainer = new System.Windows.Forms.GroupBox();
            this.chkCustomBreak = new System.Windows.Forms.CheckBox();
            this.numCustomBreak = new System.Windows.Forms.NumericUpDown();
            this.lblBreakTime = new System.Windows.Forms.Label();
            this.rdo60 = new System.Windows.Forms.RadioButton();
            this.rdo45 = new System.Windows.Forms.RadioButton();
            this.rdo30 = new System.Windows.Forms.RadioButton();
            this.rdo15 = new System.Windows.Forms.RadioButton();
            this.chkBreakPaid = new System.Windows.Forms.CheckBox();
            this.numHoursWorked = new System.Windows.Forms.NumericUpDown();
            this.lblHoursWorked = new System.Windows.Forms.Label();
            this.grpinvis1 = new System.Windows.Forms.GroupBox();
            this.btnSetDate = new System.Windows.Forms.Button();
            this.lblSetDateTip = new System.Windows.Forms.Label();
            this.lblSetDateTip1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trkBarHourly)).BeginInit();
            this.grpBoxCurrency.SuspendLayout();
            this.grpInvis2.SuspendLayout();
            this._radioContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCustomBreak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHoursWorked)).BeginInit();
            this.grpinvis1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trkBarHourly
            // 
            this.trkBarHourly.Location = new System.Drawing.Point(197, 21);
            this.trkBarHourly.Name = "trkBarHourly";
            this.trkBarHourly.Size = new System.Drawing.Size(424, 45);
            this.trkBarHourly.TabIndex = 0;
            this.trkBarHourly.Visible = false;
            this.trkBarHourly.Scroll += new System.EventHandler(this.trkBarHourly_Scroll);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(241, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(314, 25);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Wage Calculator And Logger";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.Location = new System.Drawing.Point(-3, 50);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(811, 13);
            this.lblLine.TabIndex = 3;
            this.lblLine.Text = resources.GetString("lblLine.Text");
            // 
            // lblCurrentHourlyRate
            // 
            this.lblCurrentHourlyRate.AutoSize = true;
            this.lblCurrentHourlyRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentHourlyRate.Location = new System.Drawing.Point(269, 5);
            this.lblCurrentHourlyRate.Name = "lblCurrentHourlyRate";
            this.lblCurrentHourlyRate.Size = new System.Drawing.Size(256, 18);
            this.lblCurrentHourlyRate.TabIndex = 4;
            this.lblCurrentHourlyRate.Text = "Please enter your current hourly wage";
            this.lblCurrentHourlyRate.Visible = false;
            this.lblCurrentHourlyRate.Click += new System.EventHandler(this.lblCurrentHourlyRate_Click);
            // 
            // lblHourlyRate
            // 
            this.lblHourlyRate.AutoSize = true;
            this.lblHourlyRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHourlyRate.Location = new System.Drawing.Point(388, 64);
            this.lblHourlyRate.Name = "lblHourlyRate";
            this.lblHourlyRate.Size = new System.Drawing.Size(20, 24);
            this.lblHourlyRate.TabIndex = 5;
            this.lblHourlyRate.Text = "0";
            this.lblHourlyRate.Visible = false;
            this.lblHourlyRate.Click += new System.EventHandler(this.lblHourlyRate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-3, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(811, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // lblSelectCurrency
            // 
            this.lblSelectCurrency.AutoSize = true;
            this.lblSelectCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCurrency.Location = new System.Drawing.Point(3, 5);
            this.lblSelectCurrency.Name = "lblSelectCurrency";
            this.lblSelectCurrency.Size = new System.Drawing.Size(137, 13);
            this.lblSelectCurrency.TabIndex = 10;
            this.lblSelectCurrency.Text = "Please select your currency";
            // 
            // grpBoxCurrency
            // 
            this.grpBoxCurrency.Controls.Add(this.lblNote2);
            this.grpBoxCurrency.Controls.Add(this.lblNote);
            this.grpBoxCurrency.Controls.Add(this.lblEUR);
            this.grpBoxCurrency.Controls.Add(this.lblUSD);
            this.grpBoxCurrency.Controls.Add(this.lblGBP);
            this.grpBoxCurrency.Controls.Add(this.rdoCurrencyEUR);
            this.grpBoxCurrency.Controls.Add(this.rdoCurrencyUSD);
            this.grpBoxCurrency.Controls.Add(this.rdoCurrencyGBP);
            this.grpBoxCurrency.Controls.Add(this.lblSelectCurrency);
            this.grpBoxCurrency.Controls.Add(this.trkBarHourly);
            this.grpBoxCurrency.Controls.Add(this.lblHourlyRate);
            this.grpBoxCurrency.Controls.Add(this.lblCurrentHourlyRate);
            this.grpBoxCurrency.Location = new System.Drawing.Point(0, 60);
            this.grpBoxCurrency.Name = "grpBoxCurrency";
            this.grpBoxCurrency.Size = new System.Drawing.Size(775, 88);
            this.grpBoxCurrency.TabIndex = 11;
            this.grpBoxCurrency.TabStop = false;
            // 
            // lblNote2
            // 
            this.lblNote2.AutoSize = true;
            this.lblNote2.Location = new System.Drawing.Point(619, 33);
            this.lblNote2.Name = "lblNote2";
            this.lblNote2.Size = new System.Drawing.Size(96, 13);
            this.lblNote2.TabIndex = 15;
            this.lblNote2.Text = "use the arrow keys";
            this.lblNote2.Visible = false;
            this.lblNote2.Click += new System.EventHandler(this.lblNote2_Click);
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(616, 16);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(156, 13);
            this.lblNote.TabIndex = 14;
            this.lblNote.Text = "NOTE: for a more precise input,";
            this.lblNote.Visible = false;
            this.lblNote.Click += new System.EventHandler(this.lblNote_Click);
            // 
            // lblEUR
            // 
            this.lblEUR.AutoSize = true;
            this.lblEUR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEUR.Location = new System.Drawing.Point(372, 64);
            this.lblEUR.Name = "lblEUR";
            this.lblEUR.Size = new System.Drawing.Size(20, 24);
            this.lblEUR.TabIndex = 13;
            this.lblEUR.Text = "€";
            this.lblEUR.Visible = false;
            this.lblEUR.Click += new System.EventHandler(this.lblEUR_Click);
            // 
            // lblUSD
            // 
            this.lblUSD.AutoSize = true;
            this.lblUSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUSD.Location = new System.Drawing.Point(372, 64);
            this.lblUSD.Name = "lblUSD";
            this.lblUSD.Size = new System.Drawing.Size(20, 24);
            this.lblUSD.TabIndex = 13;
            this.lblUSD.Text = "$";
            this.lblUSD.Visible = false;
            this.lblUSD.Click += new System.EventHandler(this.lblUSD_Click);
            // 
            // lblGBP
            // 
            this.lblGBP.AutoSize = true;
            this.lblGBP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGBP.Location = new System.Drawing.Point(372, 64);
            this.lblGBP.Name = "lblGBP";
            this.lblGBP.Size = new System.Drawing.Size(20, 24);
            this.lblGBP.TabIndex = 12;
            this.lblGBP.Text = "£";
            this.lblGBP.Visible = false;
            // 
            // rdoCurrencyEUR
            // 
            this.rdoCurrencyEUR.AutoSize = true;
            this.rdoCurrencyEUR.Location = new System.Drawing.Point(7, 66);
            this.rdoCurrencyEUR.Name = "rdoCurrencyEUR";
            this.rdoCurrencyEUR.Size = new System.Drawing.Size(34, 17);
            this.rdoCurrencyEUR.TabIndex = 13;
            this.rdoCurrencyEUR.TabStop = true;
            this.rdoCurrencyEUR.Text = "€ ";
            this.rdoCurrencyEUR.UseVisualStyleBackColor = true;
            this.rdoCurrencyEUR.CheckedChanged += new System.EventHandler(this.rdoCurrencyEUR_CheckedChanged);
            // 
            // rdoCurrencyUSD
            // 
            this.rdoCurrencyUSD.AutoSize = true;
            this.rdoCurrencyUSD.Location = new System.Drawing.Point(6, 44);
            this.rdoCurrencyUSD.Name = "rdoCurrencyUSD";
            this.rdoCurrencyUSD.Size = new System.Drawing.Size(31, 17);
            this.rdoCurrencyUSD.TabIndex = 12;
            this.rdoCurrencyUSD.TabStop = true;
            this.rdoCurrencyUSD.Text = "$";
            this.rdoCurrencyUSD.UseVisualStyleBackColor = true;
            this.rdoCurrencyUSD.CheckedChanged += new System.EventHandler(this.rdoCurrencyUSD_CheckedChanged);
            // 
            // rdoCurrencyGBP
            // 
            this.rdoCurrencyGBP.AutoSize = true;
            this.rdoCurrencyGBP.Location = new System.Drawing.Point(6, 21);
            this.rdoCurrencyGBP.Name = "rdoCurrencyGBP";
            this.rdoCurrencyGBP.Size = new System.Drawing.Size(31, 17);
            this.rdoCurrencyGBP.TabIndex = 11;
            this.rdoCurrencyGBP.TabStop = true;
            this.rdoCurrencyGBP.Text = "£";
            this.rdoCurrencyGBP.UseVisualStyleBackColor = true;
            this.rdoCurrencyGBP.CheckedChanged += new System.EventHandler(this.rdoCurrencyGBP_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 46);
            this.button1.TabIndex = 13;
            this.button1.Text = "Save to file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTotalEarnedDisplay
            // 
            this.lblTotalEarnedDisplay.AutoSize = true;
            this.lblTotalEarnedDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEarnedDisplay.Location = new System.Drawing.Point(591, 316);
            this.lblTotalEarnedDisplay.Name = "lblTotalEarnedDisplay";
            this.lblTotalEarnedDisplay.Size = new System.Drawing.Size(88, 16);
            this.lblTotalEarnedDisplay.TabIndex = 14;
            this.lblTotalEarnedDisplay.Text = "Total Earned:";
            // 
            // lblHoursWorkedDisplay
            // 
            this.lblHoursWorkedDisplay.AutoSize = true;
            this.lblHoursWorkedDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursWorkedDisplay.Location = new System.Drawing.Point(590, 233);
            this.lblHoursWorkedDisplay.Name = "lblHoursWorkedDisplay";
            this.lblHoursWorkedDisplay.Size = new System.Drawing.Size(97, 16);
            this.lblHoursWorkedDisplay.TabIndex = 15;
            this.lblHoursWorkedDisplay.Text = "Hours Worked:";
            // 
            // lblBreakPaidDisplay
            // 
            this.lblBreakPaidDisplay.AutoSize = true;
            this.lblBreakPaidDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreakPaidDisplay.Location = new System.Drawing.Point(590, 275);
            this.lblBreakPaidDisplay.Name = "lblBreakPaidDisplay";
            this.lblBreakPaidDisplay.Size = new System.Drawing.Size(77, 16);
            this.lblBreakPaidDisplay.TabIndex = 16;
            this.lblBreakPaidDisplay.Text = "Break Paid:";
            // 
            // lblBreakLengthDisplay
            // 
            this.lblBreakLengthDisplay.AutoSize = true;
            this.lblBreakLengthDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreakLengthDisplay.Location = new System.Drawing.Point(590, 252);
            this.lblBreakLengthDisplay.Name = "lblBreakLengthDisplay";
            this.lblBreakLengthDisplay.Size = new System.Drawing.Size(89, 16);
            this.lblBreakLengthDisplay.TabIndex = 17;
            this.lblBreakLengthDisplay.Text = "Break Length:";
            // 
            // lblHourlyOverview
            // 
            this.lblHourlyOverview.AutoSize = true;
            this.lblHourlyOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHourlyOverview.Location = new System.Drawing.Point(591, 213);
            this.lblHourlyOverview.Name = "lblHourlyOverview";
            this.lblHourlyOverview.Size = new System.Drawing.Size(81, 16);
            this.lblHourlyOverview.TabIndex = 18;
            this.lblHourlyOverview.Text = "Hourly Rate:";
            // 
            // lblDateOverview
            // 
            this.lblDateOverview.AutoSize = true;
            this.lblDateOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOverview.Location = new System.Drawing.Point(591, 192);
            this.lblDateOverview.Name = "lblDateOverview";
            this.lblDateOverview.Size = new System.Drawing.Size(39, 16);
            this.lblDateOverview.TabIndex = 19;
            this.lblDateOverview.Text = "Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(627, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 16);
            this.label9.TabIndex = 20;
            // 
            // lblHourlyRateOverview
            // 
            this.lblHourlyRateOverview.AutoSize = true;
            this.lblHourlyRateOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHourlyRateOverview.Location = new System.Drawing.Point(112, 28);
            this.lblHourlyRateOverview.Name = "lblHourlyRateOverview";
            this.lblHourlyRateOverview.Size = new System.Drawing.Size(14, 15);
            this.lblHourlyRateOverview.TabIndex = 23;
            this.lblHourlyRateOverview.Text = "0";
            // 
            // lblHoursWorkedHours
            // 
            this.lblHoursWorkedHours.AutoSize = true;
            this.lblHoursWorkedHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursWorkedHours.Location = new System.Drawing.Point(112, 43);
            this.lblHoursWorkedHours.Name = "lblHoursWorkedHours";
            this.lblHoursWorkedHours.Size = new System.Drawing.Size(40, 15);
            this.lblHoursWorkedHours.TabIndex = 24;
            this.lblHoursWorkedHours.Text = "Hours";
            // 
            // lblHoursWorkedOverview
            // 
            this.lblHoursWorkedOverview.AutoSize = true;
            this.lblHoursWorkedOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursWorkedOverview.Location = new System.Drawing.Point(94, 42);
            this.lblHoursWorkedOverview.Name = "lblHoursWorkedOverview";
            this.lblHoursWorkedOverview.Size = new System.Drawing.Size(14, 15);
            this.lblHoursWorkedOverview.TabIndex = 25;
            this.lblHoursWorkedOverview.Text = "0";
            // 
            // lblBreakLengthOverview
            // 
            this.lblBreakLengthOverview.AutoSize = true;
            this.lblBreakLengthOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreakLengthOverview.Location = new System.Drawing.Point(94, 63);
            this.lblBreakLengthOverview.Name = "lblBreakLengthOverview";
            this.lblBreakLengthOverview.Size = new System.Drawing.Size(14, 15);
            this.lblBreakLengthOverview.TabIndex = 26;
            this.lblBreakLengthOverview.Text = "0";
            this.lblBreakLengthOverview.Click += new System.EventHandler(this.lblBreakLengthOverview_Click);
            // 
            // lblBreakLengthMinutes
            // 
            this.lblBreakLengthMinutes.AutoSize = true;
            this.lblBreakLengthMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreakLengthMinutes.Location = new System.Drawing.Point(112, 63);
            this.lblBreakLengthMinutes.Name = "lblBreakLengthMinutes";
            this.lblBreakLengthMinutes.Size = new System.Drawing.Size(51, 15);
            this.lblBreakLengthMinutes.TabIndex = 27;
            this.lblBreakLengthMinutes.Text = "Minutes";
            // 
            // lblTotalEarned
            // 
            this.lblTotalEarned.AutoSize = true;
            this.lblTotalEarned.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEarned.Location = new System.Drawing.Point(707, 316);
            this.lblTotalEarned.Name = "lblTotalEarned";
            this.lblTotalEarned.Size = new System.Drawing.Size(14, 15);
            this.lblTotalEarned.TabIndex = 30;
            this.lblTotalEarned.Text = "0";
            // 
            // lblGBP1
            // 
            this.lblGBP1.AutoSize = true;
            this.lblGBP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGBP1.Location = new System.Drawing.Point(94, 27);
            this.lblGBP1.Name = "lblGBP1";
            this.lblGBP1.Size = new System.Drawing.Size(14, 15);
            this.lblGBP1.TabIndex = 31;
            this.lblGBP1.Text = "£";
            // 
            // lblEUR1
            // 
            this.lblEUR1.AutoSize = true;
            this.lblEUR1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEUR1.Location = new System.Drawing.Point(94, 27);
            this.lblEUR1.Name = "lblEUR1";
            this.lblEUR1.Size = new System.Drawing.Size(14, 15);
            this.lblEUR1.TabIndex = 32;
            this.lblEUR1.Text = "€";
            // 
            // lblUSD1
            // 
            this.lblUSD1.AutoSize = true;
            this.lblUSD1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUSD1.Location = new System.Drawing.Point(94, 27);
            this.lblUSD1.Name = "lblUSD1";
            this.lblUSD1.Size = new System.Drawing.Size(14, 15);
            this.lblUSD1.TabIndex = 33;
            this.lblUSD1.Text = "$";
            this.lblUSD1.Click += new System.EventHandler(this.label21_Click);
            // 
            // lblUSD2
            // 
            this.lblUSD2.AutoSize = true;
            this.lblUSD2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUSD2.Location = new System.Drawing.Point(696, 316);
            this.lblUSD2.Name = "lblUSD2";
            this.lblUSD2.Size = new System.Drawing.Size(14, 15);
            this.lblUSD2.TabIndex = 36;
            this.lblUSD2.Text = "$";
            // 
            // lblEUR2
            // 
            this.lblEUR2.AutoSize = true;
            this.lblEUR2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEUR2.Location = new System.Drawing.Point(696, 317);
            this.lblEUR2.Name = "lblEUR2";
            this.lblEUR2.Size = new System.Drawing.Size(14, 15);
            this.lblEUR2.TabIndex = 35;
            this.lblEUR2.Text = "€";
            // 
            // lblGBP2
            // 
            this.lblGBP2.AutoSize = true;
            this.lblGBP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGBP2.Location = new System.Drawing.Point(696, 316);
            this.lblGBP2.Name = "lblGBP2";
            this.lblGBP2.Size = new System.Drawing.Size(14, 15);
            this.lblGBP2.TabIndex = 34;
            this.lblGBP2.Text = "£";
            // 
            // grpInvis2
            // 
            this.grpInvis2.Controls.Add(this.txtDateFile);
            this.grpInvis2.Controls.Add(this.btnCalculateWage);
            this.grpInvis2.Controls.Add(this.lblBreakFalse);
            this.grpInvis2.Controls.Add(this.lblBreakTrue);
            this.grpInvis2.Controls.Add(this.lblHoursWorkedHours);
            this.grpInvis2.Controls.Add(this.lblBreakLengthMinutes);
            this.grpInvis2.Controls.Add(this.lblUSD1);
            this.grpInvis2.Controls.Add(this.lblHourlyRateOverview);
            this.grpInvis2.Controls.Add(this.lblEUR1);
            this.grpInvis2.Controls.Add(this.lblGBP1);
            this.grpInvis2.Controls.Add(this.lblHoursWorkedOverview);
            this.grpInvis2.Controls.Add(this.lblBreakLengthOverview);
            this.grpInvis2.Controls.Add(this.button1);
            this.grpInvis2.Location = new System.Drawing.Point(592, 192);
            this.grpInvis2.Name = "grpInvis2";
            this.grpInvis2.Size = new System.Drawing.Size(190, 212);
            this.grpInvis2.TabIndex = 38;
            this.grpInvis2.TabStop = false;
            // 
            // txtDateFile
            // 
            this.txtDateFile.Location = new System.Drawing.Point(80, 5);
            this.txtDateFile.Name = "txtDateFile";
            this.txtDateFile.Size = new System.Drawing.Size(100, 20);
            this.txtDateFile.TabIndex = 37;
            // 
            // btnCalculateWage
            // 
            this.btnCalculateWage.Location = new System.Drawing.Point(1, 143);
            this.btnCalculateWage.Name = "btnCalculateWage";
            this.btnCalculateWage.Size = new System.Drawing.Size(86, 23);
            this.btnCalculateWage.TabIndex = 36;
            this.btnCalculateWage.Text = "Calculate";
            this.btnCalculateWage.UseVisualStyleBackColor = true;
            this.btnCalculateWage.Click += new System.EventHandler(this.btnCalculateWage_Click);
            // 
            // lblBreakFalse
            // 
            this.lblBreakFalse.AutoSize = true;
            this.lblBreakFalse.Location = new System.Drawing.Point(94, 86);
            this.lblBreakFalse.Name = "lblBreakFalse";
            this.lblBreakFalse.Size = new System.Drawing.Size(32, 13);
            this.lblBreakFalse.TabIndex = 35;
            this.lblBreakFalse.Text = "False";
            // 
            // lblBreakTrue
            // 
            this.lblBreakTrue.AutoSize = true;
            this.lblBreakTrue.Location = new System.Drawing.Point(94, 86);
            this.lblBreakTrue.Name = "lblBreakTrue";
            this.lblBreakTrue.Size = new System.Drawing.Size(29, 13);
            this.lblBreakTrue.TabIndex = 34;
            this.lblBreakTrue.Text = "True";
            // 
            // _radioContainer
            // 
            this._radioContainer.Controls.Add(this.chkCustomBreak);
            this._radioContainer.Controls.Add(this.numCustomBreak);
            this._radioContainer.Controls.Add(this.lblBreakTime);
            this._radioContainer.Controls.Add(this.rdo60);
            this._radioContainer.Controls.Add(this.rdo45);
            this._radioContainer.Controls.Add(this.rdo30);
            this._radioContainer.Controls.Add(this.rdo15);
            this._radioContainer.Controls.Add(this.chkBreakPaid);
            this._radioContainer.Location = new System.Drawing.Point(0, 47);
            this._radioContainer.Name = "_radioContainer";
            this._radioContainer.Size = new System.Drawing.Size(211, 218);
            this._radioContainer.TabIndex = 9;
            this._radioContainer.TabStop = false;
            this._radioContainer.Enter += new System.EventHandler(this._radioContainer_Enter);
            // 
            // chkCustomBreak
            // 
            this.chkCustomBreak.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkCustomBreak.AutoSize = true;
            this.chkCustomBreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCustomBreak.Location = new System.Drawing.Point(6, 157);
            this.chkCustomBreak.Name = "chkCustomBreak";
            this.chkCustomBreak.Size = new System.Drawing.Size(59, 25);
            this.chkCustomBreak.TabIndex = 8;
            this.chkCustomBreak.Text = "Custom";
            this.chkCustomBreak.UseVisualStyleBackColor = true;
            this.chkCustomBreak.CheckedChanged += new System.EventHandler(this.chkCustomBreak_CheckedChanged);
            // 
            // numCustomBreak
            // 
            this.numCustomBreak.Location = new System.Drawing.Point(9, 186);
            this.numCustomBreak.Name = "numCustomBreak";
            this.numCustomBreak.Size = new System.Drawing.Size(120, 20);
            this.numCustomBreak.TabIndex = 7;
            this.numCustomBreak.Visible = false;
            this.numCustomBreak.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lblBreakTime
            // 
            this.lblBreakTime.AutoSize = true;
            this.lblBreakTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreakTime.Location = new System.Drawing.Point(6, 49);
            this.lblBreakTime.Name = "lblBreakTime";
            this.lblBreakTime.Size = new System.Drawing.Size(188, 13);
            this.lblBreakTime.TabIndex = 5;
            this.lblBreakTime.Text = "Please select the length of your break ";
            this.lblBreakTime.Click += new System.EventHandler(this.lblBreakTime_Click);
            // 
            // rdo60
            // 
            this.rdo60.AutoSize = true;
            this.rdo60.Location = new System.Drawing.Point(9, 134);
            this.rdo60.Name = "rdo60";
            this.rdo60.Size = new System.Drawing.Size(77, 17);
            this.rdo60.TabIndex = 4;
            this.rdo60.TabStop = true;
            this.rdo60.Text = "60 Minutes";
            this.rdo60.UseVisualStyleBackColor = true;
            this.rdo60.CheckedChanged += new System.EventHandler(this.rdo60_CheckedChanged);
            // 
            // rdo45
            // 
            this.rdo45.AutoSize = true;
            this.rdo45.Location = new System.Drawing.Point(9, 111);
            this.rdo45.Name = "rdo45";
            this.rdo45.Size = new System.Drawing.Size(77, 17);
            this.rdo45.TabIndex = 3;
            this.rdo45.TabStop = true;
            this.rdo45.Text = "45 Minutes";
            this.rdo45.UseVisualStyleBackColor = true;
            this.rdo45.CheckedChanged += new System.EventHandler(this.rdo45_CheckedChanged);
            // 
            // rdo30
            // 
            this.rdo30.AutoSize = true;
            this.rdo30.Location = new System.Drawing.Point(9, 88);
            this.rdo30.Name = "rdo30";
            this.rdo30.Size = new System.Drawing.Size(77, 17);
            this.rdo30.TabIndex = 2;
            this.rdo30.TabStop = true;
            this.rdo30.Text = "30 Minutes";
            this.rdo30.UseVisualStyleBackColor = true;
            this.rdo30.CheckedChanged += new System.EventHandler(this.rdo30_CheckedChanged);
            // 
            // rdo15
            // 
            this.rdo15.AutoSize = true;
            this.rdo15.Location = new System.Drawing.Point(9, 65);
            this.rdo15.Name = "rdo15";
            this.rdo15.Size = new System.Drawing.Size(77, 17);
            this.rdo15.TabIndex = 1;
            this.rdo15.TabStop = true;
            this.rdo15.Text = "15 Minutes";
            this.rdo15.UseVisualStyleBackColor = true;
            this.rdo15.CheckedChanged += new System.EventHandler(this.rdo15_CheckedChanged);
            // 
            // chkBreakPaid
            // 
            this.chkBreakPaid.AutoSize = true;
            this.chkBreakPaid.Location = new System.Drawing.Point(3, 14);
            this.chkBreakPaid.Name = "chkBreakPaid";
            this.chkBreakPaid.Size = new System.Drawing.Size(116, 17);
            this.chkBreakPaid.TabIndex = 0;
            this.chkBreakPaid.Text = "Is your break paid?";
            this.chkBreakPaid.UseVisualStyleBackColor = true;
            this.chkBreakPaid.CheckedChanged += new System.EventHandler(this.chkBreakPaid_CheckedChanged);
            // 
            // numHoursWorked
            // 
            this.numHoursWorked.Location = new System.Drawing.Point(3, 29);
            this.numHoursWorked.Name = "numHoursWorked";
            this.numHoursWorked.Size = new System.Drawing.Size(128, 20);
            this.numHoursWorked.TabIndex = 6;
            this.numHoursWorked.ValueChanged += new System.EventHandler(this.numHoursWorked_ValueChanged);
            // 
            // lblHoursWorked
            // 
            this.lblHoursWorked.AutoSize = true;
            this.lblHoursWorked.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursWorked.Location = new System.Drawing.Point(0, 13);
            this.lblHoursWorked.Name = "lblHoursWorked";
            this.lblHoursWorked.Size = new System.Drawing.Size(214, 13);
            this.lblHoursWorked.TabIndex = 7;
            this.lblHoursWorked.Text = "Enter the number of hours you have worked";
            // 
            // grpinvis1
            // 
            this.grpinvis1.Controls.Add(this.lblHoursWorked);
            this.grpinvis1.Controls.Add(this.numHoursWorked);
            this.grpinvis1.Controls.Add(this._radioContainer);
            this.grpinvis1.Location = new System.Drawing.Point(6, 164);
            this.grpinvis1.Name = "grpinvis1";
            this.grpinvis1.Size = new System.Drawing.Size(219, 265);
            this.grpinvis1.TabIndex = 37;
            this.grpinvis1.TabStop = false;
            this.grpinvis1.Visible = false;
            this.grpinvis1.Enter += new System.EventHandler(this.grpinvis1_Enter);
            // 
            // btnSetDate
            // 
            this.btnSetDate.Location = new System.Drawing.Point(592, 160);
            this.btnSetDate.Name = "btnSetDate";
            this.btnSetDate.Size = new System.Drawing.Size(87, 34);
            this.btnSetDate.TabIndex = 39;
            this.btnSetDate.Text = "Set Date";
            this.btnSetDate.UseVisualStyleBackColor = true;
            this.btnSetDate.Click += new System.EventHandler(this.btnSetDate_Click);
            // 
            // lblSetDateTip
            // 
            this.lblSetDateTip.AutoSize = true;
            this.lblSetDateTip.Location = new System.Drawing.Point(678, 164);
            this.lblSetDateTip.Name = "lblSetDateTip";
            this.lblSetDateTip.Size = new System.Drawing.Size(125, 13);
            this.lblSetDateTip.TabIndex = 40;
            this.lblSetDateTip.Text = "<-- Use this button to set ";
            // 
            // lblSetDateTip1
            // 
            this.lblSetDateTip1.AutoSize = true;
            this.lblSetDateTip1.Location = new System.Drawing.Point(681, 181);
            this.lblSetDateTip1.Name = "lblSetDateTip1";
            this.lblSetDateTip1.Size = new System.Drawing.Size(87, 13);
            this.lblSetDateTip1.TabIndex = 41;
            this.lblSetDateTip1.Text = "the date to today";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 42;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmWages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblSetDateTip1);
            this.Controls.Add(this.lblSetDateTip);
            this.Controls.Add(this.btnSetDate);
            this.Controls.Add(this.lblUSD2);
            this.Controls.Add(this.lblEUR2);
            this.Controls.Add(this.lblGBP2);
            this.Controls.Add(this.lblTotalEarned);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblDateOverview);
            this.Controls.Add(this.lblHourlyOverview);
            this.Controls.Add(this.lblBreakLengthDisplay);
            this.Controls.Add(this.lblBreakPaidDisplay);
            this.Controls.Add(this.lblHoursWorkedDisplay);
            this.Controls.Add(this.lblTotalEarnedDisplay);
            this.Controls.Add(this.grpBoxCurrency);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpinvis1);
            this.Controls.Add(this.grpInvis2);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FrmWages";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmWages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trkBarHourly)).EndInit();
            this.grpBoxCurrency.ResumeLayout(false);
            this.grpBoxCurrency.PerformLayout();
            this.grpInvis2.ResumeLayout(false);
            this.grpInvis2.PerformLayout();
            this._radioContainer.ResumeLayout(false);
            this._radioContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCustomBreak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHoursWorked)).EndInit();
            this.grpinvis1.ResumeLayout(false);
            this.grpinvis1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trkBarHourly;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblCurrentHourlyRate;
        private System.Windows.Forms.Label lblHourlyRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSelectCurrency;
        private System.Windows.Forms.GroupBox grpBoxCurrency;
        private System.Windows.Forms.RadioButton rdoCurrencyEUR;
        private System.Windows.Forms.RadioButton rdoCurrencyUSD;
        private System.Windows.Forms.RadioButton rdoCurrencyGBP;
        private System.Windows.Forms.Label lblGBP;
        private System.Windows.Forms.Label lblEUR;
        private System.Windows.Forms.Label lblUSD;
        private System.Windows.Forms.Label lblNote2;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTotalEarnedDisplay;
        private System.Windows.Forms.Label lblHoursWorkedDisplay;
        private System.Windows.Forms.Label lblBreakPaidDisplay;
        private System.Windows.Forms.Label lblBreakLengthDisplay;
        private System.Windows.Forms.Label lblHourlyOverview;
        private System.Windows.Forms.Label lblDateOverview;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblHourlyRateOverview;
        private System.Windows.Forms.Label lblHoursWorkedHours;
        private System.Windows.Forms.Label lblHoursWorkedOverview;
        private System.Windows.Forms.Label lblBreakLengthOverview;
        private System.Windows.Forms.Label lblBreakLengthMinutes;
        private System.Windows.Forms.Label lblTotalEarned;
        private System.Windows.Forms.Label lblGBP1;
        private System.Windows.Forms.Label lblEUR1;
        private System.Windows.Forms.Label lblUSD1;
        private System.Windows.Forms.Label lblUSD2;
        private System.Windows.Forms.Label lblEUR2;
        private System.Windows.Forms.Label lblGBP2;
        private System.Windows.Forms.GroupBox grpInvis2;
        private System.Windows.Forms.GroupBox _radioContainer;
        private System.Windows.Forms.Label lblBreakTime;
        private System.Windows.Forms.RadioButton rdo60;
        private System.Windows.Forms.RadioButton rdo45;
        private System.Windows.Forms.RadioButton rdo30;
        private System.Windows.Forms.RadioButton rdo15;
        private System.Windows.Forms.CheckBox chkBreakPaid;
        private System.Windows.Forms.NumericUpDown numHoursWorked;
        private System.Windows.Forms.Label lblHoursWorked;
        private System.Windows.Forms.GroupBox grpinvis1;
        private System.Windows.Forms.Button btnSetDate;
        private System.Windows.Forms.Label lblSetDateTip;
        private System.Windows.Forms.Label lblSetDateTip1;
        private System.Windows.Forms.Label lblBreakFalse;
        private System.Windows.Forms.Label lblBreakTrue;
        private System.Windows.Forms.NumericUpDown numCustomBreak;
        private System.Windows.Forms.Button btnCalculateWage;
        private System.Windows.Forms.CheckBox chkCustomBreak;
        private System.Windows.Forms.TextBox txtDateFile;
        private System.Windows.Forms.Button btnExit;
    }
}

