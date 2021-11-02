namespace Attendance_System
{
    partial class RegisterFrm
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
            this.TxtUSer = new MetroFramework.Controls.MetroTextBox();
            this.TxtPass1 = new MetroFramework.Controls.MetroTextBox();
            this.Txtpass2 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtUSer
            // 
            this.TxtUSer.Location = new System.Drawing.Point(229, 236);
            this.TxtUSer.Margin = new System.Windows.Forms.Padding(4);
            this.TxtUSer.Name = "TxtUSer";
            this.TxtUSer.Size = new System.Drawing.Size(190, 28);
            this.TxtUSer.TabIndex = 0;
            // 
            // TxtPass1
            // 
            this.TxtPass1.Location = new System.Drawing.Point(229, 314);
            this.TxtPass1.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPass1.Name = "TxtPass1";
            this.TxtPass1.PasswordChar = '*';
            this.TxtPass1.Size = new System.Drawing.Size(190, 28);
            this.TxtPass1.TabIndex = 1;
            // 
            // Txtpass2
            // 
            this.Txtpass2.Location = new System.Drawing.Point(229, 370);
            this.Txtpass2.Margin = new System.Windows.Forms.Padding(4);
            this.Txtpass2.Name = "Txtpass2";
            this.Txtpass2.PasswordChar = '*';
            this.Txtpass2.Size = new System.Drawing.Size(190, 28);
            this.Txtpass2.TabIndex = 2;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(170, 434);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(4);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(100, 28);
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "Accept";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Username";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Confirm Password";
            this.label2.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 28.2F);
            this.label1.Location = new System.Drawing.Point(115, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 62);
            this.label1.TabIndex = 8;
            this.label1.Text = "Register ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegisterFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(471, 507);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.Txtpass2);
            this.Controls.Add(this.TxtPass1);
            this.Controls.Add(this.TxtUSer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegisterFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox TxtUSer;
        private MetroFramework.Controls.MetroTextBox TxtPass1;
        private MetroFramework.Controls.MetroTextBox Txtpass2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}