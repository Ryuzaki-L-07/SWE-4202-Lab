namespace Tic_Tac_Toe
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
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B4 = new System.Windows.Forms.Button();
            this.B5 = new System.Windows.Forms.Button();
            this.B6 = new System.Windows.Forms.Button();
            this.B7 = new System.Windows.Forms.Button();
            this.B8 = new System.Windows.Forms.Button();
            this.B9 = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // B1
            // 
            this.B1.Location = new System.Drawing.Point(126, 108);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(77, 65);
            this.B1.TabIndex = 0;
            this.B1.Text = "B1";
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.B1_Click);
            // 
            // B2
            // 
            this.B2.Location = new System.Drawing.Point(209, 108);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(77, 65);
            this.B2.TabIndex = 1;
            this.B2.Text = "B2";
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.B2_Click);
            // 
            // B3
            // 
            this.B3.Location = new System.Drawing.Point(292, 108);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(77, 65);
            this.B3.TabIndex = 2;
            this.B3.Text = "B3";
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.B3_Click);
            // 
            // B4
            // 
            this.B4.Location = new System.Drawing.Point(126, 179);
            this.B4.Name = "B4";
            this.B4.Size = new System.Drawing.Size(77, 65);
            this.B4.TabIndex = 3;
            this.B4.Text = "B4";
            this.B4.UseVisualStyleBackColor = true;
            this.B4.Click += new System.EventHandler(this.B4_Click);
            // 
            // B5
            // 
            this.B5.Location = new System.Drawing.Point(209, 179);
            this.B5.Name = "B5";
            this.B5.Size = new System.Drawing.Size(77, 65);
            this.B5.TabIndex = 4;
            this.B5.Text = "B5";
            this.B5.UseVisualStyleBackColor = true;
            this.B5.Click += new System.EventHandler(this.B5_Click);
            // 
            // B6
            // 
            this.B6.Location = new System.Drawing.Point(292, 179);
            this.B6.Name = "B6";
            this.B6.Size = new System.Drawing.Size(77, 65);
            this.B6.TabIndex = 5;
            this.B6.Text = "B6";
            this.B6.UseVisualStyleBackColor = true;
            this.B6.Click += new System.EventHandler(this.B6_Click);
            // 
            // B7
            // 
            this.B7.Location = new System.Drawing.Point(126, 250);
            this.B7.Name = "B7";
            this.B7.Size = new System.Drawing.Size(77, 65);
            this.B7.TabIndex = 6;
            this.B7.Text = "B7";
            this.B7.UseVisualStyleBackColor = true;
            this.B7.Click += new System.EventHandler(this.B7_Click);
            // 
            // B8
            // 
            this.B8.Location = new System.Drawing.Point(209, 250);
            this.B8.Name = "B8";
            this.B8.Size = new System.Drawing.Size(77, 65);
            this.B8.TabIndex = 7;
            this.B8.Text = "B8";
            this.B8.UseVisualStyleBackColor = true;
            this.B8.Click += new System.EventHandler(this.B8_Click);
            // 
            // B9
            // 
            this.B9.Location = new System.Drawing.Point(292, 250);
            this.B9.Name = "B9";
            this.B9.Size = new System.Drawing.Size(77, 65);
            this.B9.TabIndex = 8;
            this.B9.Text = "B9";
            this.B9.UseVisualStyleBackColor = true;
            this.B9.Click += new System.EventHandler(this.B9_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(542, 372);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(100, 22);
            this.result.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 501);
            this.Controls.Add(this.result);
            this.Controls.Add(this.B9);
            this.Controls.Add(this.B8);
            this.Controls.Add(this.B7);
            this.Controls.Add(this.B6);
            this.Controls.Add(this.B5);
            this.Controls.Add(this.B4);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button B4;
        private System.Windows.Forms.Button B5;
        private System.Windows.Forms.Button B6;
        private System.Windows.Forms.Button B7;
        private System.Windows.Forms.Button B8;
        private System.Windows.Forms.Button B9;
        private System.Windows.Forms.TextBox result;
    }
}

