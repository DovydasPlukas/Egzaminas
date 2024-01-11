namespace Egzaminas
{
    partial class Prisijungimas
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
            ButtonPrisijungti = new Button();
            textBoxUser = new TextBox();
            textBoxPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // ButtonPrisijungti
            // 
            ButtonPrisijungti.Location = new Point(75, 155);
            ButtonPrisijungti.Name = "ButtonPrisijungti";
            ButtonPrisijungti.Size = new Size(75, 23);
            ButtonPrisijungti.TabIndex = 0;
            ButtonPrisijungti.Text = "Prisijungti";
            ButtonPrisijungti.UseVisualStyleBackColor = true;
            ButtonPrisijungti.Click += ButtonPrisijungti_Click;
            // 
            // textBoxUser
            // 
            textBoxUser.Location = new Point(33, 45);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(164, 23);
            textBoxUser.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(33, 103);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(164, 23);
            textBoxPassword.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 27);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 3;
            label1.Text = "Vartotojas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 85);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 4;
            label2.Text = "Slaptazodis";
            // 
            // Prisijungimas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(242, 192);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUser);
            Controls.Add(ButtonPrisijungti);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Prisijungimas";
            ShowIcon = false;
            Text = "Prisijungimas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonPrisijungti;
        private TextBox textBoxUser;
        private TextBox textBoxPassword;
        private Label label1;
        private Label label2;
    }
}