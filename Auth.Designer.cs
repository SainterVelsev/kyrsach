
namespace I_veru_chto_eto_Konec
{
    partial class Auth
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
            this.LogBox = new System.Windows.Forms.TextBox();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.Log_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Enter_button = new System.Windows.Forms.Button();
            this.Reg_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogBox
            // 
            this.LogBox.Location = new System.Drawing.Point(65, 50);
            this.LogBox.Name = "LogBox";
            this.LogBox.Size = new System.Drawing.Size(100, 20);
            this.LogBox.TabIndex = 0;
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(65, 76);
            this.PassBox.Name = "PassBox";
            this.PassBox.PasswordChar = '*';
            this.PassBox.Size = new System.Drawing.Size(100, 20);
            this.PassBox.TabIndex = 1;
            // 
            // Log_label
            // 
            this.Log_label.AutoSize = true;
            this.Log_label.Location = new System.Drawing.Point(12, 53);
            this.Log_label.Name = "Log_label";
            this.Log_label.Size = new System.Drawing.Size(38, 13);
            this.Log_label.TabIndex = 2;
            this.Log_label.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Maroon;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(61, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Добро пожаловать";
            // 
            // Enter_button
            // 
            this.Enter_button.Location = new System.Drawing.Point(257, 179);
            this.Enter_button.Name = "Enter_button";
            this.Enter_button.Size = new System.Drawing.Size(75, 23);
            this.Enter_button.TabIndex = 5;
            this.Enter_button.Text = "Вход";
            this.Enter_button.UseVisualStyleBackColor = true;
            this.Enter_button.Click += new System.EventHandler(this.Enter_button_Click);
            // 
            // Reg_button
            // 
            this.Reg_button.Location = new System.Drawing.Point(20, 179);
            this.Reg_button.Name = "Reg_button";
            this.Reg_button.Size = new System.Drawing.Size(83, 23);
            this.Reg_button.TabIndex = 6;
            this.Reg_button.Text = "Регистрация";
            this.Reg_button.UseVisualStyleBackColor = true;
            this.Reg_button.Click += new System.EventHandler(this.Reg_button_Click);
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::I_veru_chto_eto_Konec.Properties.Resources.photo_2024_01_30_01_55_36;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(344, 232);
            this.Controls.Add(this.Reg_button);
            this.Controls.Add(this.Enter_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Log_label);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.LogBox);
            this.MaximumSize = new System.Drawing.Size(360, 271);
            this.MinimumSize = new System.Drawing.Size(360, 271);
            this.Name = "Auth";
            this.Text = "Auth";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LogBox;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.Label Log_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Enter_button;
        private System.Windows.Forms.Button Reg_button;
    }
}