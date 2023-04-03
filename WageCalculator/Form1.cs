using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WageCalculator
{
    public partial class FrmWages : Form
    {
        public FrmWages()
        {
            InitializeComponent();
        }

        #region Methods


        private void CustomBreakReset()
        {

            foreach (RadioButton radio in _radioContainer.Controls.OfType<RadioButton>().ToList())
            {
                if (radio.Checked == true)
                {
                    radio.Checked = false;
                    break;
                }
            }
        }

        private void BreakPaidFalse()
        {
            if (chkBreakPaid.Checked == true)
            {
                rdo15.Visible = false;
                rdo30.Visible = false;
                rdo45.Visible = false;
                rdo60.Visible = false;
                lblBreakTime.Visible = false;
                chkCustomBreak.Visible = false;
                lblBreakFalse.Visible = false;
                lblBreakTrue.Visible = true;
                numCustomBreak.Visible = false;
                foreach (RadioButton radio in _radioContainer.Controls.OfType<RadioButton>().ToList())
                {
                    if (radio.Checked == true)
                    {
                        radio.Checked = false;
                        break;
                    }
                }
            }
        }
        private void VisibleContentCurrency()
        {
            if (rdoCurrencyGBP.Checked == true)
            {
                lblCurrentHourlyRate.Visible = true;
                trkBarHourly.Visible = true;
                lblHourlyRate.Visible = true;
                lblNote.Visible = true;
                lblNote2.Visible = true;
                lblGBP1.Visible = true;
                lblGBP2.Visible = true;
                lblUSD1.Visible = false;
                lblUSD2.Visible = false;
                lblEUR1.Visible = false;
                lblEUR2.Visible = false;

                grpinvis1.Visible = true;
                grpInvis2.Visible = true;

            }


            if (rdoCurrencyUSD.Checked == true)
            {
                lblCurrentHourlyRate.Visible = true;
                trkBarHourly.Visible = true;
                lblHourlyRate.Visible = true;
                lblNote.Visible = true;
                lblNote2.Visible = true;
                lblUSD1.Visible = true;
                lblUSD2.Visible = true;
                lblGBP1.Visible = false;
                lblGBP2.Visible = false;
                lblEUR1.Visible = false;
                lblEUR2.Visible = false;

                grpinvis1.Visible = true;
                grpInvis2.Visible = true;
            }

            if (rdoCurrencyEUR.Checked == true)
            {
                lblCurrentHourlyRate.Visible = true;
                trkBarHourly.Visible = true;
                lblHourlyRate.Visible = true;
                lblNote.Visible = true;
                lblNote2.Visible = true;
                lblEUR1.Visible = true;
                lblEUR2.Visible = true;
                lblUSD1.Visible = false;
                lblUSD2.Visible = false;
                lblGBP1.Visible = false;
                lblGBP2.Visible = false;

                grpinvis1.Visible = true;
                grpInvis2.Visible = true;
            }



        }
        private void BreakPaidTrue()
        {
            if (chkBreakPaid.Checked == false) 
            {
                rdo15.Visible = true;
                rdo30.Visible = true;
                rdo45.Visible = true;
                rdo60.Visible = true;
                lblBreakTime.Visible = true;
                lblBreakTrue.Visible = false;
                lblBreakFalse.Visible = true;
                chkCustomBreak.Visible = true;
                numCustomBreak.Value = 0;
            }
        }

        private void BreakDisplayOverview()
        {
            if (rdo15.Checked == true)
            {
                lblBreakLengthOverview.Text = "15";
            }
            else if (rdo30.Checked == true)
            {
                lblBreakLengthOverview.Text = "30";
            }
            else if (rdo45.Checked == true)
            {
                lblBreakLengthOverview.Text = "45";
            }
            else if (rdo60.Checked == true)
            {
                lblBreakLengthOverview.Text = "60";
            }
        }

        private void WageCalculation()
        {
            while (true)
            {
                if (chkBreakPaid.Checked == false)
                {
                    var hoursWorkedMinutes = numHoursWorked.Value * 60;
                    var hourlyWage = trkBarHourly.Value;



                    if (numCustomBreak.Visible == true && numCustomBreak.Value > 0)
                    {
                        var customBreak = numCustomBreak.Value;
                        var actualWorkDoneMinutes = hoursWorkedMinutes - customBreak;

                        var actualWorkDoneHours = actualWorkDoneMinutes / 60;

                        var customBreakPayTrueCustom = actualWorkDoneHours * hourlyWage / 100;

                        lblTotalEarned.Text = customBreakPayTrueCustom.ToString();
                        return;
                    }

                    if (rdo15.Checked == true)
                    {
                        var break15 = 15;
                        var actualWorkDoneMinutes = hoursWorkedMinutes - break15;

                        var actualWorkDoneHours = actualWorkDoneMinutes / 60;

                        var break15Pay = actualWorkDoneHours * hourlyWage / 100;

                        lblTotalEarned.Text = break15Pay.ToString();
                        return;
                    }

                    if (rdo30.Checked == true)
                    {
                        var break30 = 30;
                        var actualWorkDoneMinutes = hoursWorkedMinutes - break30;

                        var actualWorkDoneHours = actualWorkDoneMinutes / 60;

                        var break30Pay = actualWorkDoneHours * hourlyWage / 100;

                        lblTotalEarned.Text = break30Pay.ToString();
                        return;
                    }

                    if (rdo45.Checked == true)
                    {
                        var break45 = 45;
                        var actualWorkDoneMinutes = hoursWorkedMinutes - break45;

                        var actualWorkDoneHours = actualWorkDoneMinutes / 60;

                        var break45Pay = actualWorkDoneHours * hourlyWage / 100;

                        lblTotalEarned.Text = break45Pay.ToString();
                        return;
                    }

                    if (rdo60.Checked == true)
                    {
                        var break60 = 60;
                        var actualWorkDoneMinutes = hoursWorkedMinutes - break60;

                        var actualWorkDoneHours = actualWorkDoneMinutes / 60;

                        var break60Pay = actualWorkDoneHours * hourlyWage / 100;

                        lblTotalEarned.Text = break60Pay.ToString();
                        return;
                    }

                }
                var hoursWorkedMinutesBreakPaid = numHoursWorked.Value * 60;
                var hourlyWageBreakPaid = trkBarHourly.Value;

                if (chkBreakPaid.Checked == true)
                {
                    var payHoursWorked = hoursWorkedMinutesBreakPaid / 60;

                    var payPaidBreak = payHoursWorked * hourlyWageBreakPaid / 100;

                    lblTotalEarned.Text = payPaidBreak.ToString();
                    return;

                }
            }

        }
        #endregion
        #region SetCurrency
        private void SetCurrencyGBP()
        {
            lblGBP.Visible = false;
            if (rdoCurrencyGBP.Checked == true)
            {
                lblGBP.Visible = true;
            }
            else if (rdoCurrencyGBP.Checked == false)
            {
                lblGBP.Visible = false;
            }
        }

        private void SetCurrencyEUR()
        {
            lblEUR.Visible = false;
            if (rdoCurrencyEUR.Checked == true)
            {
                lblEUR.Visible = true;
            }
            else if (rdoCurrencyEUR.Checked == false)
            {
                lblEUR.Visible = false;
            }
        }

        private void SetCurrencyUSD()
        {
            lblUSD.Visible = false;
            if (rdoCurrencyUSD.Checked == true)
            {
                lblUSD.Visible = true;
            }
            else if (rdoCurrencyUSD.Checked == false)
            {
                lblUSD.Visible = false;
            }
        }
#endregion
        #region ToolEdits

        private void _radioContainer_Enter(object sender, EventArgs e)
        {
            BreakPaidFalse();
            BreakPaidTrue();
        }

        private void chkBreakPaid_CheckedChanged(object sender, EventArgs e)
        {
            BreakPaidFalse();
            BreakPaidTrue();
        }

        private void rdo15_CheckedChanged(object sender, EventArgs e)
        {
            BreakPaidFalse();
            BreakPaidTrue();
            BreakDisplayOverview();
        }

        private void lblBreakTime_Click(object sender, EventArgs e)
        {
            BreakPaidFalse();
            BreakPaidTrue();
        }

        private void rdo30_CheckedChanged(object sender, EventArgs e)
        {
            BreakPaidFalse(); 
            BreakPaidTrue();
            BreakDisplayOverview();
        }

        private void rdo45_CheckedChanged(object sender, EventArgs e)
        {
            BreakPaidFalse();
            BreakPaidTrue();
            BreakDisplayOverview();
        }

        private void rdo60_CheckedChanged(object sender, EventArgs e)
        {
            BreakPaidFalse();
            BreakPaidTrue();
            BreakDisplayOverview();
        }

        private void trkBarHourly_Scroll(object sender, EventArgs e)
        {
            lblHourlyRate.Text = trkBarHourly.Value.ToString();

            trkBarHourly.Maximum = 5000;

            float result= float.Parse(lblHourlyRate.Text) / 100;
            lblHourlyRate.Text = result.ToString();

            lblHourlyRateOverview.Text = trkBarHourly.Value.ToString();

            trkBarHourly.Maximum = 5000;

            float resultOverview = float.Parse(lblHourlyRateOverview.Text) / 100;
            lblHourlyRateOverview.Text = result.ToString();

        }

        private void lblGBP_Click(object sender, EventArgs e)
        {
            SetCurrencyGBP();
        }

        private void lblUSD_Click(object sender, EventArgs e)
        {
            SetCurrencyUSD();
            VisibleContentCurrency();
        }

        private void lblEUR_Click(object sender, EventArgs e)
        {
            SetCurrencyEUR();
            VisibleContentCurrency();

        }

        private void rdoCurrencyGBP_CheckedChanged(object sender, EventArgs e)
        {
            SetCurrencyGBP();
            VisibleContentCurrency();

        }

        private void rdoCurrencyUSD_CheckedChanged(object sender, EventArgs e)
        {
            SetCurrencyUSD();
            VisibleContentCurrency();

        }

        private void rdoCurrencyEUR_CheckedChanged(object sender, EventArgs e)
        {
            SetCurrencyEUR();
            VisibleContentCurrency();

        }

        private void lblCurrentHourlyRate_Click(object sender, EventArgs e)
        {
            lblCurrentHourlyRate.Visible = false;
        }

        private void lblHourlyRate_Click(object sender, EventArgs e)
        {
            lblHourlyRate.Visible = false;
        }

        private void lblNote_Click(object sender, EventArgs e)
        {
            lblNote.Visible = false;
        }

        private void lblNote2_Click(object sender, EventArgs e)
        {
            lblNote2.Visible = false;
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void grpinvis1_Enter(object sender, EventArgs e)
        {
            VisibleContentCurrency();
        }


        private void FrmWages_Load(object sender, EventArgs e)
        {

        }

        private void numHoursWorked_ValueChanged(object sender, EventArgs e)
        {
            numHoursWorked.Maximum = 99;
            numHoursWorked.Minimum = 0;

            var hoursWorkedOverview = numHoursWorked.Value.ToString();

            lblHoursWorkedOverview.Text = hoursWorkedOverview;
        }


        #endregion

        private void lblBreakLengthOverview_Click(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numHoursWorked.Maximum = 99;
            numHoursWorked.Minimum = 0;

            var customBreakOverview = numCustomBreak.Value.ToString();

            lblBreakLengthOverview.Text = customBreakOverview;
        }

        private void btnCalculateWage_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            WageCalculation();
        }

        private void chkCustomBreak_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCustomBreak.Checked == true)
            {
                numCustomBreak.Value = 0;
                numCustomBreak.Visible = true;
            }
            else
            {
                numCustomBreak.Value = 0;
                numCustomBreak.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (!File.Exists(txtDateFile.Text)) // If file does not exists
            {
                File.Create(txtDateFile.Text).Close(); // Create file
                using (StreamWriter sw = File.AppendText(txtDateFile.Text))
                {
                    sw.WriteLine(lblDateOverview.Text + " " + txtDateFile.Text); // Write text to .txt file
                    if (lblUSD1.Visible == true)
                    {
                        sw.WriteLine(lblHourlyOverview.Text + " " + lblUSD1.Text + lblHourlyRateOverview.Text); // Write text to .txt file

                    }

                    if (lblGBP1.Visible == true)
                    {
                        sw.WriteLine(lblHourlyOverview.Text + " " + lblGBP1.Text + lblHourlyRateOverview.Text); // Write text to .txt file

                    }

                    if (lblEUR1.Visible == true)
                    {
                        sw.WriteLine(lblHourlyOverview.Text + " " + lblEUR1.Text + lblHourlyRateOverview.Text); // Write text to .txt file

                    }
                    sw.WriteLine(lblHoursWorkedDisplay.Text + " " + lblHoursWorkedOverview.Text + " " + lblHoursWorkedHours.Text); // Write text to .txt file

                    sw.WriteLine(lblBreakLengthDisplay.Text + " " + lblBreakLengthOverview.Text + " " + lblBreakLengthMinutes.Text); // Write text to .txt file

                    if (lblBreakFalse.Visible == true)
                    {
                        sw.WriteLine(lblBreakPaidDisplay.Text + " " + lblBreakFalse.Text); // Write text to .txt file

                    }

                    if (lblBreakTrue.Visible == true)
                    {
                        sw.WriteLine(lblBreakPaidDisplay.Text + " " + lblBreakTrue.Text); // Write text to .txt file

                    }

                    if (lblUSD2.Visible == true)
                    {
                        sw.WriteLine(lblTotalEarnedDisplay.Text + " " + lblUSD2.Text + lblTotalEarned.Text); // Write text to .txt file

                    }

                    if (lblEUR2.Visible == true)
                    {
                        sw.WriteLine(lblTotalEarnedDisplay.Text + " " + lblEUR2.Text + lblTotalEarned.Text); // Write text to .txt file

                    }

                    if (lblGBP2.Visible == true)
                    {
                        sw.WriteLine(lblTotalEarnedDisplay.Text + " " + lblGBP2.Text + lblTotalEarned.Text); // Write text to .txt file

                    }
                }
            }
            else // If file already exists
            {
                // File.WriteAllText("FILENAME.txt", String.Empty); // Clear file
                using (StreamWriter sw = File.AppendText("FILENAME.txt"))
                {
                    sw.WriteLine("WRITE SOME TEXT"); // Write text to .txt file
                }
            }
        }

        private void btnSetDate_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            txtDateFile.Text = (DateTime.Now.ToString("dd.MM.yyyy.TXT"));

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Button btn = (Button) sender;
            this.Close();
        }
    }
}
