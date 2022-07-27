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
    public partial class CustomersControl : UserControl
    {
        DBDataContext db;
        int customerId;
        public CustomersControl()
        {
            InitializeComponent();
        }
        private void CustomersControl_Load(object sender, EventArgs e)
        {
            db = new DBDataContext();
            LoadCustomers();
        }
        private void LoadCustomers()
        {
            // load khách hàng
            var listCustomers = from c in db.Customers
                               select new { c.id, c.name, c.sex, c.birthday, c.cellphone };
            dgvCustomersControl.DataSource = null;
            dgvCustomersControl.DataSource = listCustomers;
        }

        private void dgvCustomersControl_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            // push data from dgv on textbox
            txtFullName.Text = dgvCustomersControl[1, e.RowIndex].Value.ToString();
            txtGender.Text = (dgvCustomersControl[2, e.RowIndex].Value.ToString() == "True" ? "Male" : "Female");
            txtBirthdayCustomer.Text = dgvCustomersControl[3, e.RowIndex].Value.ToString();
            txtCellphone.Text = dgvCustomersControl[4, e.RowIndex].Value.ToString();
            customerId = Convert.ToInt32(dgvCustomersControl[0, e.RowIndex].Value);
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận thêm?", "Add Customer", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Customer customer = new Customer();
                customer.name = txtFullName.Text;
                customer.sex = (txtGender.Text == "Male" ? true : false);
                customer.birthday = txtBirthdayCustomer.Value;
                customer.cellphone = txtCellphone.Text;
                db.Customers.InsertOnSubmit(customer);
                db.SubmitChanges();
                LoadCustomers();
            }
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận sửa?", "Edit Customer", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Customer customer = (from c in db.Customers
                                     where c.id == customerId
                                     select c).Single<Customer>();
                customer.name = txtFullName.Text;
                customer.sex = (txtGender.Text == "Male" ? true : false);
                customer.birthday = txtBirthdayCustomer.Value;
                customer.cellphone = txtCellphone.Text;
                db.SubmitChanges();
                LoadCustomers();
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận sửa?", "Edit Customer", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Customer customer = (from c in db.Customers
                                     where c.id == customerId
                                     select c).Single<Customer>();
                db.Customers.DeleteOnSubmit(customer);
                db.SubmitChanges();
                LoadCustomers();
            }
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            // load khách hàng
            var listCustomers = from c in db.Customers
                                where c.name.Contains(txtKeyword.Text) || c.id.ToString() == txtKeyword.Text
                                select new { c.id, c.name, c.sex, c.birthday, c.cellphone };
            dgvCustomersControl.DataSource = null;
            dgvCustomersControl.DataSource = listCustomers;
        }

    }
}
