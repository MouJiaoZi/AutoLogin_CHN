using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace AutoLogin
{
    public partial class SettingsForm : Form
    {
        MainForm mForm = new MainForm();

        public SettingsForm()
        {
            InitializeComponent();
        }

        public void ShowMe(MainForm parent)
        {
            mForm = parent;
            this.ShowDialog(parent);
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            // Load from settings
            txtWowPath.Text = MainForm.SETTINGS.WowPath;
            chkMinimize.Checked = MainForm.SETTINGS.Minimize;
            chkHide.Checked = MainForm.SETTINGS.Hide;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Check to see if Wow.exe exists in the selected folder
            if (!File.Exists(txtWowPath.Text))
            {
                MessageBox.Show("未找到魔兽世界可执行程序，请指定程序目录。");
            }
            else
            {
                MainForm.SETTINGS.WowPath = txtWowPath.Text;
                MainForm.SETTINGS.Minimize = chkMinimize.Checked;
                MainForm.SETTINGS.Hide = chkHide.Checked;
                mForm.SaveSettings();
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // Open new folder browser dialog
            OpenFileDialog fbd = new OpenFileDialog();
            fbd.Multiselect = false;
            fbd.Title = "请选择要启动的魔兽世界可执行程序";
            fbd.Filter = "可执行程序(*.exe)|*.exe";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtWowPath.Text = fbd.FileName;
            }
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            new PasswordForm().ShowDialog(this);
        }
    }
}
