
namespace FairyNails
{
    partial class ServicesControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServicesControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeleteServices = new System.Windows.Forms.Button();
            this.btnEditService = new System.Windows.Forms.Button();
            this.btnAddService = new System.Windows.Forms.Button();
            this.btnSearchService = new System.Windows.Forms.Button();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.txtTypeService = new System.Windows.Forms.ComboBox();
            this.txtPriceService = new System.Windows.Forms.TextBox();
            this.txtNameService = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvServicesControl = new System.Windows.Forms.DataGridView();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabServices = new System.Windows.Forms.TabPage();
            this.tabTypeOfService = new System.Windows.Forms.TabPage();
            this.dgvTypeOfServices = new System.Windows.Forms.DataGridView();
            this.btnDeleteTypeOfServices = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEditTypeOfServices = new System.Windows.Forms.Button();
            this.txtNameTypeOfServices = new System.Windows.Forms.TextBox();
            this.btnAddTypeOfServices = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicesControl)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.tabServices.SuspendLayout();
            this.tabTypeOfService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypeOfServices)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(181, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 47);
            this.label3.TabIndex = 13;
            this.label3.Text = "Service\'s price: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(181, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 47);
            this.label2.TabIndex = 12;
            this.label2.Text = "Service\'s type: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDeleteServices
            // 
            this.btnDeleteServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.btnDeleteServices.FlatAppearance.BorderSize = 0;
            this.btnDeleteServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteServices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnDeleteServices.Location = new System.Drawing.Point(676, 175);
            this.btnDeleteServices.Name = "btnDeleteServices";
            this.btnDeleteServices.Size = new System.Drawing.Size(75, 27);
            this.btnDeleteServices.TabIndex = 11;
            this.btnDeleteServices.Text = "Delete";
            this.btnDeleteServices.UseVisualStyleBackColor = false;
            this.btnDeleteServices.Click += new System.EventHandler(this.btnDeleteServices_Click);
            // 
            // btnEditService
            // 
            this.btnEditService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.btnEditService.FlatAppearance.BorderSize = 0;
            this.btnEditService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnEditService.Location = new System.Drawing.Point(676, 121);
            this.btnEditService.Name = "btnEditService";
            this.btnEditService.Size = new System.Drawing.Size(75, 27);
            this.btnEditService.TabIndex = 10;
            this.btnEditService.Text = "Edit";
            this.btnEditService.UseVisualStyleBackColor = false;
            this.btnEditService.Click += new System.EventHandler(this.btnEditService_Click);
            // 
            // btnAddService
            // 
            this.btnAddService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.btnAddService.FlatAppearance.BorderSize = 0;
            this.btnAddService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnAddService.Location = new System.Drawing.Point(676, 69);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(75, 27);
            this.btnAddService.TabIndex = 9;
            this.btnAddService.Text = "Add";
            this.btnAddService.UseVisualStyleBackColor = false;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // btnSearchService
            // 
            this.btnSearchService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.btnSearchService.FlatAppearance.BorderSize = 0;
            this.btnSearchService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnSearchService.Location = new System.Drawing.Point(589, 271);
            this.btnSearchService.Name = "btnSearchService";
            this.btnSearchService.Size = new System.Drawing.Size(75, 27);
            this.btnSearchService.TabIndex = 8;
            this.btnSearchService.Text = "Search";
            this.btnSearchService.UseVisualStyleBackColor = false;
            this.btnSearchService.Click += new System.EventHandler(this.btnSearchService_Click);
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(318, 271);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(265, 27);
            this.txtKeyword.TabIndex = 7;
            // 
            // txtTypeService
            // 
            this.txtTypeService.FormattingEnabled = true;
            this.txtTypeService.Location = new System.Drawing.Point(346, 124);
            this.txtTypeService.Name = "txtTypeService";
            this.txtTypeService.Size = new System.Drawing.Size(152, 28);
            this.txtTypeService.TabIndex = 6;
            // 
            // txtPriceService
            // 
            this.txtPriceService.Location = new System.Drawing.Point(346, 175);
            this.txtPriceService.Name = "txtPriceService";
            this.txtPriceService.Size = new System.Drawing.Size(152, 27);
            this.txtPriceService.TabIndex = 4;
            // 
            // txtNameService
            // 
            this.txtNameService.Location = new System.Drawing.Point(346, 69);
            this.txtNameService.Name = "txtNameService";
            this.txtNameService.Size = new System.Drawing.Size(152, 27);
            this.txtNameService.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(181, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Service\'s name: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvServicesControl
            // 
            this.dgvServicesControl.AllowUserToAddRows = false;
            this.dgvServicesControl.AllowUserToDeleteRows = false;
            this.dgvServicesControl.AllowUserToResizeColumns = false;
            this.dgvServicesControl.AllowUserToResizeRows = false;
            this.dgvServicesControl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServicesControl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(80)))), ((int)(((byte)(88)))));
            this.dgvServicesControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvServicesControl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvServicesControl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvServicesControl.ColumnHeadersHeight = 30;
            this.dgvServicesControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(80)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvServicesControl.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvServicesControl.EnableHeadersVisualStyles = false;
            this.dgvServicesControl.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(80)))), ((int)(((byte)(88)))));
            this.dgvServicesControl.Location = new System.Drawing.Point(117, 320);
            this.dgvServicesControl.Name = "dgvServicesControl";
            this.dgvServicesControl.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvServicesControl.RowHeadersVisible = false;
            this.dgvServicesControl.RowHeadersWidth = 415;
            this.dgvServicesControl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvServicesControl.RowTemplate.Height = 30;
            this.dgvServicesControl.RowTemplate.ReadOnly = true;
            this.dgvServicesControl.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvServicesControl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvServicesControl.Size = new System.Drawing.Size(730, 300);
            this.dgvServicesControl.TabIndex = 0;
            this.dgvServicesControl.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServicesControl_RowEnter);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabServices);
            this.tabControlMain.Controls.Add(this.tabTypeOfService);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(981, 692);
            this.tabControlMain.TabIndex = 2;
            // 
            // tabServices
            // 
            this.tabServices.Controls.Add(this.label3);
            this.tabServices.Controls.Add(this.label2);
            this.tabServices.Controls.Add(this.dgvServicesControl);
            this.tabServices.Controls.Add(this.btnDeleteServices);
            this.tabServices.Controls.Add(this.label1);
            this.tabServices.Controls.Add(this.btnEditService);
            this.tabServices.Controls.Add(this.txtNameService);
            this.tabServices.Controls.Add(this.btnAddService);
            this.tabServices.Controls.Add(this.txtPriceService);
            this.tabServices.Controls.Add(this.btnSearchService);
            this.tabServices.Controls.Add(this.txtTypeService);
            this.tabServices.Controls.Add(this.txtKeyword);
            this.tabServices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.tabServices.Location = new System.Drawing.Point(4, 29);
            this.tabServices.Name = "tabServices";
            this.tabServices.Padding = new System.Windows.Forms.Padding(3);
            this.tabServices.Size = new System.Drawing.Size(973, 659);
            this.tabServices.TabIndex = 0;
            this.tabServices.Text = "     Services    ";
            this.tabServices.UseVisualStyleBackColor = true;
            // 
            // tabTypeOfService
            // 
            this.tabTypeOfService.Controls.Add(this.dgvTypeOfServices);
            this.tabTypeOfService.Controls.Add(this.btnDeleteTypeOfServices);
            this.tabTypeOfService.Controls.Add(this.label6);
            this.tabTypeOfService.Controls.Add(this.btnEditTypeOfServices);
            this.tabTypeOfService.Controls.Add(this.txtNameTypeOfServices);
            this.tabTypeOfService.Controls.Add(this.btnAddTypeOfServices);
            this.tabTypeOfService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.tabTypeOfService.Location = new System.Drawing.Point(4, 29);
            this.tabTypeOfService.Name = "tabTypeOfService";
            this.tabTypeOfService.Padding = new System.Windows.Forms.Padding(3);
            this.tabTypeOfService.Size = new System.Drawing.Size(973, 659);
            this.tabTypeOfService.TabIndex = 1;
            this.tabTypeOfService.Text = "    Type Of Service   ";
            this.tabTypeOfService.UseVisualStyleBackColor = true;
            // 
            // dgvTypeOfServices
            // 
            this.dgvTypeOfServices.AllowUserToAddRows = false;
            this.dgvTypeOfServices.AllowUserToDeleteRows = false;
            this.dgvTypeOfServices.AllowUserToResizeColumns = false;
            this.dgvTypeOfServices.AllowUserToResizeRows = false;
            this.dgvTypeOfServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTypeOfServices.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(80)))), ((int)(((byte)(88)))));
            this.dgvTypeOfServices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTypeOfServices.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTypeOfServices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTypeOfServices.ColumnHeadersHeight = 30;
            this.dgvTypeOfServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(80)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTypeOfServices.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTypeOfServices.EnableHeadersVisualStyles = false;
            this.dgvTypeOfServices.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(80)))), ((int)(((byte)(88)))));
            this.dgvTypeOfServices.Location = new System.Drawing.Point(119, 262);
            this.dgvTypeOfServices.Name = "dgvTypeOfServices";
            this.dgvTypeOfServices.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTypeOfServices.RowHeadersVisible = false;
            this.dgvTypeOfServices.RowHeadersWidth = 415;
            this.dgvTypeOfServices.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTypeOfServices.RowTemplate.Height = 30;
            this.dgvTypeOfServices.RowTemplate.ReadOnly = true;
            this.dgvTypeOfServices.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTypeOfServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvTypeOfServices.Size = new System.Drawing.Size(730, 300);
            this.dgvTypeOfServices.TabIndex = 14;
            this.dgvTypeOfServices.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTypeOfServices_RowEnter);
            // 
            // btnDeleteTypeOfServices
            // 
            this.btnDeleteTypeOfServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.btnDeleteTypeOfServices.FlatAppearance.BorderSize = 0;
            this.btnDeleteTypeOfServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTypeOfServices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnDeleteTypeOfServices.Location = new System.Drawing.Point(573, 180);
            this.btnDeleteTypeOfServices.Name = "btnDeleteTypeOfServices";
            this.btnDeleteTypeOfServices.Size = new System.Drawing.Size(75, 27);
            this.btnDeleteTypeOfServices.TabIndex = 23;
            this.btnDeleteTypeOfServices.Text = "Delete";
            this.btnDeleteTypeOfServices.UseVisualStyleBackColor = false;
            this.btnDeleteTypeOfServices.Click += new System.EventHandler(this.btnDeleteTypeOfServices_Click);
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(332, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 47);
            this.label6.TabIndex = 15;
            this.label6.Text = "Type\'s name";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnEditTypeOfServices
            // 
            this.btnEditTypeOfServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.btnEditTypeOfServices.FlatAppearance.BorderSize = 0;
            this.btnEditTypeOfServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTypeOfServices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnEditTypeOfServices.Location = new System.Drawing.Point(445, 180);
            this.btnEditTypeOfServices.Name = "btnEditTypeOfServices";
            this.btnEditTypeOfServices.Size = new System.Drawing.Size(75, 27);
            this.btnEditTypeOfServices.TabIndex = 22;
            this.btnEditTypeOfServices.Text = "Edit";
            this.btnEditTypeOfServices.UseVisualStyleBackColor = false;
            this.btnEditTypeOfServices.Click += new System.EventHandler(this.btnEditTypeOfServices_Click);
            // 
            // txtNameTypeOfServices
            // 
            this.txtNameTypeOfServices.Location = new System.Drawing.Point(469, 111);
            this.txtNameTypeOfServices.Name = "txtNameTypeOfServices";
            this.txtNameTypeOfServices.Size = new System.Drawing.Size(152, 27);
            this.txtNameTypeOfServices.TabIndex = 16;
            // 
            // btnAddTypeOfServices
            // 
            this.btnAddTypeOfServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.btnAddTypeOfServices.FlatAppearance.BorderSize = 0;
            this.btnAddTypeOfServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTypeOfServices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnAddTypeOfServices.Location = new System.Drawing.Point(308, 180);
            this.btnAddTypeOfServices.Name = "btnAddTypeOfServices";
            this.btnAddTypeOfServices.Size = new System.Drawing.Size(75, 27);
            this.btnAddTypeOfServices.TabIndex = 21;
            this.btnAddTypeOfServices.Text = "Add";
            this.btnAddTypeOfServices.UseVisualStyleBackColor = false;
            this.btnAddTypeOfServices.Click += new System.EventHandler(this.btnAddTypeOfServices_Click);
            // 
            // ServicesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.Controls.Add(this.tabControlMain);
            this.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ServicesControl";
            this.Size = new System.Drawing.Size(981, 692);
            this.Load += new System.EventHandler(this.ServicesControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicesControl)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.tabServices.ResumeLayout(false);
            this.tabServices.PerformLayout();
            this.tabTypeOfService.ResumeLayout(false);
            this.tabTypeOfService.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypeOfServices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvServicesControl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeleteServices;
        private System.Windows.Forms.Button btnEditService;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.Button btnSearchService;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.ComboBox txtTypeService;
        private System.Windows.Forms.TextBox txtPriceService;
        private System.Windows.Forms.TextBox txtNameService;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabServices;
        private System.Windows.Forms.TabPage tabTypeOfService;
        private System.Windows.Forms.DataGridView dgvTypeOfServices;
        private System.Windows.Forms.Button btnDeleteTypeOfServices;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEditTypeOfServices;
        private System.Windows.Forms.TextBox txtNameTypeOfServices;
        private System.Windows.Forms.Button btnAddTypeOfServices;
    }
}
