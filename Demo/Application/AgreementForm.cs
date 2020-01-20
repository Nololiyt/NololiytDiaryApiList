using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application
{
    public partial class AgreementForm : Form, IPopForm<string>
    {
        private readonly WebApiEntity.Account.Agreement agreement;
        public AgreementForm()
        {
            this.InitializeComponent();

            this.agreement = HttpApiHelper.Get<WebApiEntity.Account.Agreement>("api/about/agreement");
            this.textBox1.Text = this.agreement.Body;
        }

        public string Pop()
        {
            var res = this.ShowDialog();
            if (res == DialogResult.OK)
                return this.agreement.Version;
            else
                return null;
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.button1.Enabled = this.checkBox1.Checked;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}