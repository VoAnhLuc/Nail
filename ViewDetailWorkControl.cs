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
    public partial class ViewDetailWorkControl : Form
    {
        int workId;
        DBDataContext db;
        public ViewDetailWorkControl()
        {
            InitializeComponent();
        }
        public ViewDetailWorkControl(int id)
        {
            InitializeComponent();
            workId = id;
            LoadingData();
        }
        private void LoadingData()
        {
            db = new DBDataContext();
            Work work = (from w in db.Works
                         where w.id == workId
                         select w).Single<Work>();
            Service service = (from s in db.Services
                               where s.id == work.service_id
                               select s).Single<Service>();
            Customer customer = (from c in db.Customers
                                 where c.id == work.customer_id
                                 select c).Single<Customer>();
            Staff staff = (from s in db.Staffs
                           where s.id == work.staff_id
                           select s).Single<Staff>();

            // push to label
            nameOfService.Text = service.name;
            nameOfStaff.Text = staff.name;
            servicePrice.Text = service.price.ToString();

            // status of work
            statusOfWork.Text = (work.status == 0 ? "Processing" : (work.status == 1 ? "Completed" : "Cancelled"));
            statusOfWork.ForeColor = (work.status == 0 ? Color.SeaGreen : (work.status == 1 ? Color.Firebrick : Color.Gray));

            // if Completed or Cancelled then hidden all button
            if (work.status == 1 || work.status == 2)
            {
                btnCancelDetail.Visible = false;
                btnEditDetail.Visible = false;
                btnCompleteDetail.Visible = false;
            }

            // customer information
            userId.Text = "ID: " + customer.id.ToString();
            userName.Text = customer.name;
            userPhone.Text = customer.cellphone;
            userSex.ImageLocation = "../../Icons/Gender/" + (Convert.ToBoolean(customer.sex) ? 1 : 0) + ".png";
            userYearsOld.Text = (DateTime.Now.Year - customer.birthday.Value.Year).ToString();

            // datetime of work
            workDate.Text = work.time.Value.Date.ToShortDateString();
            workTime.Text = work.time.Value.TimeOfDay.ToString();

            // load data to textbox (for "edit")
            var listStaff = from s in db.Staffs
                            select s;
            var listServices = from s in db.Services
                               select s;

            txtStaffDetail.DataSource = listStaff.ToList<Staff>();
            txtStaffDetail.DisplayMember = "name";
            txtStaffDetail.ValueMember = "id";

            txtServiceDetail.DataSource = listServices.ToList<Service>();
            txtServiceDetail.DisplayMember = "name";
            txtServiceDetail.ValueMember = "id";

            txtServiceDetail.SelectedValue = work.service_id;
            txtStaffDetail.SelectedValue = work.staff_id;
        }

        private void btnEditDetail_Click(object sender, EventArgs e)
        {
            // hidden all button
            btnCancelDetail.Visible = false;
            btnEditDetail.Visible = false;
            btnCompleteDetail.Visible = false;

            // show everthing about edit detail
            btnSaveDetail.Visible = true;
            txtServiceDetail.Visible = true;
            txtStaffDetail.Visible = true;
        }

        private void txtServiceDetail_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int service_id = Convert.ToInt32(Convert.ToString(txtServiceDetail.SelectedValue));
            Service service = (from s in db.Services
                               where s.id == service_id
                               select s).Single<Service>();
            servicePrice.Text = service.price.ToString();
        }

        private void btnSaveDetail_Click(object sender, EventArgs e)
        {
            // update data
            Work work = (from w in db.Works
                         where w.id == workId
                         select w).Single<Work>();
            work.service_id = Convert.ToInt32(txtServiceDetail.SelectedValue);
            work.staff_id = Convert.ToInt32(txtStaffDetail.SelectedValue);
            db.SubmitChanges();
            MessageBox.Show("Chỉnh sửa thành công");

            // show all button
            btnCancelDetail.Visible = true;
            btnEditDetail.Visible = true;
            btnCompleteDetail.Visible = true;

            // hidden everthing about edit detail
            btnSaveDetail.Visible = false;
            txtServiceDetail.Visible = false;
            txtStaffDetail.Visible = false;

            LoadingData();
        }

        private void btnCompleteDetail_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Chắc chắn đã hoàn thành?", "Complete", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                // update data
                Work work = (from w in db.Works
                             where w.id == workId
                             select w).Single<Work>();
                work.status = 1;
                db.SubmitChanges();
                LoadingData();
            }
        }

        private void btnCancelDetail_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Có chắc muốn hủy?", "Cancel", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                // update data
                Work work = (from w in db.Works
                             where w.id == workId
                             select w).Single<Work>();
                work.status = 2;
                db.SubmitChanges();
                LoadingData();
            }
        }

        private void timerFadeIn_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1) timerFadeIn.Stop();
            Opacity += .2;
        }
    }
}
