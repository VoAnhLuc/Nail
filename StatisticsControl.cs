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
    public partial class StatisticsControl : UserControl
    {
        DBDataContext db;
        public StatisticsControl()
        {
            InitializeComponent();
        }

        private void StatisticsControl_Load(object sender, EventArgs e)
        {
            db = new DBDataContext();
            LoadStaff();
        }

        private void LoadStaff()
        {
            int totalRevenue = 0;
            int totalRevenueInMonth = 0;
            int totalCompletedWorks = 0;
            
            List<Staff> listStaff = (from s in db.Staffs
                                     select s).ToList<Staff>();
            int totalStaff = listStaff.Count;
            
            foreach(Staff staff in listStaff)
            {
                int total_money = 0;
                List<Work> listWorks = (from w in db.Works
                                        where w.staff_id == staff.id && w.status == 1
                                        select w).ToList<Work>();
                totalCompletedWorks += listWorks.Count;
                foreach (Work work in listWorks)
                {
                    Service service = (from s in db.Services
                                       where s.id == work.service_id
                                       select s).Single<Service>();
                    total_money += service.price.Value;
                    if (work.time.Value.Month == DateTime.Now.Month) totalRevenueInMonth += service.price.Value;
                }
                dgvStaffControl.Rows.Add(
                    new object[] {staff.id, staff.name, staff.email, total_money}
                    );
                totalRevenue += total_money;
            }

            int totalCustomers = (from c in db.Customers select c).Count();
            int totalServices = (from s in db.Services select s).Count();

            // push to label
            labelTotalStaff.Text = "Total Staff: " + totalStaff;
            labelTotalCustomers.Text = "Total Customers: " + totalCustomers;
            labelTotalServices.Text = "Total Services: " + totalServices;
            labelTotalRevenue.Text = "Total Revenue: " + totalRevenue;
            labelRevenueInMonth.Text = "Revenue in Month: " + totalRevenueInMonth;
            labelCompletedWorks.Text = "Completed Works: " + totalCompletedWorks;
        }

        private void dgvStaffControl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                MessageBox.Show("Xin lỗi, tụi mình chưa nghiên cứu kịp cái report nên chèn tạm dòng này vô. Sau này sẽ update sau :'(", "Thông cảm!");
            }
        }

        private void btnSearchStaff_Click(object sender, EventArgs e)
        {
            // load staff search
            List<Staff> listStaff = (from s in db.Staffs
                                     where s.name.Contains(txtKeyword.Text) || s.id.ToString() == txtKeyword.Text || s.email == txtKeyword.Text
                                     select s).ToList<Staff>();
            dgvStaffControl.Rows.Clear();
            foreach(Staff staff in listStaff)
            {
                int total_money = 0;
                List<Work> listWorks = (from w in db.Works
                                        where w.staff_id == staff.id && w.status == 1
                                        select w).ToList<Work>();
                foreach (Work work in listWorks)
                {
                    Service service = (from s in db.Services
                                       where s.id == work.service_id
                                       select s).Single<Service>();
                    total_money += service.price.Value;
                }
                dgvStaffControl.Rows.Add(
                        new object[] { staff.id, staff.name, staff.email, total_money }
                        );
            }
        }
    }
}
