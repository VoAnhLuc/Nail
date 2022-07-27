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
    public partial class ServicesControl : UserControl
    {
        DBDataContext db;
        int serviceId;
        int typeofserviceId;
        public ServicesControl()
        {
            InitializeComponent();
        }

        private void ServicesControl_Load(object sender, EventArgs e)
        {
            db = new DBDataContext();
            LoadServices();
            LoadTypeOfServices();
        }
        private void LoadServices()
        {
            // load dịch vụ
            var listServices = from s in db.Services
                               select new { s.id, s.name, s.type, s.price };
            dgvServicesControl.DataSource = null;
            dgvServicesControl.DataSource = listServices;
        }
        private void LoadTypeOfServices()
        {
            // load loại dịch vụ
            var listTypeOfServices = from s in db.ServiceTypes
                                     select new { s.id, s.name };
            dgvTypeOfServices.DataSource = null;
            dgvTypeOfServices.DataSource = listTypeOfServices;
            txtTypeService.DataSource = listTypeOfServices;
            txtTypeService.DisplayMember = "name";
            txtTypeService.ValueMember = "id";
        }

        private void dgvServicesControl_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            // push data on textbox
            txtNameService.Text = dgvServicesControl.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtTypeService.SelectedValue = dgvServicesControl.Rows[e.RowIndex].Cells[2].Value;
            txtPriceService.Text = dgvServicesControl.Rows[e.RowIndex].Cells[3].Value.ToString();
            serviceId = Convert.ToInt32(dgvServicesControl.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận thêm?", "Add Service", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Service service = new Service();
                service.name = txtNameService.Text;
                service.type = Convert.ToInt32(txtTypeService.SelectedValue);
                service.price = Convert.ToInt32(txtPriceService.Text);
                db.Services.InsertOnSubmit(service);
                db.SubmitChanges();
                LoadServices();
            }
        }

        private void btnEditService_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận sửa?", "Edit Service", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Service service = (from s in db.Services
                                   where s.id == serviceId
                                   select s).Single<Service>();
                service.name = txtNameService.Text;
                service.type = Convert.ToInt32(txtTypeService.SelectedValue);
                service.price = Convert.ToInt32(txtPriceService.Text);
                db.SubmitChanges();
                LoadServices();
            }
        }

        private void btnDeleteServices_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Delete Service", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Service service = (from s in db.Services
                                   where s.id == serviceId
                                   select s).Single<Service>();
                db.Services.DeleteOnSubmit(service);
                db.SubmitChanges();
                LoadServices();
            }
        }

        private void btnSearchService_Click(object sender, EventArgs e)
        {
            // search by name or id
            var listServices = from s in db.Services
                               where s.name.Contains(txtKeyword.Text) || s.id.ToString() == txtKeyword.Text
                               select new { s.id, s.name, s.type, s.price };
            dgvServicesControl.DataSource = null;
            dgvServicesControl.DataSource = listServices;
        }

        private void dgvTypeOfServices_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            // push data on textbox
            txtNameTypeOfServices.Text = dgvTypeOfServices[1, e.RowIndex].Value.ToString();
            typeofserviceId = Convert.ToInt32(dgvTypeOfServices[0, e.RowIndex].Value.ToString());
        }

        private void btnAddTypeOfServices_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận thêm?", "Add Type of Service", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                ServiceType type = new ServiceType();
                type.name = txtNameTypeOfServices.Text;
                db.ServiceTypes.InsertOnSubmit(type);
                db.SubmitChanges();
                LoadTypeOfServices();
            }
        }

        private void btnEditTypeOfServices_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận sửa?", "Edit Type of Service", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                ServiceType type = (from s in db.ServiceTypes
                                    where s.id == typeofserviceId
                                    select s).Single<ServiceType>();
                type.name = txtNameTypeOfServices.Text;
                db.SubmitChanges();
                LoadTypeOfServices();
            }
        }

        private void btnDeleteTypeOfServices_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận sửa?", "Edit Type of Service", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                ServiceType type = (from s in db.ServiceTypes
                                    where s.id == typeofserviceId
                                    select s).Single<ServiceType>();
                db.ServiceTypes.DeleteOnSubmit(type);
                db.SubmitChanges();
                LoadTypeOfServices();
            }
        }

    }
}
