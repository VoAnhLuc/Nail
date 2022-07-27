using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FairyNails
{
    public partial class AccessControl : UserControl
    {
        readonly string serectCode = "1001";
        public bool jumpSuccess = false;
        public AccessControl()
        {
            InitializeComponent();
        }

        private void btnJump_Click(object sender, EventArgs e)
        {
            if (serectCode == txtCode.Text)
            {
                this.Hide();
                jumpSuccess = true;
            }
        }
    }
}
