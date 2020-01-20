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
using WebApiEntity.Account;
using WebApiEntity.Diary;

namespace Application
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            this.InitializeComponent();
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            this.SignIn();
        }
        private void SignIn()
        {
            for (; ; )
            {
                var r = new SignInForm().Pop();
                if (!r.HasValue)
                {
                    this.Close();
                    break;
                }
                else if (r.Value == true)
                {
                    this.RefreshAccountInfo(); break;
                }
            }
        }

        private void RefreshAccountInfo()
        {
            var result = HttpApiHelper.Get<AccountInfo>("api/account/current");
            this.textBox1.Text = result.BasicAccountInfo.NickName;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            var result = HttpApiHelper.Post<bool>("api/account/setbasicinfo", new BasicAccountInfo() { NickName = this.textBox1.Text });
            if(!result)
            {
                this.label2.Text = "修改失败。";
            }
            this.label2.Text = "";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var result = HttpApiHelper.Post<DiaryAddResult>("api/diaries/add", this.textBox2.Text);
            if(result == DiaryAddResult.Success)
            {
                this.textBox2.Text = "";
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var result = HttpApiHelper.Post<DiaryInfo[]>("api/diaries/getbytime", new PageFactor() {
                Count = int.Parse(this.textBox4.Text), PageIndex = int.Parse(this.textBox3.Text)
            });
            foreach(var r in result)
            {
                r.UpdateTime = r.UpdateTime.ToLocalTime();
            }
            this.dataGridView1.DataSource = result;
        }
    }
}
