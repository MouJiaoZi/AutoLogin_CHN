namespace AutoLogin
{
    partial class AddEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditForm));
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkWindowed = new System.Windows.Forms.CheckBox();
            this.drpResolution = new System.Windows.Forms.ComboBox();
            this.chkCharacter = new System.Windows.Forms.CheckBox();
            this.lstCharacter = new System.Windows.Forms.ListBox();
            this.chkEnterWorld = new System.Windows.Forms.CheckBox();
            this.chkLowDetail = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.setWTF = new System.Windows.Forms.CheckBox();
            this.txtWTFPath = new System.Windows.Forms.TextBox();
            this.btnBrowseWTF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtName.Location = new System.Drawing.Point(66, 11);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(157, 23);
            this.txtName.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtEmail.Location = new System.Drawing.Point(66, 39);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(157, 23);
            this.txtEmail.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPassword.Location = new System.Drawing.Point(66, 67);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(157, 23);
            this.txtPassword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "显示名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(9, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "登录邮箱";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(9, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "登录密码";
            // 
            // chkWindowed
            // 
            this.chkWindowed.AutoSize = true;
            this.chkWindowed.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkWindowed.Location = new System.Drawing.Point(9, 97);
            this.chkWindowed.Name = "chkWindowed";
            this.chkWindowed.Size = new System.Drawing.Size(75, 21);
            this.chkWindowed.TabIndex = 6;
            this.chkWindowed.Text = "窗口模式";
            this.chkWindowed.UseVisualStyleBackColor = true;
            this.chkWindowed.CheckedChanged += new System.EventHandler(this.chkWindowed_CheckedChanged);
            // 
            // drpResolution
            // 
            this.drpResolution.DropDownHeight = 150;
            this.drpResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpResolution.DropDownWidth = 100;
            this.drpResolution.Enabled = false;
            this.drpResolution.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.drpResolution.FormattingEnabled = true;
            this.drpResolution.IntegralHeight = false;
            this.drpResolution.Location = new System.Drawing.Point(85, 95);
            this.drpResolution.Name = "drpResolution";
            this.drpResolution.Size = new System.Drawing.Size(138, 25);
            this.drpResolution.TabIndex = 7;
            // 
            // chkCharacter
            // 
            this.chkCharacter.AutoSize = true;
            this.chkCharacter.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkCharacter.Location = new System.Drawing.Point(238, 9);
            this.chkCharacter.Name = "chkCharacter";
            this.chkCharacter.Size = new System.Drawing.Size(99, 21);
            this.chkCharacter.TabIndex = 10;
            this.chkCharacter.Text = "选择指定角色";
            this.chkCharacter.UseVisualStyleBackColor = true;
            this.chkCharacter.CheckedChanged += new System.EventHandler(this.chkCharacter_CheckedChanged);
            // 
            // lstCharacter
            // 
            this.lstCharacter.Enabled = false;
            this.lstCharacter.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lstCharacter.FormattingEnabled = true;
            this.lstCharacter.ItemHeight = 17;
            this.lstCharacter.Items.AddRange(new object[] {
            "第1位",
            "第2位",
            "第3位",
            "第4位",
            "第5位",
            "第6位",
            "第7位",
            "第8位",
            "第9位",
            "第10位",
            "第11位",
            "第12位"});
            this.lstCharacter.Location = new System.Drawing.Point(238, 30);
            this.lstCharacter.Name = "lstCharacter";
            this.lstCharacter.Size = new System.Drawing.Size(222, 89);
            this.lstCharacter.TabIndex = 11;
            this.lstCharacter.SelectedIndexChanged += new System.EventHandler(this.lstCharacter_SelectedIndexChanged);
            // 
            // chkEnterWorld
            // 
            this.chkEnterWorld.AutoSize = true;
            this.chkEnterWorld.Enabled = false;
            this.chkEnterWorld.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkEnterWorld.Location = new System.Drawing.Point(333, 9);
            this.chkEnterWorld.Name = "chkEnterWorld";
            this.chkEnterWorld.Size = new System.Drawing.Size(135, 21);
            this.chkEnterWorld.TabIndex = 12;
            this.chkEnterWorld.Text = "直接读蓝条进入游戏";
            this.chkEnterWorld.UseVisualStyleBackColor = true;
            // 
            // chkLowDetail
            // 
            this.chkLowDetail.AutoSize = true;
            this.chkLowDetail.Enabled = false;
            this.chkLowDetail.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkLowDetail.Location = new System.Drawing.Point(9, 159);
            this.chkLowDetail.Name = "chkLowDetail";
            this.chkLowDetail.Size = new System.Drawing.Size(87, 21);
            this.chkLowDetail.TabIndex = 20;
            this.chkLowDetail.Text = "低画质启动";
            this.chkLowDetail.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Location = new System.Drawing.Point(104, 155);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(175, 28);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.Location = new System.Drawing.Point(285, 155);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(175, 28);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "取消";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // setWTF
            // 
            this.setWTF.AutoSize = true;
            this.setWTF.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.setWTF.Location = new System.Drawing.Point(9, 128);
            this.setWTF.Name = "setWTF";
            this.setWTF.Size = new System.Drawing.Size(100, 21);
            this.setWTF.TabIndex = 23;
            this.setWTF.Text = "指定WTF文件";
            this.setWTF.UseVisualStyleBackColor = true;
            this.setWTF.CheckedChanged += new System.EventHandler(this.setWTF_CheckedChanged);
            // 
            // txtWTFPath
            // 
            this.txtWTFPath.Enabled = false;
            this.txtWTFPath.Location = new System.Drawing.Point(113, 128);
            this.txtWTFPath.Name = "txtWTFPath";
            this.txtWTFPath.Size = new System.Drawing.Size(285, 21);
            this.txtWTFPath.TabIndex = 24;
            this.txtWTFPath.Text = "当私服未使用默认config.WTF时使用本选项";
            // 
            // btnBrowseWTF
            // 
            this.btnBrowseWTF.Enabled = false;
            this.btnBrowseWTF.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBrowseWTF.Location = new System.Drawing.Point(409, 126);
            this.btnBrowseWTF.Margin = new System.Windows.Forms.Padding(0);
            this.btnBrowseWTF.Name = "btnBrowseWTF";
            this.btnBrowseWTF.Size = new System.Drawing.Size(51, 25);
            this.btnBrowseWTF.TabIndex = 25;
            this.btnBrowseWTF.Text = "浏览";
            this.btnBrowseWTF.UseVisualStyleBackColor = true;
            this.btnBrowseWTF.Click += new System.EventHandler(this.btnBrowseWTF_Click);
            // 
            // AddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 194);
            this.ControlBox = false;
            this.Controls.Add(this.btnBrowseWTF);
            this.Controls.Add(this.txtWTFPath);
            this.Controls.Add(this.setWTF);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkLowDetail);
            this.Controls.Add(this.chkEnterWorld);
            this.Controls.Add(this.lstCharacter);
            this.Controls.Add(this.chkCharacter);
            this.Controls.Add(this.drpResolution);
            this.Controls.Add(this.chkWindowed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddEditForm";
            this.Load += new System.EventHandler(this.AddEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkWindowed;
        private System.Windows.Forms.ComboBox drpResolution;
        private System.Windows.Forms.CheckBox chkCharacter;
        private System.Windows.Forms.ListBox lstCharacter;
        private System.Windows.Forms.CheckBox chkEnterWorld;
        private System.Windows.Forms.CheckBox chkLowDetail;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox setWTF;
        private System.Windows.Forms.TextBox txtWTFPath;
        private System.Windows.Forms.Button btnBrowseWTF;
    }
}