namespace CoronaSimulator
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.numericHealty = new System.Windows.Forms.NumericUpDown();
            this.numericSick = new System.Windows.Forms.NumericUpDown();
            this.numericCarry = new System.Windows.Forms.NumericUpDown();
            this.numericTick = new System.Windows.Forms.NumericUpDown();
            this.numericFieldSize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.StartBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ForthScroll = new System.Windows.Forms.Label();
            this.hScrollBar4 = new System.Windows.Forms.HScrollBar();
            this.ThirdScroll = new System.Windows.Forms.Label();
            this.hScrollBar3 = new System.Windows.Forms.HScrollBar();
            this.SecondScroll = new System.Windows.Forms.Label();
            this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
            this.FirstScroll = new System.Windows.Forms.Label();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericCentersSize = new System.Windows.Forms.NumericUpDown();
            this.numericNumOfCenters = new System.Windows.Forms.NumericUpDown();
            this.checkBoxIncludeCenters = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioFreeFlow = new System.Windows.Forms.RadioButton();
            this.radioMatrix = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericHealty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCarry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFieldSize)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCentersSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumOfCenters)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericHealty
            // 
            this.numericHealty.Location = new System.Drawing.Point(127, 19);
            this.numericHealty.Name = "numericHealty";
            this.numericHealty.Size = new System.Drawing.Size(60, 20);
            this.numericHealty.TabIndex = 0;
            this.numericHealty.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericHealty.ValueChanged += new System.EventHandler(this.numericHealty_ValueChanged);
            // 
            // numericSick
            // 
            this.numericSick.Location = new System.Drawing.Point(127, 45);
            this.numericSick.Name = "numericSick";
            this.numericSick.Size = new System.Drawing.Size(60, 20);
            this.numericSick.TabIndex = 1;
            this.numericSick.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericSick.ValueChanged += new System.EventHandler(this.numericSick_ValueChanged);
            // 
            // numericCarry
            // 
            this.numericCarry.Location = new System.Drawing.Point(127, 71);
            this.numericCarry.Name = "numericCarry";
            this.numericCarry.Size = new System.Drawing.Size(60, 20);
            this.numericCarry.TabIndex = 2;
            this.numericCarry.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericCarry.ValueChanged += new System.EventHandler(this.numericCarry_ValueChanged);
            // 
            // numericTick
            // 
            this.numericTick.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericTick.Location = new System.Drawing.Point(127, 97);
            this.numericTick.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericTick.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericTick.Name = "numericTick";
            this.numericTick.Size = new System.Drawing.Size(60, 20);
            this.numericTick.TabIndex = 3;
            this.numericTick.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // numericFieldSize
            // 
            this.numericFieldSize.Location = new System.Drawing.Point(127, 123);
            this.numericFieldSize.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericFieldSize.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericFieldSize.Name = "numericFieldSize";
            this.numericFieldSize.Size = new System.Drawing.Size(60, 20);
            this.numericFieldSize.TabIndex = 4;
            this.numericFieldSize.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericFieldSize.ValueChanged += new System.EventHandler(this.numericFieldSize_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Healty ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(16, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Carry";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(16, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sick";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(16, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tick interval";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(16, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Field size";
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(578, 301);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(109, 28);
            this.StartBtn.TabIndex = 10;
            this.StartBtn.Text = "S&tart";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitBtn.Location = new System.Drawing.Point(450, 301);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(109, 28);
            this.ExitBtn.TabIndex = 11;
            this.ExitBtn.Text = "&Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.numericHealty);
            this.groupBox1.Controls.Add(this.numericSick);
            this.groupBox1.Controls.Add(this.numericCarry);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numericTick);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericFieldSize);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(23, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 163);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(200, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "ms.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(219, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(287, 37);
            this.label6.TabIndex = 13;
            this.label6.Text = "Covid-19 Simulator";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.ForthScroll);
            this.groupBox2.Controls.Add(this.hScrollBar4);
            this.groupBox2.Controls.Add(this.ThirdScroll);
            this.groupBox2.Controls.Add(this.hScrollBar3);
            this.groupBox2.Controls.Add(this.SecondScroll);
            this.groupBox2.Controls.Add(this.hScrollBar2);
            this.groupBox2.Controls.Add(this.FirstScroll);
            this.groupBox2.Controls.Add(this.hScrollBar1);
            this.groupBox2.Location = new System.Drawing.Point(288, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 163);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Statisitics";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Statisitic 4";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Statisitic 3";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Statisitic 2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Statisitic 1";
            // 
            // ForthScroll
            // 
            this.ForthScroll.AutoSize = true;
            this.ForthScroll.Location = new System.Drawing.Point(159, 107);
            this.ForthScroll.Name = "ForthScroll";
            this.ForthScroll.Size = new System.Drawing.Size(13, 13);
            this.ForthScroll.TabIndex = 22;
            this.ForthScroll.Text = "0";
            // 
            // hScrollBar4
            // 
            this.hScrollBar4.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.hScrollBar4.LargeChange = 1;
            this.hScrollBar4.Location = new System.Drawing.Point(181, 107);
            this.hScrollBar4.Minimum = 1;
            this.hScrollBar4.Name = "hScrollBar4";
            this.hScrollBar4.Size = new System.Drawing.Size(200, 10);
            this.hScrollBar4.TabIndex = 21;
            this.hScrollBar4.Value = 1;
            this.hScrollBar4.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar4_Scroll);
            // 
            // ThirdScroll
            // 
            this.ThirdScroll.AutoSize = true;
            this.ThirdScroll.Location = new System.Drawing.Point(159, 79);
            this.ThirdScroll.Name = "ThirdScroll";
            this.ThirdScroll.Size = new System.Drawing.Size(13, 13);
            this.ThirdScroll.TabIndex = 20;
            this.ThirdScroll.Text = "0";
            // 
            // hScrollBar3
            // 
            this.hScrollBar3.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.hScrollBar3.LargeChange = 1;
            this.hScrollBar3.Location = new System.Drawing.Point(181, 79);
            this.hScrollBar3.Minimum = 1;
            this.hScrollBar3.Name = "hScrollBar3";
            this.hScrollBar3.Size = new System.Drawing.Size(200, 10);
            this.hScrollBar3.TabIndex = 19;
            this.hScrollBar3.Value = 1;
            this.hScrollBar3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar3_Scroll);
            // 
            // SecondScroll
            // 
            this.SecondScroll.AutoSize = true;
            this.SecondScroll.Location = new System.Drawing.Point(159, 52);
            this.SecondScroll.Name = "SecondScroll";
            this.SecondScroll.Size = new System.Drawing.Size(13, 13);
            this.SecondScroll.TabIndex = 18;
            this.SecondScroll.Text = "0";
            // 
            // hScrollBar2
            // 
            this.hScrollBar2.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.hScrollBar2.LargeChange = 1;
            this.hScrollBar2.Location = new System.Drawing.Point(180, 55);
            this.hScrollBar2.Minimum = 1;
            this.hScrollBar2.Name = "hScrollBar2";
            this.hScrollBar2.Size = new System.Drawing.Size(201, 10);
            this.hScrollBar2.TabIndex = 17;
            this.hScrollBar2.Value = 1;
            this.hScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar2_Scroll);
            // 
            // FirstScroll
            // 
            this.FirstScroll.AutoSize = true;
            this.FirstScroll.Location = new System.Drawing.Point(159, 26);
            this.FirstScroll.Name = "FirstScroll";
            this.FirstScroll.Size = new System.Drawing.Size(13, 13);
            this.FirstScroll.TabIndex = 16;
            this.FirstScroll.Text = "0";
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.hScrollBar1.LargeChange = 1;
            this.hScrollBar1.Location = new System.Drawing.Point(181, 29);
            this.hScrollBar1.Minimum = 1;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(200, 10);
            this.hScrollBar1.TabIndex = 15;
            this.hScrollBar1.Value = 1;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.numericCentersSize);
            this.groupBox3.Controls.Add(this.numericNumOfCenters);
            this.groupBox3.Controls.Add(this.checkBoxIncludeCenters);
            this.groupBox3.Location = new System.Drawing.Point(23, 242);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(235, 97);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Centers";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Center size ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Numbers of centers ";
            // 
            // numericCentersSize
            // 
            this.numericCentersSize.Enabled = false;
            this.numericCentersSize.Location = new System.Drawing.Point(145, 65);
            this.numericCentersSize.Name = "numericCentersSize";
            this.numericCentersSize.Size = new System.Drawing.Size(72, 20);
            this.numericCentersSize.TabIndex = 2;
            // 
            // numericNumOfCenters
            // 
            this.numericNumOfCenters.Enabled = false;
            this.numericNumOfCenters.Location = new System.Drawing.Point(145, 38);
            this.numericNumOfCenters.Name = "numericNumOfCenters";
            this.numericNumOfCenters.Size = new System.Drawing.Size(72, 20);
            this.numericNumOfCenters.TabIndex = 1;
            // 
            // checkBoxIncludeCenters
            // 
            this.checkBoxIncludeCenters.AutoSize = true;
            this.checkBoxIncludeCenters.Location = new System.Drawing.Point(13, 19);
            this.checkBoxIncludeCenters.Name = "checkBoxIncludeCenters";
            this.checkBoxIncludeCenters.Size = new System.Drawing.Size(100, 17);
            this.checkBoxIncludeCenters.TabIndex = 0;
            this.checkBoxIncludeCenters.Text = "Include Centers";
            this.checkBoxIncludeCenters.UseVisualStyleBackColor = true;
            this.checkBoxIncludeCenters.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioFreeFlow);
            this.groupBox4.Controls.Add(this.radioMatrix);
            this.groupBox4.Location = new System.Drawing.Point(288, 243);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(114, 84);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Step type";
            // 
            // radioFreeFlow
            // 
            this.radioFreeFlow.AutoSize = true;
            this.radioFreeFlow.Checked = true;
            this.radioFreeFlow.Location = new System.Drawing.Point(18, 53);
            this.radioFreeFlow.Name = "radioFreeFlow";
            this.radioFreeFlow.Size = new System.Drawing.Size(68, 17);
            this.radioFreeFlow.TabIndex = 1;
            this.radioFreeFlow.TabStop = true;
            this.radioFreeFlow.Text = "Free flow";
            this.radioFreeFlow.UseVisualStyleBackColor = true;
            this.radioFreeFlow.Click += new System.EventHandler(this.radioFreeFlow_Checked);
            // 
            // radioMatrix
            // 
            this.radioMatrix.AutoSize = true;
            this.radioMatrix.Location = new System.Drawing.Point(18, 30);
            this.radioMatrix.Name = "radioMatrix";
            this.radioMatrix.Size = new System.Drawing.Size(53, 17);
            this.radioMatrix.TabIndex = 0;
            this.radioMatrix.Text = "Matrix";
            this.radioMatrix.UseVisualStyleBackColor = true;
            this.radioMatrix.Click += new System.EventHandler(this.radioMatrix_Checked);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.ExitBtn;
            this.ClientSize = new System.Drawing.Size(704, 348);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.StartBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Covid-19 Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericHealty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCarry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFieldSize)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCentersSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumOfCenters)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericHealty;
        private System.Windows.Forms.NumericUpDown numericSick;
        private System.Windows.Forms.NumericUpDown numericCarry;
        private System.Windows.Forms.NumericUpDown numericTick;
        private System.Windows.Forms.NumericUpDown numericFieldSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Label FirstScroll;
        private System.Windows.Forms.Label ForthScroll;
        private System.Windows.Forms.HScrollBar hScrollBar4;
        private System.Windows.Forms.Label ThirdScroll;
        private System.Windows.Forms.HScrollBar hScrollBar3;
        private System.Windows.Forms.Label SecondScroll;
        private System.Windows.Forms.HScrollBar hScrollBar2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericCentersSize;
        private System.Windows.Forms.NumericUpDown numericNumOfCenters;
        private System.Windows.Forms.CheckBox checkBoxIncludeCenters;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioFreeFlow;
        private System.Windows.Forms.RadioButton radioMatrix;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}

