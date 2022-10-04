namespace StopwatchUpdated
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMin = new System.Windows.Forms.Label();
            this.lblSec = new System.Windows.Forms.Label();
            this.lblCs = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMin.Location = new System.Drawing.Point(83, 60);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(67, 54);
            this.lblMin.TabIndex = 0;
            this.lblMin.Text = "00";
            this.lblMin.Click += new System.EventHandler(this.lblMin_Click);
            // 
            // lblSec
            // 
            this.lblSec.AutoSize = true;
            this.lblSec.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSec.Location = new System.Drawing.Point(194, 60);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(67, 54);
            this.lblSec.TabIndex = 1;
            this.lblSec.Text = "00";
            // 
            // lblCs
            // 
            this.lblCs.AutoSize = true;
            this.lblCs.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCs.Location = new System.Drawing.Point(305, 77);
            this.lblCs.Name = "lblCs";
            this.lblCs.Size = new System.Drawing.Size(47, 37);
            this.lblCs.TabIndex = 2;
            this.lblCs.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(156, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 54);
            this.label1.TabIndex = 3;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(267, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = ".";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(34, 178);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(94, 38);
            this.Start.TabIndex = 5;
            this.Start.Text = "START";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(176, 178);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(97, 37);
            this.Stop.TabIndex = 6;
            this.Stop.Text = "STOP";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(325, 178);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(92, 37);
            this.Reset.TabIndex = 7;
            this.Reset.Text = "RESET";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 281);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCs);
            this.Controls.Add(this.lblSec);
            this.Controls.Add(this.lblMin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblMin;
        private Label lblSec;
        private Label lblCs;
        private Label label1;
        private Label label2;
        private Button Start;
        private Button Stop;
        private Button Reset;
    }
}