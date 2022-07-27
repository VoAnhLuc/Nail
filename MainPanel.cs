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
    public partial class FairyNailsForm : Form
    {
        DBDataContext db;
        public FairyNailsForm()
        {
            InitializeComponent();
            db = new DBDataContext();
            btnWorks.BackColor = Color.FromArgb(57, 80, 88);
            accessControl1.BringToFront();

        }

        private void tabProcessingMain_Enter(object sender, EventArgs e)
        {
            // check exist work
            if (subProcessingMainPanel.Controls.Count != 0) subProcessingMainPanel.Controls.Clear();

            List<Work> works = (from work in db.Works
                                where work.status == 0
                                select work).ToList<Work>();
            foreach (Work work in works)
                subProcessingMainPanel.Controls.Add(new WorkControl(work.id, work.customer_id.Value, work.time.Value));
        }

        private void tabCompletedMain_Enter(object sender, EventArgs e)
        {
            // check exist work
            if (subCompletedMainPanel.Controls.Count != 0) subCompletedMainPanel.Controls.Clear();

            List<Work> works = (from work in db.Works
                                where work.status == 1
                                select work).ToList<Work>();
            foreach (Work work in works)
                subCompletedMainPanel.Controls.Add(new WorkControl(work.id, work.customer_id.Value, work.time.Value));
        }

        private void tabCancelledMain_Enter(object sender, EventArgs e)
        {
            // check exist work
            if (subCancelledMainPanel.Controls.Count != 0) subCancelledMainPanel.Controls.Clear();

            List<Work> works = (from work in db.Works
                                where work.status == 2
                                select work).ToList<Work>();
            foreach (Work work in works)
                subCancelledMainPanel.Controls.Add(new WorkControl(work.id, work.customer_id.Value, work.time.Value));
        }

        private void iconService_Click(object sender, EventArgs e)
        {
            //servicesControl1.BringToFront();
        }

        private void FairyNailsForm_Load(object sender, EventArgs e)
        {
            List<Work> works = (from work in db.Works
                                select work).ToList<Work>();
            foreach (Work work in works)
                mainPanel.Controls.Add(new WorkControl(work.id, work.customer_id.Value, work.time.Value));
        }

        private void btnWorks_Click(object sender, EventArgs e)
        {
            // check pass jump
            if (!accessControl1.jumpSuccess) return;

            // set backcolor
            btnWorks.BackColor = Color.FromArgb(57, 80, 88);
            btnServices.BackColor = Color.FromArgb(26, 37, 39);
            btnCustomers.BackColor = Color.FromArgb(26, 37, 39); 
            btnStaff.BackColor = Color.FromArgb(26, 37, 39);
            btnStatistics.BackColor = Color.FromArgb(26, 37, 39);

            // hide all controls
            servicesControl1.SendToBack();
            customersControl1.SendToBack();
            staffControl1.SendToBack();
            statisticsControl1.SendToBack();
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            // check pass jump
            if (!accessControl1.jumpSuccess) return;

            // set backcolor
            btnServices.BackColor = Color.FromArgb(57, 80, 88);
            btnWorks.BackColor = Color.FromArgb(26, 37, 39);
            btnCustomers.BackColor = Color.FromArgb(26, 37, 39);
            btnStaff.BackColor = Color.FromArgb(26, 37, 39);
            btnStatistics.BackColor = Color.FromArgb(26, 37, 39);

            // show control
            servicesControl1.BringToFront();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            // check pass jump
            if (!accessControl1.jumpSuccess) return;

            // set backcolor
            btnCustomers.BackColor = Color.FromArgb(57, 80, 88);
            btnServices.BackColor = Color.FromArgb(26, 37, 39);
            btnWorks.BackColor = Color.FromArgb(26, 37, 39);
            btnStaff.BackColor = Color.FromArgb(26, 37, 39);
            btnStatistics.BackColor = Color.FromArgb(26, 37, 39);

            // show control
            customersControl1.BringToFront();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            // check pass jump
            if (!accessControl1.jumpSuccess) return;
            
            // set backcolor
            btnStaff.BackColor = Color.FromArgb(57, 80, 88);
            btnServices.BackColor = Color.FromArgb(26, 37, 39);
            btnWorks.BackColor = Color.FromArgb(26, 37, 39);
            btnCustomers.BackColor = Color.FromArgb(26, 37, 39);
            btnStatistics.BackColor = Color.FromArgb(26, 37, 39);

            // show control
            staffControl1.BringToFront();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?","Dont Leave :'((", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            // check pass jump
            if (!accessControl1.jumpSuccess) return;

            // set backcolor
            btnStatistics.BackColor = Color.FromArgb(57, 80, 88);
            btnStaff.BackColor = Color.FromArgb(26, 37, 39);
            btnServices.BackColor = Color.FromArgb(26, 37, 39);
            btnWorks.BackColor = Color.FromArgb(26, 37, 39);
            btnCustomers.BackColor = Color.FromArgb(26, 37, 39);

            // show control
            statisticsControl1.BringToFront();
        }
    }
}
