﻿
namespace I_veru_chto_eto_Konec
{
    partial class Reg
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
            this.Reg_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.New_Log_box = new System.Windows.Forms.TextBox();
            this.New_Pass_box = new System.Windows.Forms.TextBox();
            this.Return_Pass_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Reg_button
            // 
            this.Reg_button.Location = new System.Drawing.Point(113, 267);
            this.Reg_button.Name = "Reg_button";
            this.Reg_button.Size = new System.Drawing.Size(134, 31);
            this.Reg_button.TabIndex = 0;
            this.Reg_button.Text = "Зарегистрироваться";
            this.Reg_button.UseVisualStyleBackColor = true;
            this.Reg_button.Click += new System.EventHandler(this.Reg_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль";
            // 
            // New_Log_box
            // 
            this.New_Log_box.Location = new System.Drawing.Point(12, 116);
            this.New_Log_box.Name = "New_Log_box";
            this.New_Log_box.Size = new System.Drawing.Size(100, 20);
            this.New_Log_box.TabIndex = 3;
            this.New_Log_box.Enter += new System.EventHandler(this.New_Log_box_Enter);
            // 
            // New_Pass_box
            // 
            this.New_Pass_box.Location = new System.Drawing.Point(12, 161);
            this.New_Pass_box.Name = "New_Pass_box";
            this.New_Pass_box.PasswordChar = '*';
            this.New_Pass_box.Size = new System.Drawing.Size(100, 20);
            this.New_Pass_box.TabIndex = 4;
            // 
            // Return_Pass_box
            // 
            this.Return_Pass_box.Location = new System.Drawing.Point(12, 196);
            this.Return_Pass_box.Name = "Return_Pass_box";
            this.Return_Pass_box.PasswordChar = '*';
            this.Return_Pass_box.Size = new System.Drawing.Size(100, 20);
            this.Return_Pass_box.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Повторите пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Осталось зарегистрироваться";
            // 
            // Reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::I_veru_chto_eto_Konec.Properties.Resources.photo_2024_01_30_03_01_52;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(353, 310);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Return_Pass_box);
            this.Controls.Add(this.New_Pass_box);
            this.Controls.Add(this.New_Log_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Reg_button);
            this.Name = "Reg";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Reg_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox New_Log_box;
        private System.Windows.Forms.TextBox New_Pass_box;
        private System.Windows.Forms.TextBox Return_Pass_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}