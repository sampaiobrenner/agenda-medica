using System.Windows.Forms;

namespace AgendaMedica
{
    partial class Pesquisar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pesquisar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnUpdate = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblTimerTicker = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabPesquisar = new System.Windows.Forms.TabControl();
            this.tabConsultas = new System.Windows.Forms.TabPage();
            this.dtpDataConsulta = new System.Windows.Forms.DateTimePicker();
            this.btnPesquisarConsultas = new System.Windows.Forms.Button();
            this.dtgListaConsultas = new System.Windows.Forms.DataGridView();
            this.colDataConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConvenio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPesquisarPaciente = new System.Windows.Forms.TabPage();
            this.btnPesquisarPaciente = new System.Windows.Forms.Button();
            this.dtgListaPacientes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomePacientePesquisa = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnPesquisarMedico = new System.Windows.Forms.Button();
            this.dtgListaMedicos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeMedicoPesquisa = new System.Windows.Forms.TextBox();
            this.agendaMedicaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agendaMedicaDataSet = new AgendaMedica.agendaMedicaDataSet();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.colIdMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmailMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCelMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomePaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmailPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCelPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPesquisar.SuspendLayout();
            this.tabConsultas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaConsultas)).BeginInit();
            this.tabPesquisarPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaPacientes)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaMedicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaMedicaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaMedicaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip2);
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 293);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 73);
            this.panel1.TabIndex = 0;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUpdate,
            this.btnDelete,
            this.toolStripSeparator2,
            this.btnExit});
            this.toolStrip2.Location = new System.Drawing.Point(0, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(626, 48);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = false;
            this.btnUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(40, 40);
            this.btnUpdate.Text = "Alterar";
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = false;
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(36, 36);
            this.btnDelete.Text = "Excluir";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 48);
            // 
            // btnExit
            // 
            this.btnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnExit.AutoSize = false;
            this.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 40);
            this.btnExit.Text = "Sair";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTimerTicker});
            this.statusStrip1.Location = new System.Drawing.Point(0, 51);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(626, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblTimerTicker
            // 
            this.lblTimerTicker.Name = "lblTimerTicker";
            this.lblTimerTicker.Size = new System.Drawing.Size(83, 17);
            this.lblTimerTicker.Text = "lblTimerTicker";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabPesquisar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(626, 293);
            this.panel2.TabIndex = 1;
            // 
            // tabPesquisar
            // 
            this.tabPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPesquisar.Controls.Add(this.tabConsultas);
            this.tabPesquisar.Controls.Add(this.tabPesquisarPaciente);
            this.tabPesquisar.Controls.Add(this.tabPage1);
            this.tabPesquisar.Location = new System.Drawing.Point(0, 0);
            this.tabPesquisar.Name = "tabPesquisar";
            this.tabPesquisar.SelectedIndex = 0;
            this.tabPesquisar.Size = new System.Drawing.Size(626, 293);
            this.tabPesquisar.TabIndex = 0;
            // 
            // tabConsultas
            // 
            this.tabConsultas.Controls.Add(this.dtpDataConsulta);
            this.tabConsultas.Controls.Add(this.btnPesquisarConsultas);
            this.tabConsultas.Controls.Add(this.dtgListaConsultas);
            this.tabConsultas.Location = new System.Drawing.Point(4, 22);
            this.tabConsultas.Name = "tabConsultas";
            this.tabConsultas.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsultas.Size = new System.Drawing.Size(618, 267);
            this.tabConsultas.TabIndex = 0;
            this.tabConsultas.Text = "Consultas";
            this.tabConsultas.UseVisualStyleBackColor = true;
            // 
            // dtpDataConsulta
            // 
            this.dtpDataConsulta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataConsulta.Location = new System.Drawing.Point(20, 11);
            this.dtpDataConsulta.MinDate = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.dtpDataConsulta.Name = "dtpDataConsulta";
            this.dtpDataConsulta.Size = new System.Drawing.Size(101, 22);
            this.dtpDataConsulta.TabIndex = 4;
            // 
            // btnPesquisarConsultas
            // 
            this.btnPesquisarConsultas.Location = new System.Drawing.Point(136, 11);
            this.btnPesquisarConsultas.Name = "btnPesquisarConsultas";
            this.btnPesquisarConsultas.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarConsultas.TabIndex = 3;
            this.btnPesquisarConsultas.Text = "Pesquisar";
            this.btnPesquisarConsultas.UseVisualStyleBackColor = true;
            this.btnPesquisarConsultas.Click += new System.EventHandler(this.btnPesquisarConsultas_Click);
            // 
            // dtgListaConsultas
            // 
            this.dtgListaConsultas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgListaConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListaConsultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDataConsulta,
            this.colPaciente,
            this.colMedico,
            this.colConvenio,
            this.colIdConsulta});
            this.dtgListaConsultas.Location = new System.Drawing.Point(20, 48);
            this.dtgListaConsultas.Name = "dtgListaConsultas";
            this.dtgListaConsultas.Size = new System.Drawing.Size(577, 193);
            this.dtgListaConsultas.TabIndex = 2;
            // 
            // colDataConsulta
            // 
            this.colDataConsulta.HeaderText = "Data Consulta";
            this.colDataConsulta.Name = "colDataConsulta";
            this.colDataConsulta.ReadOnly = true;
            // 
            // colPaciente
            // 
            this.colPaciente.FillWeight = 200F;
            this.colPaciente.HeaderText = "Paciente";
            this.colPaciente.Name = "colPaciente";
            this.colPaciente.ReadOnly = true;
            this.colPaciente.Width = 200;
            // 
            // colMedico
            // 
            this.colMedico.HeaderText = "Médico";
            this.colMedico.Name = "colMedico";
            this.colMedico.ReadOnly = true;
            this.colMedico.Width = 200;
            // 
            // colConvenio
            // 
            this.colConvenio.HeaderText = "Convênio";
            this.colConvenio.Name = "colConvenio";
            this.colConvenio.ReadOnly = true;
            this.colConvenio.Width = 130;
            // 
            // colIdConsulta
            // 
            this.colIdConsulta.HeaderText = "idConsulta";
            this.colIdConsulta.Name = "colIdConsulta";
            this.colIdConsulta.Visible = false;
            // 
            // tabPesquisarPaciente
            // 
            this.tabPesquisarPaciente.Controls.Add(this.btnPesquisarPaciente);
            this.tabPesquisarPaciente.Controls.Add(this.dtgListaPacientes);
            this.tabPesquisarPaciente.Controls.Add(this.label1);
            this.tabPesquisarPaciente.Controls.Add(this.txtNomePacientePesquisa);
            this.tabPesquisarPaciente.Location = new System.Drawing.Point(4, 22);
            this.tabPesquisarPaciente.Name = "tabPesquisarPaciente";
            this.tabPesquisarPaciente.Padding = new System.Windows.Forms.Padding(3);
            this.tabPesquisarPaciente.Size = new System.Drawing.Size(618, 267);
            this.tabPesquisarPaciente.TabIndex = 1;
            this.tabPesquisarPaciente.Text = "Pacientes";
            this.tabPesquisarPaciente.UseVisualStyleBackColor = true;
            // 
            // btnPesquisarPaciente
            // 
            this.btnPesquisarPaciente.Location = new System.Drawing.Point(524, 18);
            this.btnPesquisarPaciente.Name = "btnPesquisarPaciente";
            this.btnPesquisarPaciente.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarPaciente.TabIndex = 7;
            this.btnPesquisarPaciente.Text = "Pesquisar";
            this.btnPesquisarPaciente.UseVisualStyleBackColor = true;
            this.btnPesquisarPaciente.Click += new System.EventHandler(this.btnPesquisar_click);
            // 
            // dtgListaPacientes
            // 
            this.dtgListaPacientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgListaPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListaPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdPaciente,
            this.colNomePaciente,
            this.colEmailPaciente,
            this.colTelPaciente,
            this.colCelPaciente});
            this.dtgListaPacientes.Location = new System.Drawing.Point(22, 56);
            this.dtgListaPacientes.Name = "dtgListaPacientes";
            this.dtgListaPacientes.Size = new System.Drawing.Size(577, 193);
            this.dtgListaPacientes.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome";
            // 
            // txtNomePacientePesquisa
            // 
            this.txtNomePacientePesquisa.Location = new System.Drawing.Point(58, 20);
            this.txtNomePacientePesquisa.Name = "txtNomePacientePesquisa";
            this.txtNomePacientePesquisa.Size = new System.Drawing.Size(458, 20);
            this.txtNomePacientePesquisa.TabIndex = 4;
            this.txtNomePacientePesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDownEnterPaciente);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnPesquisarMedico);
            this.tabPage1.Controls.Add(this.dtgListaMedicos);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtNomeMedicoPesquisa);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(618, 267);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Médicos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnPesquisarMedico
            // 
            this.btnPesquisarMedico.Location = new System.Drawing.Point(524, 18);
            this.btnPesquisarMedico.Name = "btnPesquisarMedico";
            this.btnPesquisarMedico.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarMedico.TabIndex = 7;
            this.btnPesquisarMedico.Text = "Pesquisar";
            this.btnPesquisarMedico.UseVisualStyleBackColor = true;
            this.btnPesquisarMedico.Click += new System.EventHandler(this.btnPesquisarMedico_Click);
            // 
            // dtgListaMedicos
            // 
            this.dtgListaMedicos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgListaMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListaMedicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdMedico,
            this.colNomeMedico,
            this.colEmailMedico,
            this.colTelMedico,
            this.colCelMedico});
            this.dtgListaMedicos.Location = new System.Drawing.Point(22, 56);
            this.dtgListaMedicos.Name = "dtgListaMedicos";
            this.dtgListaMedicos.Size = new System.Drawing.Size(577, 193);
            this.dtgListaMedicos.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome";
            // 
            // txtNomeMedicoPesquisa
            // 
            this.txtNomeMedicoPesquisa.Location = new System.Drawing.Point(58, 20);
            this.txtNomeMedicoPesquisa.Name = "txtNomeMedicoPesquisa";
            this.txtNomeMedicoPesquisa.Size = new System.Drawing.Size(458, 20);
            this.txtNomeMedicoPesquisa.TabIndex = 4;
            this.txtNomeMedicoPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDownEnterMedico);
            // 
            // agendaMedicaDataSetBindingSource
            // 
            this.agendaMedicaDataSetBindingSource.DataSource = this.agendaMedicaDataSet;
            this.agendaMedicaDataSetBindingSource.Position = 0;
            // 
            // agendaMedicaDataSet
            // 
            this.agendaMedicaDataSet.DataSetName = "agendaMedicaDataSet";
            this.agendaMedicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // colIdMedico
            // 
            this.colIdMedico.HeaderText = "IdMedico";
            this.colIdMedico.Name = "colIdMedico";
            this.colIdMedico.ReadOnly = true;
            this.colIdMedico.Visible = false;
            // 
            // colNomeMedico
            // 
            this.colNomeMedico.HeaderText = "Nome";
            this.colNomeMedico.Name = "colNomeMedico";
            this.colNomeMedico.ReadOnly = true;
            this.colNomeMedico.Width = 200;
            // 
            // colEmailMedico
            // 
            this.colEmailMedico.HeaderText = "Email";
            this.colEmailMedico.Name = "colEmailMedico";
            this.colEmailMedico.ReadOnly = true;
            this.colEmailMedico.Width = 200;
            // 
            // colTelMedico
            // 
            this.colTelMedico.HeaderText = "Telefone";
            this.colTelMedico.Name = "colTelMedico";
            this.colTelMedico.ReadOnly = true;
            this.colTelMedico.Width = 130;
            // 
            // colCelMedico
            // 
            this.colCelMedico.HeaderText = "Celular";
            this.colCelMedico.Name = "colCelMedico";
            this.colCelMedico.ReadOnly = true;
            this.colCelMedico.Width = 130;
            // 
            // colIdPaciente
            // 
            this.colIdPaciente.HeaderText = "IdPaciente";
            this.colIdPaciente.Name = "colIdPaciente";
            this.colIdPaciente.Visible = false;
            // 
            // colNomePaciente
            // 
            this.colNomePaciente.HeaderText = "Nome";
            this.colNomePaciente.Name = "colNomePaciente";
            this.colNomePaciente.ReadOnly = true;
            this.colNomePaciente.Width = 200;
            // 
            // colEmailPaciente
            // 
            this.colEmailPaciente.HeaderText = "E-mail";
            this.colEmailPaciente.Name = "colEmailPaciente";
            this.colEmailPaciente.ReadOnly = true;
            this.colEmailPaciente.Width = 130;
            // 
            // colTelPaciente
            // 
            this.colTelPaciente.HeaderText = "Telefone";
            this.colTelPaciente.Name = "colTelPaciente";
            this.colTelPaciente.ReadOnly = true;
            this.colTelPaciente.Width = 130;
            // 
            // colCelPaciente
            // 
            this.colCelPaciente.HeaderText = "Celular";
            this.colCelPaciente.Name = "colCelPaciente";
            this.colCelPaciente.ReadOnly = true;
            this.colCelPaciente.Width = 130;
            // 
            // Pesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 366);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pesquisar";
            this.Text = "Pesquisar";
            this.Load += new System.EventHandler(this.Pesquisar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabPesquisar.ResumeLayout(false);
            this.tabConsultas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaConsultas)).EndInit();
            this.tabPesquisarPaciente.ResumeLayout(false);
            this.tabPesquisarPaciente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaPacientes)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaMedicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaMedicaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaMedicaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnUpdate;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripStatusLabel lblTimerTicker;
        private System.Windows.Forms.TabControl tabPesquisar;
        private System.Windows.Forms.TabPage tabConsultas;
        private System.Windows.Forms.TabPage tabPesquisarPaciente;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnPesquisarConsultas;
        private System.Windows.Forms.Button btnPesquisarPaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomePacientePesquisa;
        private System.Windows.Forms.Button btnPesquisarMedico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeMedicoPesquisa;
        private System.Windows.Forms.BindingSource agendaMedicaDataSetBindingSource;
        private agendaMedicaDataSet agendaMedicaDataSet;
        public System.Windows.Forms.DateTimePicker dtpDataConsulta;
        public System.Windows.Forms.DataGridView dtgListaConsultas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConvenio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdConsulta;
        public System.Windows.Forms.DataGridView dtgListaPacientes;
        private DataGridViewTextBoxColumn colIdPaciente;
        private DataGridViewTextBoxColumn colNomePaciente;
        private DataGridViewTextBoxColumn colEmailPaciente;
        private DataGridViewTextBoxColumn colTelPaciente;
        private DataGridViewTextBoxColumn colCelPaciente;
        private DataGridViewTextBoxColumn colIdMedico;
        private DataGridViewTextBoxColumn colNomeMedico;
        private DataGridViewTextBoxColumn colEmailMedico;
        private DataGridViewTextBoxColumn colTelMedico;
        private DataGridViewTextBoxColumn colCelMedico;
        public DataGridView dtgListaMedicos;
    }
}