using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace Splits_Computation
{
    public partial class Splits_Comp : Form
    {
        public Splits_Comp()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!HandleFilePath())
            {
                return;
            }
            if (!HandleTargetTime(out string targetTime))
            {
                return;
            }
            if (!HandleTargetTimePBChance(out string PBChancetargetTime))
            {
                return;
            }

            lblWorking.Visible = true;
            Application.DoEvents();

            string args = " \"" + txtFileBrowse.Text + "\" " + targetTime + " -w " + numUDWeight.Value + " --sim " + numUDPBChanceSplit.Value + " " + PBChancetargetTime;
            if (chkLinearDecay.Checked)
            {
                args += " --linear";
            }

            if (chkChunkify.Checked)
            {
                args += " --chunk " + numUDChunkify.Value;
            }

            string output = PythonUtility.ExecuteBatch(args);
            // hack. i modified the script to print the "Script ran successfully" string to stout if it had succeeded in its task. i check for this.
            if (output.Contains("Script ran successfully"))
            {
                output = output.Replace("Script ran successfully", "");
                MessageBox.Show("The calculated Sim chance is " + output);
            }
            else
            {
                MessageBox.Show("There was a problem in making the simulations. Python stout:\n" + output);
            }

            lblWorking.Visible = false;
            Application.DoEvents();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!HandleFilePath())
            {
                return;
            }
            if (!HandleTargetTime(out string targetTime))
            {
                return;
            }

            lblWorking.Visible = true;
            Application.DoEvents();

            string args = " \"" + txtFileBrowse.Text + "\" " + targetTime + " -w " + numUDWeight.Value;
            if (chkLinearDecay.Checked)
            {
                args += " --linear";
            }

            if (chkChunkify.Checked)
            {
                args += " --chunk " + numUDChunkify.Value;
            }

            string output = PythonUtility.ExecuteBatch(args);

            MsgBoxOutcome(output);

            lblWorking.Visible = false;
            Application.DoEvents();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!HandleFilePath())
            {
                return;
            }
            if(!HandleTargetTime(out string targetTime))
            {
                return;
            }

            lblWorking.Visible = true;
            Application.DoEvents();

            string args = " \"" + txtFileBrowse.Text + "\" " + targetTime + " -w " + numUDWeight.Value + " --reset " + numUDResetIterations.Value;
            if (chkLinearDecay.Checked)
            {
                args += " --linear";
            }

            if (chkChunkify.Checked)
            {
                args += " --chunk " + numUDChunkify.Value;
            }

            string output = PythonUtility.ExecuteBatch(args);

            MsgBoxOutcome(output);

            lblWorking.Visible = false;
            Application.DoEvents();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chkChunkify_CheckedChanged(object sender, EventArgs e)
        {
            numUDChunkify.Enabled = chkChunkify.Checked;
        }

        private void numUDChunkify_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblWeight_Click(object sender, EventArgs e)
        {

        }

        private void btnFileBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                try
                {
                    txtFileBrowse.Text = filePath;

                }
                catch (IOException)
                {
                }
            }
        }

        private void chkLinearDecay_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkUsePB_CheckedChanged(object sender, EventArgs e)
        {
            txtTargetTime.Enabled = !chkUsePB.Checked;
        }

        private void lblResetIterations_Click(object sender, EventArgs e)
        {

        }

        private bool HandleFilePath()
        {
            if (!FormValidity.CheckFilePath(txtFileBrowse.Text))
            {
                MessageBox.Show("Please select a splits file");
                return false;
            }
            return true;
        }
        
        private bool HandleTargetTime(out string targetTime) 
        {
            if (!chkUsePB.Checked)
            {
                if (!FormValidity.CheckTargetTime(txtTargetTime.Text))
                {
                    MessageBox.Show("Please input the target time in hh:mm:ss format (for example: 01:30:00)");
                    targetTime = "";
                    return false;
                }
                targetTime = txtTargetTime.Text;
                return true;
            }
            else
            {
                targetTime = XmlUtility.SearchForPB(txtFileBrowse.Text);
                if (targetTime == null)
                {
                    MessageBox.Show("There was a problem in the parsing of the target time.");
                    targetTime = "";
                    return false;
                }
                return true;
            }
        }

        private bool HandleTargetTimePBChance(out string PBChancetargetTime)
        {
            if (!FormValidity.CheckTargetTime(txtPBChanceTime.Text))
            {
                MessageBox.Show("Please input the Sim Chance time in hh:mm:ss format (for example: 01:30:00)");
                PBChancetargetTime = "";
                return false;
            }
            PBChancetargetTime = txtPBChanceTime.Text;
            return true;
        }

        private void MsgBoxOutcome(string output)
        {
            // hack. i modified the script to print the "Script ran successfully" string to stout if it had succeeded in its task. i check for this.
            if (output.Contains("Script ran successfully"))
            {
                MessageBox.Show("The splits file has been updated with the new comparison.");
            }
            else
            {
                MessageBox.Show("There was a problem in the generation of the splits. Python stout:\n" + output);
            }
        }

        private void lblPBChanceStartSplit_Click(object sender, EventArgs e)
        {

        }

        private void numUDPBChanceSplit_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
