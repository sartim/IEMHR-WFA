namespace IEMHR_WFA
{
    partial class MainFrm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prescriptionManagmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prescriptionDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrescriptionFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrescriptionReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mEdicalManagmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.healthManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.prescriptionManagmentToolStripMenuItem,
            this.mEdicalManagmentToolStripMenuItem,
            this.healthManagementToolStripMenuItem,
            this.administrationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(936, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // prescriptionManagmentToolStripMenuItem
            // 
            this.prescriptionManagmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prescriptionDetailsToolStripMenuItem});
            this.prescriptionManagmentToolStripMenuItem.Name = "prescriptionManagmentToolStripMenuItem";
            this.prescriptionManagmentToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.prescriptionManagmentToolStripMenuItem.Text = "Prescription Managment";
            // 
            // prescriptionDetailsToolStripMenuItem
            // 
            this.prescriptionDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PrescriptionFormToolStripMenuItem,
            this.PrescriptionReportToolStripMenuItem});
            this.prescriptionDetailsToolStripMenuItem.Name = "prescriptionDetailsToolStripMenuItem";
            this.prescriptionDetailsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.prescriptionDetailsToolStripMenuItem.Text = "Prescription";
            // 
            // PrescriptionFormToolStripMenuItem
            // 
            this.PrescriptionFormToolStripMenuItem.Name = "PrescriptionFormToolStripMenuItem";
            this.PrescriptionFormToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.PrescriptionFormToolStripMenuItem.Text = "Prescription form";
            this.PrescriptionFormToolStripMenuItem.Click += new System.EventHandler(this.PrescriptionFormToolStripMenuItem_Click);
            // 
            // PrescriptionReportToolStripMenuItem
            // 
            this.PrescriptionReportToolStripMenuItem.Name = "PrescriptionReportToolStripMenuItem";
            this.PrescriptionReportToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.PrescriptionReportToolStripMenuItem.Text = "Prescription report";
            // 
            // mEdicalManagmentToolStripMenuItem
            // 
            this.mEdicalManagmentToolStripMenuItem.Name = "mEdicalManagmentToolStripMenuItem";
            this.mEdicalManagmentToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.mEdicalManagmentToolStripMenuItem.Text = "Medical Managment";
            // 
            // healthManagementToolStripMenuItem
            // 
            this.healthManagementToolStripMenuItem.Name = "healthManagementToolStripMenuItem";
            this.healthManagementToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.healthManagementToolStripMenuItem.Text = "Health Management";
            // 
            // administrationToolStripMenuItem
            // 
            this.administrationToolStripMenuItem.Name = "administrationToolStripMenuItem";
            this.administrationToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.administrationToolStripMenuItem.Text = "Administration";
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 618);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFrm";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prescriptionManagmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mEdicalManagmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem healthManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prescriptionDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PrescriptionFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PrescriptionReportToolStripMenuItem;
    }
}

