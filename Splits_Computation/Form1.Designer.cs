namespace Splits_Computation
{
    partial class Splits_Comp
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
            this.lblWeight = new System.Windows.Forms.Label();
            this.numUDWeight = new System.Windows.Forms.NumericUpDown();
            this.chkLinearDecay = new System.Windows.Forms.CheckBox();
            this.btnBalanced = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPBChance = new System.Windows.Forms.Button();
            this.chkChunkify = new System.Windows.Forms.CheckBox();
            this.numUDChunkify = new System.Windows.Forms.NumericUpDown();
            this.btnFileBrowse = new System.Windows.Forms.Button();
            this.txtFileBrowse = new System.Windows.Forms.TextBox();
            this.txtTargetTime = new System.Windows.Forms.TextBox();
            this.lblTargetTime = new System.Windows.Forms.Label();
            this.chkUsePB = new System.Windows.Forms.CheckBox();
            this.lblResetIterations = new System.Windows.Forms.Label();
            this.numUDResetIterations = new System.Windows.Forms.NumericUpDown();
            this.lblWorking = new System.Windows.Forms.Label();
            this.lblPBChanceStartSplit = new System.Windows.Forms.Label();
            this.numUDPBChanceSplit = new System.Windows.Forms.NumericUpDown();
            this.lblPBChanceTime = new System.Windows.Forms.Label();
            this.txtPBChanceTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUDWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDChunkify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDResetIterations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDPBChanceSplit)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(9, 69);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(84, 13);
            this.lblWeight.TabIndex = 0;
            this.lblWeight.Text = "Recency weight";
            this.lblWeight.Click += new System.EventHandler(this.lblWeight_Click);
            // 
            // numUDWeight
            // 
            this.numUDWeight.DecimalPlaces = 2;
            this.numUDWeight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numUDWeight.Location = new System.Drawing.Point(93, 67);
            this.numUDWeight.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDWeight.Name = "numUDWeight";
            this.numUDWeight.Size = new System.Drawing.Size(46, 20);
            this.numUDWeight.TabIndex = 2;
            this.numUDWeight.Value = new decimal(new int[] {
            75,
            0,
            0,
            131072});
            this.numUDWeight.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // chkLinearDecay
            // 
            this.chkLinearDecay.AutoSize = true;
            this.chkLinearDecay.Location = new System.Drawing.Point(12, 93);
            this.chkLinearDecay.Name = "chkLinearDecay";
            this.chkLinearDecay.Size = new System.Drawing.Size(87, 17);
            this.chkLinearDecay.TabIndex = 3;
            this.chkLinearDecay.Text = "Linear decay";
            this.chkLinearDecay.UseVisualStyleBackColor = true;
            this.chkLinearDecay.CheckedChanged += new System.EventHandler(this.chkLinearDecay_CheckedChanged);
            // 
            // btnBalanced
            // 
            this.btnBalanced.Location = new System.Drawing.Point(12, 208);
            this.btnBalanced.Name = "btnBalanced";
            this.btnBalanced.Size = new System.Drawing.Size(75, 23);
            this.btnBalanced.TabIndex = 4;
            this.btnBalanced.Text = "Balanced";
            this.btnBalanced.UseVisualStyleBackColor = true;
            this.btnBalanced.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(100, 208);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPBChance
            // 
            this.btnPBChance.Location = new System.Drawing.Point(186, 208);
            this.btnPBChance.Name = "btnPBChance";
            this.btnPBChance.Size = new System.Drawing.Size(75, 23);
            this.btnPBChance.TabIndex = 6;
            this.btnPBChance.Text = "Sim Chance";
            this.btnPBChance.UseVisualStyleBackColor = true;
            this.btnPBChance.Click += new System.EventHandler(this.button3_Click);
            // 
            // chkChunkify
            // 
            this.chkChunkify.AutoSize = true;
            this.chkChunkify.Location = new System.Drawing.Point(12, 116);
            this.chkChunkify.Name = "chkChunkify";
            this.chkChunkify.Size = new System.Drawing.Size(67, 17);
            this.chkChunkify.TabIndex = 8;
            this.chkChunkify.Text = "Chunkify";
            this.chkChunkify.UseVisualStyleBackColor = true;
            this.chkChunkify.CheckedChanged += new System.EventHandler(this.chkChunkify_CheckedChanged);
            // 
            // numUDChunkify
            // 
            this.numUDChunkify.Enabled = false;
            this.numUDChunkify.Location = new System.Drawing.Point(93, 115);
            this.numUDChunkify.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numUDChunkify.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDChunkify.Name = "numUDChunkify";
            this.numUDChunkify.Size = new System.Drawing.Size(38, 20);
            this.numUDChunkify.TabIndex = 9;
            this.numUDChunkify.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDChunkify.ValueChanged += new System.EventHandler(this.numUDChunkify_ValueChanged);
            // 
            // btnFileBrowse
            // 
            this.btnFileBrowse.Location = new System.Drawing.Point(211, 12);
            this.btnFileBrowse.Name = "btnFileBrowse";
            this.btnFileBrowse.Size = new System.Drawing.Size(50, 20);
            this.btnFileBrowse.TabIndex = 10;
            this.btnFileBrowse.Text = "Browse";
            this.btnFileBrowse.UseVisualStyleBackColor = true;
            this.btnFileBrowse.Click += new System.EventHandler(this.btnFileBrowse_Click);
            // 
            // txtFileBrowse
            // 
            this.txtFileBrowse.Location = new System.Drawing.Point(12, 12);
            this.txtFileBrowse.Name = "txtFileBrowse";
            this.txtFileBrowse.ReadOnly = true;
            this.txtFileBrowse.Size = new System.Drawing.Size(193, 20);
            this.txtFileBrowse.TabIndex = 11;
            // 
            // txtTargetTime
            // 
            this.txtTargetTime.Enabled = false;
            this.txtTargetTime.Location = new System.Drawing.Point(93, 44);
            this.txtTargetTime.Name = "txtTargetTime";
            this.txtTargetTime.Size = new System.Drawing.Size(100, 20);
            this.txtTargetTime.TabIndex = 12;
            this.txtTargetTime.Text = "hh:mm:ss";
            this.txtTargetTime.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblTargetTime
            // 
            this.lblTargetTime.AutoSize = true;
            this.lblTargetTime.Location = new System.Drawing.Point(9, 47);
            this.lblTargetTime.Name = "lblTargetTime";
            this.lblTargetTime.Size = new System.Drawing.Size(60, 13);
            this.lblTargetTime.TabIndex = 13;
            this.lblTargetTime.Text = "Target time";
            // 
            // chkUsePB
            // 
            this.chkUsePB.AutoSize = true;
            this.chkUsePB.Checked = true;
            this.chkUsePB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUsePB.Location = new System.Drawing.Point(199, 46);
            this.chkUsePB.Name = "chkUsePB";
            this.chkUsePB.Size = new System.Drawing.Size(62, 17);
            this.chkUsePB.TabIndex = 14;
            this.chkUsePB.Text = "Use PB";
            this.chkUsePB.UseVisualStyleBackColor = true;
            this.chkUsePB.CheckedChanged += new System.EventHandler(this.chkUsePB_CheckedChanged);
            // 
            // lblResetIterations
            // 
            this.lblResetIterations.AutoSize = true;
            this.lblResetIterations.Location = new System.Drawing.Point(9, 139);
            this.lblResetIterations.Name = "lblResetIterations";
            this.lblResetIterations.Size = new System.Drawing.Size(80, 13);
            this.lblResetIterations.TabIndex = 15;
            this.lblResetIterations.Text = "Reset iterations";
            this.lblResetIterations.Click += new System.EventHandler(this.lblResetIterations_Click);
            // 
            // numUDResetIterations
            // 
            this.numUDResetIterations.Location = new System.Drawing.Point(93, 137);
            this.numUDResetIterations.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numUDResetIterations.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDResetIterations.Name = "numUDResetIterations";
            this.numUDResetIterations.Size = new System.Drawing.Size(38, 20);
            this.numUDResetIterations.TabIndex = 16;
            this.numUDResetIterations.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblWorking
            // 
            this.lblWorking.AutoSize = true;
            this.lblWorking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorking.Location = new System.Drawing.Point(200, 185);
            this.lblWorking.Name = "lblWorking";
            this.lblWorking.Size = new System.Drawing.Size(61, 15);
            this.lblWorking.TabIndex = 17;
            this.lblWorking.Text = "Working...";
            this.lblWorking.Visible = false;
            // 
            // lblPBChanceStartSplit
            // 
            this.lblPBChanceStartSplit.AutoSize = true;
            this.lblPBChanceStartSplit.Location = new System.Drawing.Point(9, 160);
            this.lblPBChanceStartSplit.Name = "lblPBChanceStartSplit";
            this.lblPBChanceStartSplit.Size = new System.Drawing.Size(85, 13);
            this.lblPBChanceStartSplit.TabIndex = 18;
            this.lblPBChanceStartSplit.Text = "Sim Chance split";
            this.lblPBChanceStartSplit.Click += new System.EventHandler(this.lblPBChanceStartSplit_Click);
            // 
            // numUDPBChanceSplit
            // 
            this.numUDPBChanceSplit.Location = new System.Drawing.Point(93, 158);
            this.numUDPBChanceSplit.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numUDPBChanceSplit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDPBChanceSplit.Name = "numUDPBChanceSplit";
            this.numUDPBChanceSplit.Size = new System.Drawing.Size(38, 20);
            this.numUDPBChanceSplit.TabIndex = 19;
            this.numUDPBChanceSplit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDPBChanceSplit.ValueChanged += new System.EventHandler(this.numUDPBChanceSplit_ValueChanged);
            // 
            // lblPBChanceTime
            // 
            this.lblPBChanceTime.AutoSize = true;
            this.lblPBChanceTime.Location = new System.Drawing.Point(9, 183);
            this.lblPBChanceTime.Name = "lblPBChanceTime";
            this.lblPBChanceTime.Size = new System.Drawing.Size(86, 13);
            this.lblPBChanceTime.TabIndex = 20;
            this.lblPBChanceTime.Text = "Sim Chance time";
            // 
            // txtPBChanceTime
            // 
            this.txtPBChanceTime.Location = new System.Drawing.Point(93, 180);
            this.txtPBChanceTime.Name = "txtPBChanceTime";
            this.txtPBChanceTime.Size = new System.Drawing.Size(100, 20);
            this.txtPBChanceTime.TabIndex = 0;
            this.txtPBChanceTime.Text = "hh:mm:ss";
            this.txtPBChanceTime.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Splits_Comp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 235);
            this.Controls.Add(this.txtPBChanceTime);
            this.Controls.Add(this.lblPBChanceTime);
            this.Controls.Add(this.numUDPBChanceSplit);
            this.Controls.Add(this.lblPBChanceStartSplit);
            this.Controls.Add(this.lblWorking);
            this.Controls.Add(this.numUDResetIterations);
            this.Controls.Add(this.lblResetIterations);
            this.Controls.Add(this.chkUsePB);
            this.Controls.Add(this.lblTargetTime);
            this.Controls.Add(this.txtTargetTime);
            this.Controls.Add(this.txtFileBrowse);
            this.Controls.Add(this.btnFileBrowse);
            this.Controls.Add(this.numUDChunkify);
            this.Controls.Add(this.chkChunkify);
            this.Controls.Add(this.btnPBChance);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnBalanced);
            this.Controls.Add(this.chkLinearDecay);
            this.Controls.Add(this.numUDWeight);
            this.Controls.Add(this.lblWeight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Splits_Comp";
            this.Text = "Splits Comp";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUDWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDChunkify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDResetIterations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDPBChanceSplit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.NumericUpDown numUDWeight;
        private System.Windows.Forms.CheckBox chkLinearDecay;
        private System.Windows.Forms.Button btnBalanced;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPBChance;
        private System.Windows.Forms.CheckBox chkChunkify;
        private System.Windows.Forms.NumericUpDown numUDChunkify;
        private System.Windows.Forms.Button btnFileBrowse;
        private System.Windows.Forms.TextBox txtFileBrowse;
        private System.Windows.Forms.TextBox txtTargetTime;
        private System.Windows.Forms.Label lblTargetTime;
        private System.Windows.Forms.CheckBox chkUsePB;
        private System.Windows.Forms.Label lblResetIterations;
        private System.Windows.Forms.NumericUpDown numUDResetIterations;
        private System.Windows.Forms.Label lblWorking;
        private System.Windows.Forms.Label lblPBChanceStartSplit;
        private System.Windows.Forms.NumericUpDown numUDPBChanceSplit;
        private System.Windows.Forms.Label lblPBChanceTime;
        private System.Windows.Forms.TextBox txtPBChanceTime;
    }
}

