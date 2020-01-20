using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application
{
    public partial class CreateForm : Form, IPopForm<string>
    {
        public CreateForm()
        {
            this.InitializeComponent();
        }

        public string Pop()
        {
            var res = this.ShowDialog();
            if (res == DialogResult.OK)
                return this.textBox1.Text;
            else
                return null;
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox3.Text != this.textBox2.Text)
            {
                this.label3.Text = "两次密码输入不同";
            }
            else
            {
                this.label3.Text = "";
            }
        }

        private void TextBox12_TextChanged(object sender, EventArgs e)
        {
            this.label3.Text = "";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var result = HttpApiHelper.Post<WebApiEntity.Account.CreateResult>("api/account/create", 
                new WebApiEntity.Account.AccountAndPassword() {
                Account = this.textBox1.Text,
                Password = this.textBox2.Text
            });
            switch(result)
            {
                case WebApiEntity.Account.CreateResult.Success:
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    return;
                case WebApiEntity.Account.CreateResult.OccupiedAccountName:
                    this.label3.Text = "用户名不可用（有重名）";
                    break;
                case WebApiEntity.Account.CreateResult.IllegalPassword:
                    this.label3.Text = "密码格式不正确";
                    break;
                case WebApiEntity.Account.CreateResult.IllegalAccountName:
                    this.label3.Text = "用户名格式不正确";
                    break;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
