namespace MainEnterance
{
    partial class frmForget
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ver_email = new System.Windows.Forms.TextBox();
            this.btn_verification = new System.Windows.Forms.Button();
            this.txt_ver_code = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_zeroize = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(69, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "I forget my username or Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(168, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Don\'t worry about it!";
            // 
            // txt_ver_email
            // 
            this.txt_ver_email.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ver_email.Location = new System.Drawing.Point(128, 172);
            this.txt_ver_email.Name = "txt_ver_email";
            this.txt_ver_email.Size = new System.Drawing.Size(261, 29);
            this.txt_ver_email.TabIndex = 1;
            this.txt_ver_email.Text = "Your e-mail";
            this.txt_ver_email.Click += new System.EventHandler(this.txt_ver_email_Click);
            // 
            // btn_verification
            // 
            this.btn_verification.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_verification.Location = new System.Drawing.Point(128, 208);
            this.btn_verification.Name = "btn_verification";
            this.btn_verification.Size = new System.Drawing.Size(261, 44);
            this.btn_verification.TabIndex = 2;
            this.btn_verification.Text = "Sent Verification Code";
            this.btn_verification.UseVisualStyleBackColor = true;
            this.btn_verification.Click += new System.EventHandler(this.btn_verification_Click);
            // 
            // txt_ver_code
            // 
            this.txt_ver_code.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ver_code.Location = new System.Drawing.Point(128, 300);
            this.txt_ver_code.Name = "txt_ver_code";
            this.txt_ver_code.Size = new System.Drawing.Size(261, 29);
            this.txt_ver_code.TabIndex = 1;
            this.txt_ver_code.Text = "Enter Verification Code";
            this.txt_ver_code.Click += new System.EventHandler(this.txt_ver_code_Click);
            this.txt_ver_code.TextChanged += new System.EventHandler(this.txt_ver_code_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(75, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(384, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "After take your verification code, please enter here";
            // 
            // btn_zeroize
            // 
            this.btn_zeroize.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_zeroize.Location = new System.Drawing.Point(128, 335);
            this.btn_zeroize.Name = "btn_zeroize";
            this.btn_zeroize.Size = new System.Drawing.Size(261, 44);
            this.btn_zeroize.TabIndex = 2;
            this.btn_zeroize.Text = "Confirm";
            this.btn_zeroize.UseVisualStyleBackColor = true;
            this.btn_zeroize.Click += new System.EventHandler(this.btn_zeroize_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 97);
            this.panel1.TabIndex = 3;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // frmForget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(545, 415);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_zeroize);
            this.Controls.Add(this.btn_verification);
            this.Controls.Add(this.txt_ver_code);
            this.Controls.Add(this.txt_ver_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "frmForget";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "I forget my password";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ver_email;
        private System.Windows.Forms.Button btn_verification;
        private System.Windows.Forms.TextBox txt_ver_code;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_zeroize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer;
    }
}