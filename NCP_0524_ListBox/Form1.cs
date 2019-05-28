using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NCP_0524_ListBox
{
    public partial class Form1 : Form
    {
        string OrgStr = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.OrgStr = this.lblResult.Text;
            this.txtList.Focus();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            textCheck();
        }

        private void TxtList_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textCheck();
                e.Handled = true;
            }
        }

        private void textCheck()
        {
            if (this.txtList.Text == "")
            {
                MessageBox.Show("아이템을 입력하세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtList.Focus();
            }
            else
            {
                this.lbView.Items.Add(this.txtList.Text);
                this.txtList.Text = "";
                this.txtList.Focus();
            }
        }

        private void LbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lblResult.Text = this.OrgStr + this.lbView.SelectedItem.ToString();
        }
    }
}
