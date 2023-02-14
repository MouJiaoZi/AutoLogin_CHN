using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace AutoLogin
{
    public partial class PasswordForm : Form
    {
        public PasswordForm()
        {
            InitializeComponent();
        }

        private void PasswordForm_Load(object sender, EventArgs e)
        {
            if (!MainForm.SETTINGS.HasPassword)
            {
                txtCurrent.Text = MainForm.PASSWORD;
            }
        }

        public void GetPassword(MainForm mForm)
        {
            label2.Visible = false;
            label3.Visible = false;
            txtNew.Visible = false;
            txtConfirm.Visible = false;
            btnClose.Visible = false;
            btnSave.Visible = false;
            btnSubmit.Visible = true;
            this.Text = "请输入密码";
            //txtCurrent.Width = 226;
            this.Height = 130;
            this.ShowDialog(mForm);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCurrent.Text == MainForm.PASSWORD)
            {
                if (txtNew.Text == txtConfirm.Text)
                {
                    if (txtCurrent.Text == txtNew.Text)
                    {
                        MessageBox.Show("新密码不能与旧密码相同！");
                    }
                    else
                    {
                        XmlSerializer writer = new XmlSerializer(typeof(Settings));
                        StreamWriter file = new StreamWriter(MainForm.PATH + @"\settings.xml");
                        writer.Serialize(file, MainForm.SETTINGS);
                        file.Close();
                        MainForm.PASSWORD = txtNew.Text;
                        MainForm.SETTINGS.HasPassword = !(txtNew.Text == "");
                        MessageBox.Show(MainForm.SETTINGS.HasPassword ? "密码已修改" : "已移除密码，请注意账号安全");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("两次密码输入不一致，请重新输入");
                }
            }
            else
            {
                MessageBox.Show("密码错误");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MainForm.PASSWORD = txtCurrent.Text;
            this.Close();
        }

    }
}
