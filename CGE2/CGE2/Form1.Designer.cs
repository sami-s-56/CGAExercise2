namespace CGE2
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
            trackBar1 = new System.Windows.Forms.TrackBar();
            trackBar2 = new System.Windows.Forms.TrackBar();
            trackBar3 = new System.Windows.Forms.TrackBar();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            VValue = new System.Windows.Forms.Label();
            UValue = new System.Windows.Forms.Label();
            YValue = new System.Windows.Forms.Label();
            checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).BeginInit();
            SuspendLayout();
            // 
            // trackBar1
            // 
            trackBar1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            trackBar1.Location = new System.Drawing.Point(100, 50);
            trackBar1.Maximum = 200;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new System.Drawing.Size(400, 45);
            trackBar1.TabIndex = 0;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // trackBar2
            // 
            trackBar2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            trackBar2.Location = new System.Drawing.Point(100, 125);
            trackBar2.Maximum = 200;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new System.Drawing.Size(400, 45);
            trackBar2.TabIndex = 1;
            trackBar2.Scroll += trackBar2_Scroll;
            // 
            // trackBar3
            // 
            trackBar3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            trackBar3.Location = new System.Drawing.Point(100, 200);
            trackBar3.Maximum = 200;
            trackBar3.Name = "trackBar3";
            trackBar3.Size = new System.Drawing.Size(400, 45);
            trackBar3.TabIndex = 2;
            trackBar3.Scroll += trackBar3_Scroll;
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(69, 50);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(25, 25);
            label1.TabIndex = 3;
            label1.Text = "Y";
            label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(69, 125);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(25, 25);
            label2.TabIndex = 4;
            label2.Text = "U";
            label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(69, 200);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(25, 25);
            label3.TabIndex = 5;
            label3.Text = "V";
            label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // VValue
            // 
            VValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            VValue.Location = new System.Drawing.Point(506, 200);
            VValue.Name = "VValue";
            VValue.Size = new System.Drawing.Size(40, 25);
            VValue.TabIndex = 8;
            VValue.Text = "V";
            VValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UValue
            // 
            UValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            UValue.Location = new System.Drawing.Point(506, 125);
            UValue.Name = "UValue";
            UValue.Size = new System.Drawing.Size(40, 25);
            UValue.TabIndex = 7;
            UValue.Text = "U";
            UValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // YValue
            // 
            YValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            YValue.Location = new System.Drawing.Point(506, 50);
            YValue.Name = "YValue";
            YValue.Size = new System.Drawing.Size(40, 25);
            YValue.TabIndex = 6;
            YValue.Text = "200";
            YValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            checkBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            checkBox1.Location = new System.Drawing.Point(100, 275);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(200, 25);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Invert";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(584, 361);
            Controls.Add(checkBox1);
            Controls.Add(VValue);
            Controls.Add(UValue);
            Controls.Add(YValue);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(trackBar3);
            Controls.Add(trackBar2);
            Controls.Add(trackBar1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label VValue;
        private System.Windows.Forms.Label UValue;
        private System.Windows.Forms.Label YValue;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}