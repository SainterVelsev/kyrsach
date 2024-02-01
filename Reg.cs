using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace I_veru_chto_eto_Konec
{
    public partial class Reg : Form
    {
        public Reg()
        {
            InitializeComponent();
            New_Log_box.Text = "Введите имя";
        }

        private void Reg_button_Click(object sender, EventArgs e)
        {
            if (New_Log_box.Text == "Введите имя")
            {
                MessageBox.Show("Введите имя");
                return;

            }
            if (New_Pass_box.Text == "")
            {
                MessageBox.Show("Введите пароль");
                return;

            }
            if (New_Pass_box.Text != Return_Pass_box.Text)
            {
                MessageBox.Show("Пароли должны совпадать");
                return;

            }
            if (New_Pass_box.TextLength < 8)
            {
                MessageBox.Show("Пароль должен содержать минимум 8 знаков");
                return;

            }
            if (iskUserExists())
                return;

            DataBase db = new DataBase();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `users` (`login`, `pass`) VALUES (@UL, @UP)", db.getConn());

            cmd.Parameters.Add("@UL", MySqlDbType.VarChar).Value = New_Log_box.Text;
            cmd.Parameters.Add("@UP", MySqlDbType.VarChar).Value = New_Pass_box.Text;

            db.openConn();

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт был создан");
                var dialogResultatAuth = new Auth().ShowDialog();
                if (dialogResultatAuth == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }

            else
                MessageBox.Show("Не получилось зарегистрироваться");


            db.closeConn();
        }

        public Boolean iskUserExists()
        {
            DataBase db = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @Ulog" , db.getConn());
            cmd.Parameters.Add("@Ulog", MySqlDbType.VarChar).Value = New_Log_box.Text;

            adapter.SelectCommand = cmd;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже используется");
                return true;

            }
            else
                return false;
        }


        private void New_Log_box_Enter(object sender, EventArgs e)
        {
            if (New_Log_box.Text == "Введите имя")
                New_Log_box.Text = "";
        }
        private void New_Log_box_Leave(object sender, EventArgs e)
        {
            if (New_Log_box.Text == "")
                New_Log_box.Text = "Введите имя";
        }
    }
}
