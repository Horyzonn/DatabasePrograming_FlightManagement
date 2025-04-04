using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using System.Data.SqlClient;

namespace FlightManagement
{
    public partial class FLogin : Form
    {
        private DataProvider provider;
        public FLogin()
        {
            InitializeComponent();
            provider = new DataProvider();
        }

        private bool UserLogin(UserDto u)
        {
            string sql = "SELECT COUNT() From";
            SqlCommand cmd = new SqlCommand(sql,provider.getCN());
            cmd.CommandType = CommandType.Text;
            provider.Connect();
            int num = (int)cmd.ExecuteScalar();
            provider.Disconnect();
            return(num>0);
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = txtUserName.Text.Trim();
            pass = txtPassWord.Text;
            UserDto u = new UserDto(user, pass);
            if(UserLogin(u)==true)
            {
                ChuongTrinh f = new ChuongTrinh();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                string msg = "Tên đăng nhập hoặc mật khẩu không đúng!!!";
                DialogResult result = MessageBox.Show(msg, "đăng nhập", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if(result==DialogResult.Retry)
                {
                    txtUserName.Focus();
                    txtPassWord.Clear();
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                }
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có thật sự muốn thoát chương trình?","Thông báo",MessageBoxButtons.OKCancel)!=System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        
    }
}
