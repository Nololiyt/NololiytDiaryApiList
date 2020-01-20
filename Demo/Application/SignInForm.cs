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
    public partial class SignInForm : Form, IPopForm<bool?>
    {
        public SignInForm()
        {
            this.InitializeComponent();
        }
        public bool? Pop()
        {
            var res = this.ShowDialog();
            if (res == DialogResult.OK)
                return true;
            else
                return null;
        }

        private WebApiEntity.Account.SignInResult Send(string agrHash)
        {
            return HttpApiHelper.Post<WebApiEntity.Account.SignInResult>("api/account/signin", new WebApiEntity.Account.ValueCombinedWithAgreementVersion<
                    WebApiEntity.Account.AccountAndPassword>() {
                AgreementVersion = agrHash,
                CombinedValue = new WebApiEntity.Account.AccountAndPassword() {
                    Account = this.textBox1.Text,
                    Password = this.textBox2.Text
                }
            });
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            WebApiEntity.Account.SignInResult result;
            for (string agr = null; ; agr = new AgreementForm().Pop())
            {
                result = this.Send(agr);
                if (result != WebApiEntity.Account.SignInResult.WrongAgreementHash)
                {
                    break;
                }
            }
            if (result == WebApiEntity.Account.SignInResult.WrongAccountOrPassword)
            {
                this.label3.Text = "用户名密码错误";
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            this.label3.Text = "";
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            this.label3.Text = "";
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var r = new CreateForm().Pop();
            if (r != null)
            {
                this.textBox1.Text = r;
            }
        }
    }
}
