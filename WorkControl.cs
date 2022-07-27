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
    public partial class WorkControl : UserControl
    {
        int workId;
        public WorkControl()
        {
            InitializeComponent();
        }
        public WorkControl(int id, int customer_id, DateTime time)
        {
            InitializeComponent();
            DBDataContext db = new DBDataContext();
            Customer customer = (from cus in db.Customers
                                 where cus.id == customer_id
                                 select cus).Single<Customer>();

            userId.Text = "ID: " + customer_id.ToString();
            userName.Text = customer.name;
            userPhone.Text = customer.cellphone;
            userSex.ImageLocation = "../../Icons/Gender/" + (Convert.ToBoolean(customer.sex) ? 1 : 0) + ".png";
            userYearsOld.Text = (DateTime.Now.Year - customer.birthday.Value.Year).ToString();
            workDate.Text = time.Date.ToShortDateString();
            workTime.Text = time.TimeOfDay.ToString();
            workId = id;
        }

        private void btnDetailWorkControl_Click(object sender, EventArgs e)
        {
            ViewDetailWorkControl dc = new ViewDetailWorkControl(workId);
            dc.Show();
        }
    }
}
