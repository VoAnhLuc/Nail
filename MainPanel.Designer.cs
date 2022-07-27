
namespace FairyNails
{
    partial class FairyNailsForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FairyNailsForm));
            this.leftPanel = new System.Windows.Forms.Panel();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnWorks = new System.Windows.Forms.Button();
            this.btnServices = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabAllMain = new System.Windows.Forms.TabPage();
            this.tabProcessingMain = new System.Windows.Forms.TabPage();
            this.subProcessingMainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tabCompletedMain = new System.Windows.Forms.TabPage();
            this.subCompletedMainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tabCancelledMain = new System.Windows.Forms.TabPage();
            this.subCancelledMainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.servicesControl1 = new FairyNails.ServicesControl();
            this.customersControl1 = new FairyNails.CustomersControl();
            this.staffControl1 = new FairyNails.StaffControl();
            this.statisticsControl1 = new FairyNails.StatisticsControl();
            this.accessControl1 = new FairyNails.AccessControl();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPanel)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.tabAllMain.SuspendLayout();
            this.tabProcessingMain.SuspendLayout();
            this.tabCompletedMain.SuspendLayout();
            this.tabCancelledMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.leftPanel.Controls.Add(this.btnStatistics);
            this.leftPanel.Controls.Add(this.button1);
            this.leftPanel.Controls.Add(this.btnWorks);
            this.leftPanel.Controls.Add(this.btnServices);
            this.leftPanel.Controls.Add(this.btnCustomers);
            this.leftPanel.Controls.Add(this.btnStaff);
            this.leftPanel.Controls.Add(this.logoPanel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(68, 692);
            this.leftPanel.TabIndex = 0;
            // 
            // btnStatistics
            // 
            this.btnStatistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatistics.FlatAppearance.BorderSize = 0;
            this.btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistics.Image = ((System.Drawing.Image)(resources.GetObject("btnStatistics.Image")));
            this.btnStatistics.Location = new System.Drawing.Point(0, 317);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(68, 46);
            this.btnStatistics.TabIndex = 12;
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 646);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 46);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnWorks
            // 
            this.btnWorks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWorks.FlatAppearance.BorderSize = 0;
            this.btnWorks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorks.Image = ((System.Drawing.Image)(resources.GetObject("btnWorks.Image")));
            this.btnWorks.Location = new System.Drawing.Point(0, 133);
            this.btnWorks.Name = "btnWorks";
            this.btnWorks.Size = new System.Drawing.Size(68, 46);
            this.btnWorks.TabIndex = 10;
            this.btnWorks.UseVisualStyleBackColor = true;
            this.btnWorks.Click += new System.EventHandler(this.btnWorks_Click);
            // 
            // btnServices
            // 
            this.btnServices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServices.FlatAppearance.BorderSize = 0;
            this.btnServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServices.Image = ((System.Drawing.Image)(resources.GetObject("btnServices.Image")));
            this.btnServices.Location = new System.Drawing.Point(0, 179);
            this.btnServices.Name = "btnServices";
            this.btnServices.Size = new System.Drawing.Size(68, 46);
            this.btnServices.TabIndex = 9;
            this.btnServices.UseVisualStyleBackColor = true;
            this.btnServices.Click += new System.EventHandler(this.btnServices_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomers.Image")));
            this.btnCustomers.Location = new System.Drawing.Point(0, 225);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(68, 46);
            this.btnCustomers.TabIndex = 8;
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStaff.FlatAppearance.BorderSize = 0;
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff.Image = ((System.Drawing.Image)(resources.GetObject("btnStaff.Image")));
            this.btnStaff.Location = new System.Drawing.Point(0, 271);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(68, 46);
            this.btnStaff.TabIndex = 7;
            this.btnStaff.UseVisualStyleBackColor = true;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.Image = ((System.Drawing.Image)(resources.GetObject("logoPanel.Image")));
            this.logoPanel.Location = new System.Drawing.Point(12, 25);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(45, 45);
            this.logoPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPanel.TabIndex = 0;
            this.logoPanel.TabStop = false;
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(3, 3);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(969, 653);
            this.mainPanel.TabIndex = 2;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabAllMain);
            this.tabControlMain.Controls.Add(this.tabProcessingMain);
            this.tabControlMain.Controls.Add(this.tabCompletedMain);
            this.tabControlMain.Controls.Add(this.tabCancelledMain);
            this.tabControlMain.Location = new System.Drawing.Point(68, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(983, 692);
            this.tabControlMain.TabIndex = 4;
            // 
            // tabAllMain
            // 
            this.tabAllMain.BackColor = System.Drawing.SystemColors.Control;
            this.tabAllMain.Controls.Add(this.mainPanel);
            this.tabAllMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.tabAllMain.Location = new System.Drawing.Point(4, 29);
            this.tabAllMain.Name = "tabAllMain";
            this.tabAllMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabAllMain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabAllMain.Size = new System.Drawing.Size(975, 659);
            this.tabAllMain.TabIndex = 0;
            this.tabAllMain.Text = "   All";
            // 
            // tabProcessingMain
            // 
            this.tabProcessingMain.BackColor = System.Drawing.SystemColors.Control;
            this.tabProcessingMain.Controls.Add(this.subProcessingMainPanel);
            this.tabProcessingMain.Location = new System.Drawing.Point(4, 29);
            this.tabProcessingMain.Name = "tabProcessingMain";
            this.tabProcessingMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabProcessingMain.Size = new System.Drawing.Size(975, 659);
            this.tabProcessingMain.TabIndex = 1;
            this.tabProcessingMain.Text = "Processing";
            this.tabProcessingMain.Enter += new System.EventHandler(this.tabProcessingMain_Enter);
            // 
            // subProcessingMainPanel
            // 
            this.subProcessingMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subProcessingMainPanel.Location = new System.Drawing.Point(3, 3);
            this.subProcessingMainPanel.Name = "subProcessingMainPanel";
            this.subProcessingMainPanel.Size = new System.Drawing.Size(969, 653);
            this.subProcessingMainPanel.TabIndex = 0;
            // 
            // tabCompletedMain
            // 
            this.tabCompletedMain.BackColor = System.Drawing.SystemColors.Control;
            this.tabCompletedMain.Controls.Add(this.subCompletedMainPanel);
            this.tabCompletedMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.tabCompletedMain.Location = new System.Drawing.Point(4, 29);
            this.tabCompletedMain.Name = "tabCompletedMain";
            this.tabCompletedMain.Size = new System.Drawing.Size(975, 659);
            this.tabCompletedMain.TabIndex = 2;
            this.tabCompletedMain.Text = "Completed";
            this.tabCompletedMain.Enter += new System.EventHandler(this.tabCompletedMain_Enter);
            // 
            // subCompletedMainPanel
            // 
            this.subCompletedMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subCompletedMainPanel.Location = new System.Drawing.Point(0, 0);
            this.subCompletedMainPanel.Name = "subCompletedMainPanel";
            this.subCompletedMainPanel.Size = new System.Drawing.Size(975, 659);
            this.subCompletedMainPanel.TabIndex = 1;
            // 
            // tabCancelledMain
            // 
            this.tabCancelledMain.BackColor = System.Drawing.SystemColors.Control;
            this.tabCancelledMain.Controls.Add(this.subCancelledMainPanel);
            this.tabCancelledMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.tabCancelledMain.Location = new System.Drawing.Point(4, 29);
            this.tabCancelledMain.Name = "tabCancelledMain";
            this.tabCancelledMain.Size = new System.Drawing.Size(975, 659);
            this.tabCancelledMain.TabIndex = 3;
            this.tabCancelledMain.Text = "Cancelled";
            this.tabCancelledMain.Enter += new System.EventHandler(this.tabCancelledMain_Enter);
            // 
            // subCancelledMainPanel
            // 
            this.subCancelledMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subCancelledMainPanel.Location = new System.Drawing.Point(0, 0);
            this.subCancelledMainPanel.Name = "subCancelledMainPanel";
            this.subCancelledMainPanel.Size = new System.Drawing.Size(975, 659);
            this.subCancelledMainPanel.TabIndex = 2;
            // 
            // servicesControl1
            // 
            this.servicesControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.servicesControl1.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicesControl1.Location = new System.Drawing.Point(68, 0);
            this.servicesControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.servicesControl1.Name = "servicesControl1";
            this.servicesControl1.Size = new System.Drawing.Size(981, 692);
            this.servicesControl1.TabIndex = 5;
            // 
            // customersControl1
            // 
            this.customersControl1.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersControl1.Location = new System.Drawing.Point(68, 0);
            this.customersControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.customersControl1.Name = "customersControl1";
            this.customersControl1.Size = new System.Drawing.Size(981, 692);
            this.customersControl1.TabIndex = 6;
            // 
            // staffControl1
            // 
            this.staffControl1.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffControl1.Location = new System.Drawing.Point(68, 0);
            this.staffControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.staffControl1.Name = "staffControl1";
            this.staffControl1.Size = new System.Drawing.Size(981, 692);
            this.staffControl1.TabIndex = 7;
            // 
            // statisticsControl1
            // 
            this.statisticsControl1.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statisticsControl1.Location = new System.Drawing.Point(68, 0);
            this.statisticsControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.statisticsControl1.Name = "statisticsControl1";
            this.statisticsControl1.Size = new System.Drawing.Size(981, 692);
            this.statisticsControl1.TabIndex = 8;
            // 
            // accessControl1
            // 
            this.accessControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.accessControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("accessControl1.BackgroundImage")));
            this.accessControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.accessControl1.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accessControl1.ForeColor = System.Drawing.Color.Cornsilk;
            this.accessControl1.Location = new System.Drawing.Point(68, 0);
            this.accessControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.accessControl1.Name = "accessControl1";
            this.accessControl1.Size = new System.Drawing.Size(983, 692);
            this.accessControl1.TabIndex = 9;
            // 
            // FairyNailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(1049, 692);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.accessControl1);
            this.Controls.Add(this.statisticsControl1);
            this.Controls.Add(this.customersControl1);
            this.Controls.Add(this.staffControl1);
            this.Controls.Add(this.servicesControl1);
            this.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FairyNailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPanel";
            this.Load += new System.EventHandler(this.FairyNailsForm_Load);
            this.leftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPanel)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.tabAllMain.ResumeLayout(false);
            this.tabProcessingMain.ResumeLayout(false);
            this.tabCompletedMain.ResumeLayout(false);
            this.tabCancelledMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.FlowLayoutPanel mainPanel;
        private System.Windows.Forms.PictureBox logoPanel;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabAllMain;
        private System.Windows.Forms.TabPage tabProcessingMain;
        private System.Windows.Forms.FlowLayoutPanel subProcessingMainPanel;
        private System.Windows.Forms.TabPage tabCompletedMain;
        private System.Windows.Forms.FlowLayoutPanel subCompletedMainPanel;
        private System.Windows.Forms.TabPage tabCancelledMain;
        private System.Windows.Forms.FlowLayoutPanel subCancelledMainPanel;
        private ServicesControl servicesControl1;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnWorks;
        private System.Windows.Forms.Button btnServices;
        private CustomersControl customersControl1;
        private StaffControl staffControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnStatistics;
        private StatisticsControl statisticsControl1;
        private AccessControl accessControl1;
    }
}