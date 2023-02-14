using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoLogin
{
    public partial class AddEditForm : Form
    {
        Account account;
        MainForm mForm;
        GetResolution getRes;
        int addEdit;

        public AddEditForm()
        {
            InitializeComponent();
        }

        public void ShowMe(MainForm parent, int addEdit, Account account = null)
        {
            if (addEdit == 0)
            {
                this.Text = "新增账号";
            }
            else
            {
                this.Text = "编辑账号";
            }
            this.account = account;
            this.addEdit = addEdit;
            mForm = parent;
            this.ShowDialog(parent);
        }

        private void AddEditForm_Load(object sender, EventArgs e)
        {
            getRes = new GetResolution();
            lstCharacter.SelectedIndex = 0;

            drpResolution.DataSource = getRes.list;

            if (account != null)
            {
                try
                {
                    txtName.Text = account.Name;
                    txtEmail.Text = account.Email;
                    txtPassword.Text = account.Password;
                    chkWindowed.Checked = account.Windowed;
                    drpResolution.SelectedItem = account.Resolution;
                    chkLowDetail.Checked = account.LowDetail;
                    chkCharacter.Checked = account.SetCharacter;
                    lstCharacter.SelectedIndex = account.CharacterSlot;
                    chkEnterWorld.Checked = account.EnterWorld;
                    setWTF.Checked = account.SetWTF;
                    txtWTFPath.Text = account.WTFPath;
                }
                catch (Exception) { }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // If this fails the email is not valid
                new MailAddress(txtEmail.Text);

                // Check if password is entered
                if (txtPassword.Text == "")
                {
                    MessageBox.Show("请输入密码");
                }
                else
                {
                    // If no name set use email address
                    if (txtName.Text == "")
                    {
                        txtName.Text = txtEmail.Text;
                    }

                    // If "adding" create a new account
                    if (account == null)
                    {
                        account = new Account();
                        MainForm.ACCOUNTS.Add(account);
                    }

                    // Save all account information to account object
                    account.Name = txtName.Text;
                    account.Email = txtEmail.Text;
                    account.Password = txtPassword.Text;
                    account.Windowed = chkWindowed.Checked;
                    account.Resolution = drpResolution.Text;
                    account.LowDetail = chkLowDetail.Checked;
                    account.SetCharacter = chkCharacter.Checked;
                    account.CharacterSlot = lstCharacter.SelectedIndex;
                    account.EnterWorld = chkEnterWorld.Checked;
                    account.SetWTF = setWTF.Checked;
                    account.WTFPath = txtWTFPath.Text;
                    mForm.refreshList(addEdit);
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("登录邮箱无效");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkWindowed_CheckedChanged(object sender, EventArgs e)
        {
            drpResolution.Enabled = chkWindowed.Checked ? true : false;
            drpResolution.SelectedIndex = 0;
            chkLowDetail.Enabled = chkWindowed.Checked ? true : false;
        }

        private void chkCharacter_CheckedChanged(object sender, EventArgs e)
        {
            lstCharacter.Enabled = chkCharacter.Checked ? true : false;
            chkEnterWorld.Enabled = chkCharacter.Checked ? true : false;
        }

        private void lstCharacter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void setWTF_CheckedChanged(object sender, EventArgs e)
        {
            txtWTFPath.Enabled = setWTF.Checked ? true : false;
            btnBrowseWTF.Enabled = setWTF.Checked ? true : false;
        }

        private void btnBrowseWTF_Click(object sender, EventArgs e)
        {
            // Open new folder browser dialog
            OpenFileDialog fbd = new OpenFileDialog();
            fbd.Multiselect = false;
            fbd.Title = "请选择要启动的魔兽世界可执行程序";
            fbd.Filter = "全局WTF文件(*.wtf)|*.wtf";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtWTFPath.Text = fbd.FileName;
            }
        }
    }
}
