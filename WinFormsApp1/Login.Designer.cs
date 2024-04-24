namespace WinFormsApp1
{
    partial class Login
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
            label1 = new Label();
            userLabel = new Label();
            passwordLabel = new Label();
            loginButton = new Button();
            userBox = new TextBox();
            passwordBox = new TextBox();
            loginWarningLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(206, 9);
            label1.Name = "label1";
            label1.Size = new Size(356, 58);
            label1.TabIndex = 0;
            label1.Text = "Programa Dieta";
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Location = new Point(148, 114);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(30, 15);
            userLabel.TabIndex = 1;
            userLabel.Text = "User";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.ForeColor = Color.Black;
            passwordLabel.Location = new Point(148, 153);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(57, 15);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Password";
            // 
            // loginButton
            // 
            loginButton.Location = new Point(183, 196);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(136, 23);
            loginButton.TabIndex = 3;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // userBox
            // 
            userBox.Location = new Point(219, 111);
            userBox.Name = "userBox";
            userBox.Size = new Size(100, 23);
            userBox.TabIndex = 4;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(219, 150);
            passwordBox.Name = "passwordBox";
            passwordBox.PasswordChar = '*';
            passwordBox.Size = new Size(100, 23);
            passwordBox.TabIndex = 5;
            // 
            // loginWarningLabel
            // 
            loginWarningLabel.AutoSize = true;
            loginWarningLabel.ForeColor = Color.Red;
            loginWarningLabel.Location = new Point(353, 128);
            loginWarningLabel.Name = "loginWarningLabel";
            loginWarningLabel.Size = new Size(175, 15);
            loginWarningLabel.TabIndex = 6;
            loginWarningLabel.Text = "Usuario o contraseña incorrecto";
            loginWarningLabel.Visible = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 315);
            Controls.Add(loginWarningLabel);
            Controls.Add(passwordBox);
            Controls.Add(userBox);
            Controls.Add(loginButton);
            Controls.Add(passwordLabel);
            Controls.Add(userLabel);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label userLabel;
        private Label passwordLabel;
        private Button loginButton;
        private TextBox userBox;
        private TextBox passwordBox;
        private Label loginWarningLabel;
    }
}