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
    public partial class Auth : Form
    {
        public Auth()
        {


            InitializeComponent();
        }

        private void Reg_button_Click(object sender, EventArgs e)
        {
            var dialogResultatReg = new Reg().ShowDialog();
            if (dialogResultatReg == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            

        }

        private void Enter_button_Click(object sender, EventArgs e)
        {
            string logUser = LogBox.Text;
            string PassUser = PassBox.Text;

            DataBase db = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @Ulog AND `pass` = @Upas", db.getConn());
            cmd.Parameters.Add("@Ulog", MySqlDbType.VarChar).Value = logUser;
            cmd.Parameters.Add("@Upas", MySqlDbType.VarChar).Value = PassUser;

            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            if (LogBox.Text == "")
            {
                MessageBox.Show("Введите логин");
                return;

            }
            if (PassBox.Text == "")
            {
                MessageBox.Show("Введите пароль");
                return;

            }

            if (PassBox.TextLength < 8)
            {
                MessageBox.Show("Пароль должен содержать минимум 8 знаков");
                return;

            }
            if (table.Rows.Count > 0)
            {
                var dialogResultatEnter = new App().ShowDialog();
                if (dialogResultatEnter == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
                          
            else
                MessageBox.Show("Зарегистрируйтесь");

        }


    }
}
