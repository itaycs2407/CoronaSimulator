namespace CoronaSimulator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericHealty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCarry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFieldSize)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericHealty
            // 
            this.numericHealty.Location = new System.Drawing.Point(127, 19);
            this.numericHealty.Name = "numericHealty";
            this.numericHealty.Size = new System.Drawing.Size(60, 20);
            this.numericHealty.TabIndex = 0;
            this.numericHealty.ValueChanged += new System.EventHandler(this.numericHealty_ValueChanged);
            // 
            // numericSick
            // 
            this.numericSick.Location = new System.Drawing.Point(127, 45);
            this.numericSick.Name = "numericSick";
            this.numericSick.Size = new System.Drawing.Size(60, 20);
            this.numericSick.TabIndex = 1;
            this.numericSick.ValueChanged += new System.EventHandler(this.numericSick_ValueChanged);
            // 
            // numericCarry
            // 
            this.numericCarry.Location = new System.Drawing.Point(127, 71);
            this.numericCarry.Name = "numericCarry";
            this.numericCarry.Size = new System.Drawing.Size(60, 20);
            this.numericCarry.TabIndex = 2;
            this.numericCarry.ValueChanged += new System.EventHandler(this.numericCarry_ValueChanged);
            // 
            // numericTick
            // 
            this.numericTick.Location = new System.Drawing.Point(127, 97);
            this.numericTick.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericTick.Name = "numericTick";
            this.numericTick.Size = new System.Drawing.Size(60, 20);
            this.numericTick.TabIndex = 3;
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
            this.StartBtn.Location = new System.Drawing.Point(669, 395);
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
            this.ExitBtn.Location = new System.Drawing.Point(541, 395);
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
            this.groupBox1.Size = new System.Drawing.Size(203, 163);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(281, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(287, 37);
            this.label6.TabIndex = 13;
            this.label6.Text = "Covid-19 Simulator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.ExitBtn;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.StartBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
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
    }
}

