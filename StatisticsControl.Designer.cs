
namespace FairyNails
{
    partial class StatisticsControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticsControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearchStaff = new System.Windows.Forms.Button();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.labelTotalServices = new System.Windows.Forms.Label();
            this.labelTotalCustomers = new System.Windows.Forms.Label();
            this.labelTotalStaff = new System.Windows.Forms.Label();
            this.labelCompletedWorks = new System.Windows.Forms.Label();
            this.labelRevenueInMonth = new System.Windows.Forms.Label();
            this.labelTotalRevenue = new System.Windows.Forms.Label();
            this.dgvStaffControl = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printStaff = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSearchStaff);
            this.panel1.Controls.Add(this.txtKeyword);
            this.panel1.Controls.Add(this.labelTotalServices);
            this.panel1.Controls.Add(this.labelTotalCustomers);
            this.panel1.Controls.Add(this.labelTotalStaff);
            this.panel1.Controls.Add(this.labelCompletedWorks);
            this.panel1.Controls.Add(this.labelRevenueInMonth);
            this.panel1.Controls.Add(this.labelTotalRevenue);
            this.panel1.Controls.Add(this.dgvStaffControl);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 692);
            this.panel1.TabIndex = 2;
            // 
            // btnSearchStaff
            // 
            this.btnSearchStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.btnSearchStaff.FlatAppearance.BorderSize = 0;
            this.btnSearchStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnSearchStaff.Location = new System.Drawing.Point(863, 232);
            this.btnSearchStaff.Name = "btnSearchStaff";
            this.btnSearchStaff.Size = new System.Drawing.Size(75, 27);
            this.btnSearchStaff.TabIndex = 40;
            this.btnSearchStaff.Text = "Search";
            this.btnSearchStaff.UseVisualStyleBackColor = false;
            this.btnSearchStaff.Click += new System.EventHandler(this.btnSearchStaff_Click);
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(592, 232);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(265, 27);
            this.txtKeyword.TabIndex = 39;
            // 
            // labelTotalServices
            // 
            this.labelTotalServices.AutoSize = true;
            this.labelTotalServices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.labelTotalServices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTotalServices.Location = new System.Drawing.Point(169, 174);
            this.labelTotalServices.Name = "labelTotalServices";
            this.labelTotalServices.Size = new System.Drawing.Size(122, 20);
            this.labelTotalServices.TabIndex = 38;
            this.labelTotalServices.Text = "Total Services: 50";
            this.labelTotalServices.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotalCustomers
            // 
            this.labelTotalCustomers.AutoSize = true;
            this.labelTotalCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.labelTotalCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTotalCustomers.Location = new System.Drawing.Point(169, 133);
            this.labelTotalCustomers.Name = "labelTotalCustomers";
            this.labelTotalCustomers.Size = new System.Drawing.Size(154, 20);
            this.labelTotalCustomers.TabIndex = 37;
            this.labelTotalCustomers.Text = "Total Customers: 1500";
            this.labelTotalCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotalStaff
            // 
            this.labelTotalStaff.AutoSize = true;
            this.labelTotalStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.labelTotalStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTotalStaff.Location = new System.Drawing.Point(169, 95);
            this.labelTotalStaff.Name = "labelTotalStaff";
            this.labelTotalStaff.Size = new System.Drawing.Size(101, 20);
            this.labelTotalStaff.TabIndex = 36;
            this.labelTotalStaff.Text = "Total Staff: 25";
            this.labelTotalStaff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCompletedWorks
            // 
            this.labelCompletedWorks.AutoSize = true;
            this.labelCompletedWorks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.labelCompletedWorks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelCompletedWorks.Location = new System.Drawing.Point(611, 174);
            this.labelCompletedWorks.Name = "labelCompletedWorks";
            this.labelCompletedWorks.Size = new System.Drawing.Size(152, 20);
            this.labelCompletedWorks.TabIndex = 35;
            this.labelCompletedWorks.Text = "Completed Works: 500";
            this.labelCompletedWorks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRevenueInMonth
            // 
            this.labelRevenueInMonth.AutoSize = true;
            this.labelRevenueInMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.labelRevenueInMonth.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelRevenueInMonth.Location = new System.Drawing.Point(611, 133);
            this.labelRevenueInMonth.Name = "labelRevenueInMonth";
            this.labelRevenueInMonth.Size = new System.Drawing.Size(186, 20);
            this.labelRevenueInMonth.TabIndex = 34;
            this.labelRevenueInMonth.Text = "Revenue in Month: 1500000";
            this.labelRevenueInMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotalRevenue
            // 
            this.labelTotalRevenue.AutoSize = true;
            this.labelTotalRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.labelTotalRevenue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTotalRevenue.Location = new System.Drawing.Point(611, 95);
            this.labelTotalRevenue.Name = "labelTotalRevenue";
            this.labelTotalRevenue.Size = new System.Drawing.Size(170, 20);
            this.labelTotalRevenue.TabIndex = 33;
            this.labelTotalRevenue.Text = "Total Revenue: 20000000";
            this.labelTotalRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvStaffControl
            // 
            this.dgvStaffControl.AllowUserToAddRows = false;
            this.dgvStaffControl.AllowUserToDeleteRows = false;
            this.dgvStaffControl.AllowUserToResizeColumns = false;
            this.dgvStaffControl.AllowUserToResizeRows = false;
            this.dgvStaffControl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStaffControl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(80)))), ((int)(((byte)(88)))));
            this.dgvStaffControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStaffControl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStaffControl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStaffControl.ColumnHeadersHeight = 30;
            this.dgvStaffControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStaffControl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.email,
            this.totalMoney,
            this.printStaff});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStaffControl.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStaffControl.EnableHeadersVisualStyles = false;
            this.dgvStaffControl.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(80)))), ((int)(((byte)(88)))));
            this.dgvStaffControl.Location = new System.Drawing.Point(51, 265);
            this.dgvStaffControl.Name = "dgvStaffControl";
            this.dgvStaffControl.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvStaffControl.RowHeadersVisible = false;
            this.dgvStaffControl.RowHeadersWidth = 415;
            this.dgvStaffControl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvStaffControl.RowTemplate.Height = 30;
            this.dgvStaffControl.RowTemplate.ReadOnly = true;
            this.dgvStaffControl.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStaffControl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvStaffControl.Size = new System.Drawing.Size(887, 407);
            this.dgvStaffControl.TabIndex = 29;
            this.dgvStaffControl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaffControl_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // name
            // 
            this.name.HeaderText = "Full Name";
            this.name.Name = "name";
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // totalMoney
            // 
            this.totalMoney.HeaderText = "Total Money";
            this.totalMoney.Name = "totalMoney";
            // 
            // printStaff
            // 
            this.printStaff.HeaderText = "Action";
            this.printStaff.Image = ((System.Drawing.Image)(resources.GetObject("printStaff.Image")));
            this.printStaff.Name = "printStaff";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(981, 28);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(394, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 29);
            this.label1.TabIndex = 41;
            this.label1.Text = "TỔNG THỐNG KÊ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StatisticsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StatisticsControl";
            this.Size = new System.Drawing.Size(981, 692);
            this.Load += new System.EventHandler(this.StatisticsControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvStaffControl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTotalServices;
        private System.Windows.Forms.Label labelTotalCustomers;
        private System.Windows.Forms.Label labelTotalStaff;
        private System.Windows.Forms.Label labelCompletedWorks;
        private System.Windows.Forms.Label labelRevenueInMonth;
        private System.Windows.Forms.Label labelTotalRevenue;
        private System.Windows.Forms.Button btnSearchStaff;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalMoney;
        private System.Windows.Forms.DataGridViewImageColumn printStaff;
        private System.Windows.Forms.Label label1;
    }
}
