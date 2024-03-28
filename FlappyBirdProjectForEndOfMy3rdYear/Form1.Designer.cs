namespace LillerXxX
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.UsernameTB = new System.Windows.Forms.TextBox();
            this.UsernameL = new System.Windows.Forms.Label();
            this.PasswordL = new System.Windows.Forms.Label();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.Velemeny = new System.Windows.Forms.LinkLabel();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UsernameTB
            // 
            this.UsernameTB.Location = new System.Drawing.Point(35, 70);
            this.UsernameTB.Name = "UsernameTB";
            this.UsernameTB.Size = new System.Drawing.Size(100, 20);
            this.UsernameTB.TabIndex = 2;
            this.UsernameTB.TextChanged += new System.EventHandler(this.UsernameTB_TextChanged);
            // 
            // UsernameL
            // 
            this.UsernameL.AutoSize = true;
            this.UsernameL.Location = new System.Drawing.Point(59, 73);
            this.UsernameL.Name = "UsernameL";
            this.UsernameL.Size = new System.Drawing.Size(55, 13);
            this.UsernameL.TabIndex = 3;
            this.UsernameL.Text = "Username";
            // 
            // PasswordL
            // 
            this.PasswordL.AutoSize = true;
            this.PasswordL.Location = new System.Drawing.Point(59, 103);
            this.PasswordL.Name = "PasswordL";
            this.PasswordL.Size = new System.Drawing.Size(53, 13);
            this.PasswordL.TabIndex = 5;
            this.PasswordL.Text = "Password";
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(35, 100);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.PasswordChar = '*';
            this.PasswordTB.Size = new System.Drawing.Size(100, 20);
            this.PasswordTB.TabIndex = 4;
            this.PasswordTB.TextChanged += new System.EventHandler(this.PasswordTB_TextChanged);
            // 
            // Velemeny
            // 
            this.Velemeny.AutoSize = true;
            this.Velemeny.Location = new System.Drawing.Point(0, 171);
            this.Velemeny.Name = "Velemeny";
            this.Velemeny.Size = new System.Drawing.Size(53, 13);
            this.Velemeny.TabIndex = 6;
            this.Velemeny.TabStop = true;
            this.Velemeny.Text = "Velemeny";
            this.Velemeny.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Velemeny_LinkClicked);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(136, 162);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(41, 22);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(174, 184);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Velemeny);
            this.Controls.Add(this.PasswordL);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.UsernameL);
            this.Controls.Add(this.UsernameTB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox UsernameTB;
        private System.Windows.Forms.Label UsernameL;
        private System.Windows.Forms.Label PasswordL;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.LinkLabel Velemeny;
        private System.Windows.Forms.Button Exit;
    }
}

