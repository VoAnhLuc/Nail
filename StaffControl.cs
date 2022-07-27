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
    public partial class StaffControl : UserControl
    {
        DBDataContext db;
        int staffId;
        public StaffControl()
        {
            InitializeComponent();
        }
        private void StaffControl_Load(object sender, EventArgs e)
        {
            db = new DBDataContext();
            LoadStaff();
        }
        private void LoadStaff()
        {
            var listStaff = from s in db.Staffs
                            select new { s.id, s.name, s.sex, s.birthday, s.cellphone, s.email, s.address};
            dgvStaffControl.DataSource = null;
            dgvStaffControl.DataSource = listStaff;
        }

        private void dgvStaffControl_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            // push data from dgv on textbox
            staffId = Convert.ToInt32(dgvStaffControl[0, e.RowIndex].Value);
            txtFullName.Text = dgvStaffControl[1, e.RowIndex].Value.ToString();
            txtGender.Text = (dgvStaffControl[2, e.RowIndex].Value.ToString() == "True" ? "Male" : "Female");
            txtBirthday.Text = dgvStaffControl[3, e.RowIndex].Value.ToString();
            txtCellphone.Text = dgvStaffControl[4, e.RowIndex].Value.ToString();
            txtEmail.Text = dgvStaffControl[5, e.RowIndex].Value.ToString();
            txtAddress.Text = dgvStaffControl[6, e.RowIndex].Value.ToString();
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận thêm?", "Add Staff", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Staff staff = new Staff();
                staff.name = txtFullName.Text;
                staff.sex = (txtGender.Text == "Male" ? true : false);
                staff.birthday = txtBirthday.Value;
                staff.cellphone = txtCellphone.Text;
                staff.email = txtEmail.Text;
                staff.address = txtAddress.Text;
                db.Staffs.InsertOnSubmit(staff);
                db.SubmitChanges();
                LoadStaff();
            }
        }

        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận sửa?", "Edit Staff", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Staff staff = (from c in db.Staffs
                               where c.id == staffId
                               select c).Single<Staff>();
                staff.name = txtFullName.Text;
                staff.sex = (txtGender.Text == "Male" ? true : false);
                staff.birthday = txtBirthday.Value;
                staff.cellphone = txtCellphone.Text;
                staff.email = txtEmail.Text;
                staff.address = txtAddress.Text;
                db.SubmitChanges();
                LoadStaff();
            }
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận sửa?", "Edit Staff", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Staff staff = (from c in db.Staffs
                               where c.id == staffId
                               select c).Single<Staff>();
                db.Staffs.DeleteOnSubmit(staff);
                db.SubmitChanges();
                LoadStaff();
            }
        }

        private void btnSearchStaff_Click(object sender, EventArgs e)
        {
            // load staff search
            var listStaff = from s in db.Staffs
                                where s.name.Contains(txtKeyword.Text) || s.id.ToString() == txtKeyword.Text
                                select new { s.id, s.name, s.sex, s.birthday, s.cellphone, s.email, s.address };
            dgvStaffControl.DataSource = null;
            dgvStaffControl.DataSource = listStaff;
        }

    }
}
