namespace Volume_0_f_Cylinder
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
            this.cmdCalc = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtVolume = new System.Windows.Forms.Label();
            this.Warning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdCalc
            // 
            this.cmdCalc.Location = new System.Drawing.Point(21, 374);
            this.cmdCalc.Name = "cmdCalc";
            this.cmdCalc.Size = new System.Drawing.Size(130, 27);
            this.cmdCalc.TabIndex = 2;
            this.cmdCalc.Text = "Calculate";
            this.cmdCalc.UseVisualStyleBackColor = true;
            this.cmdCalc.Click += new System.EventHandler(this.cmdCalc_Click);
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(187, 374);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(130, 27);
            this.cmdClear.TabIndex = 3;
            this.cmdClear.Text = "Clear";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(342, 374);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 27);
            this.button3.TabIndex = 4;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Base Radius:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Height:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Volume:";
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(187, 73);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(208, 20);
            this.txtRadius.TabIndex = 12;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(187, 111);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(208, 20);
            this.txtHeight.TabIndex = 9;
            // 
            // txtVolume
            // 
            this.txtVolume.AutoSize = true;
            this.txtVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVolume.Location = new System.Drawing.Point(183, 147);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(0, 20);
            this.txtVolume.TabIndex = 10;
            this.txtVolume.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Warning
            // 
            this.Warning.AutoSize = true;
            this.Warning.BackColor = System.Drawing.SystemColors.Control;
            this.Warning.Location = new System.Drawing.Point(238, 76);
            this.Warning.Name = "Warning";
            this.Warning.Size = new System.Drawing.Size(0, 13);
            this.Warning.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(484, 413);
            this.Controls.Add(this.Warning);
            this.Controls.Add(this.txtVolume);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.cmdCalc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculate the volume of a cylinder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button cmdCalc;
        internal System.Windows.Forms.Button cmdClear;
        internal System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label txtVolume;
        private System.Windows.Forms.Label Warning;
    }
}

