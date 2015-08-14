namespace IEMHR_WFA.Forms.Prescription
{
    partial class PrescriptionDetailsFrm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label pharmacyIdLabel;
            System.Windows.Forms.Label issueToLabel;
            System.Windows.Forms.Label refillsLabel;
            System.Windows.Forms.Label commentsLabel;
            System.Windows.Forms.Label allergiesLabel;
            System.Windows.Forms.Label processedDateLabel;
            System.Windows.Forms.Label submitDateLabel;
            System.Windows.Forms.Label numOfDaysLabel;
            System.Windows.Forms.Label frequencyLabel;
            System.Windows.Forms.Label doseUnitsLabel;
            System.Windows.Forms.Label doseLabel;
            System.Windows.Forms.Label drugNameLabel;
            System.Windows.Forms.Label diagnosisLabel;
            System.Windows.Forms.Label patientIdLabel;
            System.Windows.Forms.Label patientNameLabel;
            System.Windows.Forms.Label physicianIdLabel;
            System.Windows.Forms.Label prescriberNameLabel;
            System.Windows.Forms.Label prescriptionIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrescriptionDetailsFrm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PrescriptionDetailsTabControl = new System.Windows.Forms.TabControl();
            this.DetailsTabPage = new System.Windows.Forms.TabPage();
            this.btnImportExport = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.PhysicianGroupBox = new System.Windows.Forms.GroupBox();
            this.prescriberNameTextBox = new System.Windows.Forms.TextBox();
            this.prescriptionMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iEMHR_DB_DataSet = new IEMHR_WFA.IEMHR_DB_DataSet();
            this.physicianIdTextBox = new System.Windows.Forms.TextBox();
            this.DateGroupBox = new System.Windows.Forms.GroupBox();
            this.submitDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.processedDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.PharmacyGroupBox = new System.Windows.Forms.GroupBox();
            this.pharmacyIdTextBox = new System.Windows.Forms.TextBox();
            this.issueToTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.doseTextBox = new System.Windows.Forms.TextBox();
            this.refillsTextBox = new System.Windows.Forms.TextBox();
            this.doseUnitsTextBox = new System.Windows.Forms.TextBox();
            this.frequencyTextBox = new System.Windows.Forms.TextBox();
            this.numOfDaysTextBox = new System.Windows.Forms.TextBox();
            this.prescriptionIdTextBox = new System.Windows.Forms.TextBox();
            this.PatienInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.patientNameTextBox = new System.Windows.Forms.TextBox();
            this.drugNameTextBox = new System.Windows.Forms.TextBox();
            this.patientIdTextBox = new System.Windows.Forms.TextBox();
            this.allergiesTextBox = new System.Windows.Forms.TextBox();
            this.commentsTextBox = new System.Windows.Forms.TextBox();
            this.diagnosisTextBox = new System.Windows.Forms.TextBox();
            this.GridTabPage = new System.Windows.Forms.TabPage();
            this.prescriptionMasterDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prescriptionMasterTableAdapter = new IEMHR_WFA.IEMHR_DB_DataSetTableAdapters.PrescriptionMasterTableAdapter();
            this.tableAdapterManager = new IEMHR_WFA.IEMHR_DB_DataSetTableAdapters.TableAdapterManager();
            this.prescriptionMasterBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.prescriptionMasterBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.GraphTabPage = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            pharmacyIdLabel = new System.Windows.Forms.Label();
            issueToLabel = new System.Windows.Forms.Label();
            refillsLabel = new System.Windows.Forms.Label();
            commentsLabel = new System.Windows.Forms.Label();
            allergiesLabel = new System.Windows.Forms.Label();
            processedDateLabel = new System.Windows.Forms.Label();
            submitDateLabel = new System.Windows.Forms.Label();
            numOfDaysLabel = new System.Windows.Forms.Label();
            frequencyLabel = new System.Windows.Forms.Label();
            doseUnitsLabel = new System.Windows.Forms.Label();
            doseLabel = new System.Windows.Forms.Label();
            drugNameLabel = new System.Windows.Forms.Label();
            diagnosisLabel = new System.Windows.Forms.Label();
            patientIdLabel = new System.Windows.Forms.Label();
            patientNameLabel = new System.Windows.Forms.Label();
            physicianIdLabel = new System.Windows.Forms.Label();
            prescriberNameLabel = new System.Windows.Forms.Label();
            prescriptionIdLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.PrescriptionDetailsTabControl.SuspendLayout();
            this.DetailsTabPage.SuspendLayout();
            this.PhysicianGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iEMHR_DB_DataSet)).BeginInit();
            this.DateGroupBox.SuspendLayout();
            this.PharmacyGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.PatienInfoGroupBox.SuspendLayout();
            this.GridTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionMasterDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionMasterBindingNavigator)).BeginInit();
            this.prescriptionMasterBindingNavigator.SuspendLayout();
            this.GraphTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // pharmacyIdLabel
            // 
            pharmacyIdLabel.AutoSize = true;
            pharmacyIdLabel.Location = new System.Drawing.Point(12, 30);
            pharmacyIdLabel.Name = "pharmacyIdLabel";
            pharmacyIdLabel.Size = new System.Drawing.Size(69, 13);
            pharmacyIdLabel.TabIndex = 34;
            pharmacyIdLabel.Text = "Pharmacy Id:";
            // 
            // issueToLabel
            // 
            issueToLabel.AutoSize = true;
            issueToLabel.Location = new System.Drawing.Point(12, 67);
            issueToLabel.Name = "issueToLabel";
            issueToLabel.Size = new System.Drawing.Size(51, 13);
            issueToLabel.TabIndex = 32;
            issueToLabel.Text = "Issue To:";
            // 
            // refillsLabel
            // 
            refillsLabel.AutoSize = true;
            refillsLabel.Location = new System.Drawing.Point(7, 168);
            refillsLabel.Name = "refillsLabel";
            refillsLabel.Size = new System.Drawing.Size(38, 13);
            refillsLabel.TabIndex = 30;
            refillsLabel.Text = "Refills:";
            // 
            // commentsLabel
            // 
            commentsLabel.AutoSize = true;
            commentsLabel.Location = new System.Drawing.Point(9, 133);
            commentsLabel.Name = "commentsLabel";
            commentsLabel.Size = new System.Drawing.Size(59, 13);
            commentsLabel.TabIndex = 28;
            commentsLabel.Text = "Comments:";
            // 
            // allergiesLabel
            // 
            allergiesLabel.AutoSize = true;
            allergiesLabel.Location = new System.Drawing.Point(9, 96);
            allergiesLabel.Name = "allergiesLabel";
            allergiesLabel.Size = new System.Drawing.Size(49, 13);
            allergiesLabel.TabIndex = 26;
            allergiesLabel.Text = "Allergies:";
            // 
            // processedDateLabel
            // 
            processedDateLabel.AutoSize = true;
            processedDateLabel.Location = new System.Drawing.Point(12, 66);
            processedDateLabel.Name = "processedDateLabel";
            processedDateLabel.Size = new System.Drawing.Size(86, 13);
            processedDateLabel.TabIndex = 24;
            processedDateLabel.Text = "Processed Date:";
            // 
            // submitDateLabel
            // 
            submitDateLabel.AutoSize = true;
            submitDateLabel.Location = new System.Drawing.Point(12, 23);
            submitDateLabel.Name = "submitDateLabel";
            submitDateLabel.Size = new System.Drawing.Size(68, 13);
            submitDateLabel.TabIndex = 22;
            submitDateLabel.Text = "Submit Date:";
            // 
            // numOfDaysLabel
            // 
            numOfDaysLabel.AutoSize = true;
            numOfDaysLabel.Location = new System.Drawing.Point(7, 133);
            numOfDaysLabel.Name = "numOfDaysLabel";
            numOfDaysLabel.Size = new System.Drawing.Size(73, 13);
            numOfDaysLabel.TabIndex = 20;
            numOfDaysLabel.Text = "Num Of Days:";
            // 
            // frequencyLabel
            // 
            frequencyLabel.AutoSize = true;
            frequencyLabel.Location = new System.Drawing.Point(7, 94);
            frequencyLabel.Name = "frequencyLabel";
            frequencyLabel.Size = new System.Drawing.Size(60, 13);
            frequencyLabel.TabIndex = 18;
            frequencyLabel.Text = "Frequency:";
            // 
            // doseUnitsLabel
            // 
            doseUnitsLabel.AutoSize = true;
            doseUnitsLabel.Location = new System.Drawing.Point(7, 57);
            doseUnitsLabel.Name = "doseUnitsLabel";
            doseUnitsLabel.Size = new System.Drawing.Size(62, 13);
            doseUnitsLabel.TabIndex = 16;
            doseUnitsLabel.Text = "Dose Units:";
            // 
            // doseLabel
            // 
            doseLabel.AutoSize = true;
            doseLabel.Location = new System.Drawing.Point(7, 23);
            doseLabel.Name = "doseLabel";
            doseLabel.Size = new System.Drawing.Size(35, 13);
            doseLabel.TabIndex = 14;
            doseLabel.Text = "Dose:";
            // 
            // drugNameLabel
            // 
            drugNameLabel.AutoSize = true;
            drugNameLabel.Location = new System.Drawing.Point(9, 211);
            drugNameLabel.Name = "drugNameLabel";
            drugNameLabel.Size = new System.Drawing.Size(64, 13);
            drugNameLabel.TabIndex = 12;
            drugNameLabel.Text = "Drug Name:";
            // 
            // diagnosisLabel
            // 
            diagnosisLabel.AutoSize = true;
            diagnosisLabel.Location = new System.Drawing.Point(9, 173);
            diagnosisLabel.Name = "diagnosisLabel";
            diagnosisLabel.Size = new System.Drawing.Size(56, 13);
            diagnosisLabel.TabIndex = 10;
            diagnosisLabel.Text = "Diagnosis:";
            // 
            // patientIdLabel
            // 
            patientIdLabel.AutoSize = true;
            patientIdLabel.Location = new System.Drawing.Point(9, 25);
            patientIdLabel.Name = "patientIdLabel";
            patientIdLabel.Size = new System.Drawing.Size(55, 13);
            patientIdLabel.TabIndex = 8;
            patientIdLabel.Text = "Patient Id:";
            // 
            // patientNameLabel
            // 
            patientNameLabel.AutoSize = true;
            patientNameLabel.Location = new System.Drawing.Point(9, 60);
            patientNameLabel.Name = "patientNameLabel";
            patientNameLabel.Size = new System.Drawing.Size(74, 13);
            patientNameLabel.TabIndex = 6;
            patientNameLabel.Text = "Patient Name:";
            // 
            // physicianIdLabel
            // 
            physicianIdLabel.AutoSize = true;
            physicianIdLabel.Location = new System.Drawing.Point(12, 22);
            physicianIdLabel.Name = "physicianIdLabel";
            physicianIdLabel.Size = new System.Drawing.Size(67, 13);
            physicianIdLabel.TabIndex = 4;
            physicianIdLabel.Text = "Physician Id:";
            // 
            // prescriberNameLabel
            // 
            prescriberNameLabel.AutoSize = true;
            prescriberNameLabel.Location = new System.Drawing.Point(12, 57);
            prescriberNameLabel.Name = "prescriberNameLabel";
            prescriberNameLabel.Size = new System.Drawing.Size(88, 13);
            prescriberNameLabel.TabIndex = 2;
            prescriberNameLabel.Text = "Prescriber Name:";
            // 
            // prescriptionIdLabel
            // 
            prescriptionIdLabel.AutoSize = true;
            prescriptionIdLabel.Location = new System.Drawing.Point(31, 20);
            prescriptionIdLabel.Name = "prescriptionIdLabel";
            prescriptionIdLabel.Size = new System.Drawing.Size(77, 13);
            prescriptionIdLabel.TabIndex = 0;
            prescriptionIdLabel.Text = "Prescription Id:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PrescriptionDetailsTabControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 526);
            this.panel1.TabIndex = 0;
            // 
            // PrescriptionDetailsTabControl
            // 
            this.PrescriptionDetailsTabControl.Controls.Add(this.DetailsTabPage);
            this.PrescriptionDetailsTabControl.Controls.Add(this.GridTabPage);
            this.PrescriptionDetailsTabControl.Controls.Add(this.GraphTabPage);
            this.PrescriptionDetailsTabControl.Location = new System.Drawing.Point(0, 28);
            this.PrescriptionDetailsTabControl.Name = "PrescriptionDetailsTabControl";
            this.PrescriptionDetailsTabControl.SelectedIndex = 0;
            this.PrescriptionDetailsTabControl.Size = new System.Drawing.Size(891, 496);
            this.PrescriptionDetailsTabControl.TabIndex = 0;
            // 
            // DetailsTabPage
            // 
            this.DetailsTabPage.AutoScroll = true;
            this.DetailsTabPage.Controls.Add(this.btnImportExport);
            this.DetailsTabPage.Controls.Add(this.btnAdd);
            this.DetailsTabPage.Controls.Add(this.btnInsert);
            this.DetailsTabPage.Controls.Add(this.btnExit);
            this.DetailsTabPage.Controls.Add(this.btnUpdate);
            this.DetailsTabPage.Controls.Add(this.btnSave);
            this.DetailsTabPage.Controls.Add(this.btnDelete);
            this.DetailsTabPage.Controls.Add(this.PhysicianGroupBox);
            this.DetailsTabPage.Controls.Add(this.DateGroupBox);
            this.DetailsTabPage.Controls.Add(this.listBox1);
            this.DetailsTabPage.Controls.Add(this.PharmacyGroupBox);
            this.DetailsTabPage.Controls.Add(this.groupBox1);
            this.DetailsTabPage.Controls.Add(this.prescriptionIdTextBox);
            this.DetailsTabPage.Controls.Add(prescriptionIdLabel);
            this.DetailsTabPage.Controls.Add(this.PatienInfoGroupBox);
            this.DetailsTabPage.Location = new System.Drawing.Point(4, 22);
            this.DetailsTabPage.Name = "DetailsTabPage";
            this.DetailsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.DetailsTabPage.Size = new System.Drawing.Size(883, 470);
            this.DetailsTabPage.TabIndex = 0;
            this.DetailsTabPage.Text = "Details View";
            this.DetailsTabPage.UseVisualStyleBackColor = true;
            // 
            // btnImportExport
            // 
            this.btnImportExport.Location = new System.Drawing.Point(527, 436);
            this.btnImportExport.Name = "btnImportExport";
            this.btnImportExport.Size = new System.Drawing.Size(99, 23);
            this.btnImportExport.TabIndex = 48;
            this.btnImportExport.Text = "Import / Export";
            this.btnImportExport.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(20, 436);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 47;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(114, 436);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 46;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(802, 436);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 45;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(209, 436);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 44;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(419, 436);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 43;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(310, 436);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 23);
            this.btnDelete.TabIndex = 42;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // PhysicianGroupBox
            // 
            this.PhysicianGroupBox.Controls.Add(this.prescriberNameTextBox);
            this.PhysicianGroupBox.Controls.Add(physicianIdLabel);
            this.PhysicianGroupBox.Controls.Add(prescriberNameLabel);
            this.PhysicianGroupBox.Controls.Add(this.physicianIdTextBox);
            this.PhysicianGroupBox.Location = new System.Drawing.Point(358, 14);
            this.PhysicianGroupBox.Name = "PhysicianGroupBox";
            this.PhysicianGroupBox.Size = new System.Drawing.Size(316, 84);
            this.PhysicianGroupBox.TabIndex = 41;
            this.PhysicianGroupBox.TabStop = false;
            this.PhysicianGroupBox.Text = "Physician Info";
            // 
            // prescriberNameTextBox
            // 
            this.prescriberNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescriptionMasterBindingSource, "PrescriberName", true));
            this.prescriberNameTextBox.Location = new System.Drawing.Point(106, 54);
            this.prescriberNameTextBox.Name = "prescriberNameTextBox";
            this.prescriberNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.prescriberNameTextBox.TabIndex = 3;
            // 
            // prescriptionMasterBindingSource
            // 
            this.prescriptionMasterBindingSource.DataMember = "PrescriptionMaster";
            this.prescriptionMasterBindingSource.DataSource = this.iEMHR_DB_DataSet;
            // 
            // iEMHR_DB_DataSet
            // 
            this.iEMHR_DB_DataSet.DataSetName = "IEMHR_DB_DataSet";
            this.iEMHR_DB_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // physicianIdTextBox
            // 
            this.physicianIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescriptionMasterBindingSource, "PhysicianId", true));
            this.physicianIdTextBox.Location = new System.Drawing.Point(106, 19);
            this.physicianIdTextBox.Name = "physicianIdTextBox";
            this.physicianIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.physicianIdTextBox.TabIndex = 5;
            // 
            // DateGroupBox
            // 
            this.DateGroupBox.Controls.Add(this.submitDateDateTimePicker);
            this.DateGroupBox.Controls.Add(submitDateLabel);
            this.DateGroupBox.Controls.Add(this.processedDateDateTimePicker);
            this.DateGroupBox.Controls.Add(processedDateLabel);
            this.DateGroupBox.Location = new System.Drawing.Point(358, 114);
            this.DateGroupBox.Name = "DateGroupBox";
            this.DateGroupBox.Size = new System.Drawing.Size(316, 98);
            this.DateGroupBox.TabIndex = 40;
            this.DateGroupBox.TabStop = false;
            this.DateGroupBox.Text = "Date Info";
            // 
            // submitDateDateTimePicker
            // 
            this.submitDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.prescriptionMasterBindingSource, "SubmitDate", true));
            this.submitDateDateTimePicker.Location = new System.Drawing.Point(106, 19);
            this.submitDateDateTimePicker.Name = "submitDateDateTimePicker";
            this.submitDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.submitDateDateTimePicker.TabIndex = 23;
            // 
            // processedDateDateTimePicker
            // 
            this.processedDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.prescriptionMasterBindingSource, "ProcessedDate", true));
            this.processedDateDateTimePicker.Location = new System.Drawing.Point(106, 62);
            this.processedDateDateTimePicker.Name = "processedDateDateTimePicker";
            this.processedDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.processedDateDateTimePicker.TabIndex = 25;
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.prescriptionMasterBindingSource;
            this.listBox1.DisplayMember = "PatientName";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(690, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(187, 394);
            this.listBox1.TabIndex = 39;
            // 
            // PharmacyGroupBox
            // 
            this.PharmacyGroupBox.Controls.Add(this.pharmacyIdTextBox);
            this.PharmacyGroupBox.Controls.Add(pharmacyIdLabel);
            this.PharmacyGroupBox.Controls.Add(issueToLabel);
            this.PharmacyGroupBox.Controls.Add(this.issueToTextBox);
            this.PharmacyGroupBox.Location = new System.Drawing.Point(22, 55);
            this.PharmacyGroupBox.Name = "PharmacyGroupBox";
            this.PharmacyGroupBox.Size = new System.Drawing.Size(316, 100);
            this.PharmacyGroupBox.TabIndex = 38;
            this.PharmacyGroupBox.TabStop = false;
            this.PharmacyGroupBox.Text = "Pharmacy Info";
            // 
            // pharmacyIdTextBox
            // 
            this.pharmacyIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescriptionMasterBindingSource, "PharmacyId", true));
            this.pharmacyIdTextBox.Location = new System.Drawing.Point(106, 27);
            this.pharmacyIdTextBox.Name = "pharmacyIdTextBox";
            this.pharmacyIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.pharmacyIdTextBox.TabIndex = 35;
            // 
            // issueToTextBox
            // 
            this.issueToTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescriptionMasterBindingSource, "IssueTo", true));
            this.issueToTextBox.Location = new System.Drawing.Point(106, 64);
            this.issueToTextBox.Name = "issueToTextBox";
            this.issueToTextBox.Size = new System.Drawing.Size(200, 20);
            this.issueToTextBox.TabIndex = 33;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(doseLabel);
            this.groupBox1.Controls.Add(this.doseTextBox);
            this.groupBox1.Controls.Add(this.refillsTextBox);
            this.groupBox1.Controls.Add(this.doseUnitsTextBox);
            this.groupBox1.Controls.Add(this.frequencyTextBox);
            this.groupBox1.Controls.Add(numOfDaysLabel);
            this.groupBox1.Controls.Add(this.numOfDaysTextBox);
            this.groupBox1.Controls.Add(frequencyLabel);
            this.groupBox1.Controls.Add(doseUnitsLabel);
            this.groupBox1.Controls.Add(refillsLabel);
            this.groupBox1.Location = new System.Drawing.Point(358, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 197);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recommendations";
            // 
            // doseTextBox
            // 
            this.doseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescriptionMasterBindingSource, "Dose", true));
            this.doseTextBox.Location = new System.Drawing.Point(101, 20);
            this.doseTextBox.Name = "doseTextBox";
            this.doseTextBox.Size = new System.Drawing.Size(200, 20);
            this.doseTextBox.TabIndex = 15;
            // 
            // refillsTextBox
            // 
            this.refillsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescriptionMasterBindingSource, "Refills", true));
            this.refillsTextBox.Location = new System.Drawing.Point(101, 165);
            this.refillsTextBox.Name = "refillsTextBox";
            this.refillsTextBox.Size = new System.Drawing.Size(200, 20);
            this.refillsTextBox.TabIndex = 31;
            // 
            // doseUnitsTextBox
            // 
            this.doseUnitsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescriptionMasterBindingSource, "DoseUnits", true));
            this.doseUnitsTextBox.Location = new System.Drawing.Point(101, 54);
            this.doseUnitsTextBox.Name = "doseUnitsTextBox";
            this.doseUnitsTextBox.Size = new System.Drawing.Size(200, 20);
            this.doseUnitsTextBox.TabIndex = 17;
            // 
            // frequencyTextBox
            // 
            this.frequencyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescriptionMasterBindingSource, "Frequency", true));
            this.frequencyTextBox.Location = new System.Drawing.Point(101, 91);
            this.frequencyTextBox.Name = "frequencyTextBox";
            this.frequencyTextBox.Size = new System.Drawing.Size(200, 20);
            this.frequencyTextBox.TabIndex = 19;
            // 
            // numOfDaysTextBox
            // 
            this.numOfDaysTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescriptionMasterBindingSource, "NumOfDays", true));
            this.numOfDaysTextBox.Location = new System.Drawing.Point(101, 130);
            this.numOfDaysTextBox.Name = "numOfDaysTextBox";
            this.numOfDaysTextBox.Size = new System.Drawing.Size(200, 20);
            this.numOfDaysTextBox.TabIndex = 21;
            // 
            // prescriptionIdTextBox
            // 
            this.prescriptionIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescriptionMasterBindingSource, "PrescriptionId", true));
            this.prescriptionIdTextBox.Location = new System.Drawing.Point(125, 17);
            this.prescriptionIdTextBox.Name = "prescriptionIdTextBox";
            this.prescriptionIdTextBox.Size = new System.Drawing.Size(203, 20);
            this.prescriptionIdTextBox.TabIndex = 1;
            // 
            // PatienInfoGroupBox
            // 
            this.PatienInfoGroupBox.Controls.Add(this.patientNameTextBox);
            this.PatienInfoGroupBox.Controls.Add(this.drugNameTextBox);
            this.PatienInfoGroupBox.Controls.Add(patientIdLabel);
            this.PatienInfoGroupBox.Controls.Add(this.patientIdTextBox);
            this.PatienInfoGroupBox.Controls.Add(drugNameLabel);
            this.PatienInfoGroupBox.Controls.Add(patientNameLabel);
            this.PatienInfoGroupBox.Controls.Add(this.allergiesTextBox);
            this.PatienInfoGroupBox.Controls.Add(diagnosisLabel);
            this.PatienInfoGroupBox.Controls.Add(allergiesLabel);
            this.PatienInfoGroupBox.Controls.Add(this.commentsTextBox);
            this.PatienInfoGroupBox.Controls.Add(commentsLabel);
            this.PatienInfoGroupBox.Controls.Add(this.diagnosisTextBox);
            this.PatienInfoGroupBox.Location = new System.Drawing.Point(22, 174);
            this.PatienInfoGroupBox.Name = "PatienInfoGroupBox";
            this.PatienInfoGroupBox.Size = new System.Drawing.Size(320, 246);
            this.PatienInfoGroupBox.TabIndex = 36;
            this.PatienInfoGroupBox.TabStop = false;
            this.PatienInfoGroupBox.Text = "Patien Info";
            // 
            // patientNameTextBox
            // 
            this.patientNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescriptionMasterBindingSource, "PatientName", true));
            this.patientNameTextBox.Location = new System.Drawing.Point(103, 57);
            this.patientNameTextBox.Name = "patientNameTextBox";
            this.patientNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.patientNameTextBox.TabIndex = 7;
            // 
            // drugNameTextBox
            // 
            this.drugNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescriptionMasterBindingSource, "DrugName", true));
            this.drugNameTextBox.Location = new System.Drawing.Point(103, 208);
            this.drugNameTextBox.Name = "drugNameTextBox";
            this.drugNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.drugNameTextBox.TabIndex = 13;
            // 
            // patientIdTextBox
            // 
            this.patientIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescriptionMasterBindingSource, "PatientId", true));
            this.patientIdTextBox.Location = new System.Drawing.Point(103, 22);
            this.patientIdTextBox.Name = "patientIdTextBox";
            this.patientIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.patientIdTextBox.TabIndex = 9;
            // 
            // allergiesTextBox
            // 
            this.allergiesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescriptionMasterBindingSource, "Allergies", true));
            this.allergiesTextBox.Location = new System.Drawing.Point(103, 93);
            this.allergiesTextBox.Name = "allergiesTextBox";
            this.allergiesTextBox.Size = new System.Drawing.Size(200, 20);
            this.allergiesTextBox.TabIndex = 27;
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescriptionMasterBindingSource, "Comments", true));
            this.commentsTextBox.Location = new System.Drawing.Point(103, 130);
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.Size = new System.Drawing.Size(200, 20);
            this.commentsTextBox.TabIndex = 29;
            // 
            // diagnosisTextBox
            // 
            this.diagnosisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescriptionMasterBindingSource, "Diagnosis", true));
            this.diagnosisTextBox.Location = new System.Drawing.Point(103, 170);
            this.diagnosisTextBox.Name = "diagnosisTextBox";
            this.diagnosisTextBox.Size = new System.Drawing.Size(200, 20);
            this.diagnosisTextBox.TabIndex = 11;
            // 
            // GridTabPage
            // 
            this.GridTabPage.Controls.Add(this.prescriptionMasterDataGridView);
            this.GridTabPage.Location = new System.Drawing.Point(4, 22);
            this.GridTabPage.Name = "GridTabPage";
            this.GridTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.GridTabPage.Size = new System.Drawing.Size(883, 470);
            this.GridTabPage.TabIndex = 1;
            this.GridTabPage.Text = "Grid View";
            this.GridTabPage.UseVisualStyleBackColor = true;
            // 
            // prescriptionMasterDataGridView
            // 
            this.prescriptionMasterDataGridView.AutoGenerateColumns = false;
            this.prescriptionMasterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prescriptionMasterDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18});
            this.prescriptionMasterDataGridView.DataSource = this.prescriptionMasterBindingSource;
            this.prescriptionMasterDataGridView.Location = new System.Drawing.Point(0, 0);
            this.prescriptionMasterDataGridView.Name = "prescriptionMasterDataGridView";
            this.prescriptionMasterDataGridView.Size = new System.Drawing.Size(880, 470);
            this.prescriptionMasterDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PrescriptionId";
            this.dataGridViewTextBoxColumn1.HeaderText = "PrescriptionId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PrescriberName";
            this.dataGridViewTextBoxColumn2.HeaderText = "PrescriberName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PhysicianId";
            this.dataGridViewTextBoxColumn3.HeaderText = "PhysicianId";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PatientName";
            this.dataGridViewTextBoxColumn4.HeaderText = "PatientName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PatientId";
            this.dataGridViewTextBoxColumn5.HeaderText = "PatientId";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Diagnosis";
            this.dataGridViewTextBoxColumn6.HeaderText = "Diagnosis";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DrugName";
            this.dataGridViewTextBoxColumn7.HeaderText = "DrugName";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Dose";
            this.dataGridViewTextBoxColumn8.HeaderText = "Dose";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "DoseUnits";
            this.dataGridViewTextBoxColumn9.HeaderText = "DoseUnits";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Frequency";
            this.dataGridViewTextBoxColumn10.HeaderText = "Frequency";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "NumOfDays";
            this.dataGridViewTextBoxColumn11.HeaderText = "NumOfDays";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "SubmitDate";
            this.dataGridViewTextBoxColumn12.HeaderText = "SubmitDate";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "ProcessedDate";
            this.dataGridViewTextBoxColumn13.HeaderText = "ProcessedDate";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Allergies";
            this.dataGridViewTextBoxColumn14.HeaderText = "Allergies";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Comments";
            this.dataGridViewTextBoxColumn15.HeaderText = "Comments";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Refills";
            this.dataGridViewTextBoxColumn16.HeaderText = "Refills";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "IssueTo";
            this.dataGridViewTextBoxColumn17.HeaderText = "IssueTo";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "PharmacyId";
            this.dataGridViewTextBoxColumn18.HeaderText = "PharmacyId";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // prescriptionMasterTableAdapter
            // 
            this.prescriptionMasterTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.@__MigrationHistoryTableAdapter = null;
            this.tableAdapterManager.AspNetResetTableAdapter = null;
            this.tableAdapterManager.AspNetRolesTableAdapter = null;
            this.tableAdapterManager.AspNetUserClaimsTableAdapter = null;
            this.tableAdapterManager.AspNetUserLoginsTableAdapter = null;
            this.tableAdapterManager.AspNetUserRolesTableAdapter = null;
            this.tableAdapterManager.AspNetUsersTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PatientMasterTableAdapter = null;
            this.tableAdapterManager.PharmacyMasterTableAdapter = null;
            this.tableAdapterManager.PhysicianMasterTableAdapter = null;
            this.tableAdapterManager.PrescriptionMasterTableAdapter = this.prescriptionMasterTableAdapter;
            this.tableAdapterManager.ScheduleMasterTableAdapter = null;
            this.tableAdapterManager.TestMasterTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = IEMHR_WFA.IEMHR_DB_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // prescriptionMasterBindingNavigator
            // 
            this.prescriptionMasterBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.prescriptionMasterBindingNavigator.BindingSource = this.prescriptionMasterBindingSource;
            this.prescriptionMasterBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.prescriptionMasterBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.prescriptionMasterBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.prescriptionMasterBindingNavigatorSaveItem});
            this.prescriptionMasterBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.prescriptionMasterBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.prescriptionMasterBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.prescriptionMasterBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.prescriptionMasterBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.prescriptionMasterBindingNavigator.Name = "prescriptionMasterBindingNavigator";
            this.prescriptionMasterBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.prescriptionMasterBindingNavigator.Size = new System.Drawing.Size(894, 25);
            this.prescriptionMasterBindingNavigator.TabIndex = 1;
            this.prescriptionMasterBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // prescriptionMasterBindingNavigatorSaveItem
            // 
            this.prescriptionMasterBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.prescriptionMasterBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("prescriptionMasterBindingNavigatorSaveItem.Image")));
            this.prescriptionMasterBindingNavigatorSaveItem.Name = "prescriptionMasterBindingNavigatorSaveItem";
            this.prescriptionMasterBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.prescriptionMasterBindingNavigatorSaveItem.Text = "Save Data";
            this.prescriptionMasterBindingNavigatorSaveItem.Click += new System.EventHandler(this.prescriptionMasterBindingNavigatorSaveItem_Click);
            // 
            // GraphTabPage
            // 
            this.GraphTabPage.Controls.Add(this.chart1);
            this.GraphTabPage.Location = new System.Drawing.Point(4, 22);
            this.GraphTabPage.Name = "GraphTabPage";
            this.GraphTabPage.Size = new System.Drawing.Size(883, 470);
            this.GraphTabPage.TabIndex = 2;
            this.GraphTabPage.Text = "Graphical View";
            this.GraphTabPage.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.prescriptionMasterBindingSource;
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Renko;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 6;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(883, 470);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // PrescriptionDetailsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 526);
            this.Controls.Add(this.prescriptionMasterBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Name = "PrescriptionDetailsFrm";
            this.Text = "Prescription_Details";
            this.Load += new System.EventHandler(this.Prescription_Details_Load);
            this.panel1.ResumeLayout(false);
            this.PrescriptionDetailsTabControl.ResumeLayout(false);
            this.DetailsTabPage.ResumeLayout(false);
            this.DetailsTabPage.PerformLayout();
            this.PhysicianGroupBox.ResumeLayout(false);
            this.PhysicianGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iEMHR_DB_DataSet)).EndInit();
            this.DateGroupBox.ResumeLayout(false);
            this.DateGroupBox.PerformLayout();
            this.PharmacyGroupBox.ResumeLayout(false);
            this.PharmacyGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PatienInfoGroupBox.ResumeLayout(false);
            this.PatienInfoGroupBox.PerformLayout();
            this.GridTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionMasterDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionMasterBindingNavigator)).EndInit();
            this.prescriptionMasterBindingNavigator.ResumeLayout(false);
            this.prescriptionMasterBindingNavigator.PerformLayout();
            this.GraphTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private IEMHR_DB_DataSet iEMHR_DB_DataSet;
        private System.Windows.Forms.BindingSource prescriptionMasterBindingSource;
        private IEMHR_DB_DataSetTableAdapters.PrescriptionMasterTableAdapter prescriptionMasterTableAdapter;
        private IEMHR_DB_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator prescriptionMasterBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton prescriptionMasterBindingNavigatorSaveItem;
        private System.Windows.Forms.TabControl PrescriptionDetailsTabControl;
        private System.Windows.Forms.TabPage DetailsTabPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox drugNameTextBox;
        private System.Windows.Forms.TextBox doseTextBox;
        private System.Windows.Forms.TextBox diagnosisTextBox;
        private System.Windows.Forms.TextBox refillsTextBox;
        private System.Windows.Forms.TextBox doseUnitsTextBox;
        private System.Windows.Forms.TextBox frequencyTextBox;
        private System.Windows.Forms.TextBox numOfDaysTextBox;
        private System.Windows.Forms.TextBox prescriptionIdTextBox;
        private System.Windows.Forms.GroupBox PatienInfoGroupBox;
        private System.Windows.Forms.TextBox patientNameTextBox;
        private System.Windows.Forms.TextBox patientIdTextBox;
        private System.Windows.Forms.TextBox allergiesTextBox;
        private System.Windows.Forms.TextBox commentsTextBox;
        private System.Windows.Forms.TextBox prescriberNameTextBox;
        private System.Windows.Forms.TextBox physicianIdTextBox;
        private System.Windows.Forms.TextBox issueToTextBox;
        private System.Windows.Forms.TextBox pharmacyIdTextBox;
        private System.Windows.Forms.DateTimePicker submitDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker processedDateDateTimePicker;
        private System.Windows.Forms.TabPage GridTabPage;
        private System.Windows.Forms.GroupBox PharmacyGroupBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView prescriptionMasterDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.GroupBox PhysicianGroupBox;
        private System.Windows.Forms.GroupBox DateGroupBox;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnImportExport;
        private System.Windows.Forms.TabPage GraphTabPage;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}