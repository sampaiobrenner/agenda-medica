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
            this.dtgListaConsultas = new System.Windows.Forms.DataGridView();
            this.lblNomePesquisa = new System.Windows.Forms.Label();
            this.txtNomePesquisa = new System.Windows.Forms.TextBox();
            this.tabPesquisarPaciente = new System.Windows.Forms.TabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnPesquisarConsultas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPesquisar.SuspendLayout();
            this.tabConsultas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaConsultas)).BeginInit();
            this.tabPesquisarPaciente.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.tabConsultas.Controls.Add(this.btnPesquisarConsultas);
            this.tabConsultas.Controls.Add(this.dtgListaConsultas);
            this.tabConsultas.Controls.Add(this.lblNomePesquisa);
            this.tabConsultas.Controls.Add(this.txtNomePesquisa);
            this.tabConsultas.Location = new System.Drawing.Point(4, 22);
            this.tabConsultas.Name = "tabConsultas";
            this.tabConsultas.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsultas.Size = new System.Drawing.Size(618, 267);
            this.tabConsultas.TabIndex = 0;
            this.tabConsultas.Text = "Consultas";
            this.tabConsultas.UseVisualStyleBackColor = true;
            // 
            // dtgListaConsultas
            // 
            this.dtgListaConsultas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgListaConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListaConsultas.Location = new System.Drawing.Point(20, 48);
            this.dtgListaConsultas.Name = "dtgListaConsultas";
            this.dtgListaConsultas.Size = new System.Drawing.Size(577, 193);
            this.dtgListaConsultas.TabIndex = 2;
            // 
            // lblNomePesquisa
            // 
            this.lblNomePesquisa.AutoSize = true;
            this.lblNomePesquisa.Location = new System.Drawing.Point(17, 15);
            this.lblNomePesquisa.Name = "lblNomePesquisa";
            this.lblNomePesquisa.Size = new System.Drawing.Size(35, 13);
            this.lblNomePesquisa.TabIndex = 1;
            this.lblNomePesquisa.Text = "Nome";
            this.lblNomePesquisa.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNomePesquisa
            // 
            this.txtNomePesquisa.Location = new System.Drawing.Point(56, 12);
            this.txtNomePesquisa.Name = "txtNomePesquisa";
            this.txtNomePesquisa.Size = new System.Drawing.Size(458, 20);
            this.txtNomePesquisa.TabIndex = 0;
            // 
            // tabPesquisarPaciente
            // 
            this.tabPesquisarPaciente.Controls.Add(this.button1);
            this.tabPesquisarPaciente.Controls.Add(this.dataGridView1);
            this.tabPesquisarPaciente.Controls.Add(this.label1);
            this.tabPesquisarPaciente.Controls.Add(this.textBox1);
            this.tabPesquisarPaciente.Location = new System.Drawing.Point(4, 22);
            this.tabPesquisarPaciente.Name = "tabPesquisarPaciente";
            this.tabPesquisarPaciente.Padding = new System.Windows.Forms.Padding(3);
            this.tabPesquisarPaciente.Size = new System.Drawing.Size(618, 267);
            this.tabPesquisarPaciente.TabIndex = 1;
            this.tabPesquisarPaciente.Text = "Pacientes";
            this.tabPesquisarPaciente.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(618, 267);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Médicos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnPesquisarConsultas
            // 
            this.btnPesquisarConsultas.Location = new System.Drawing.Point(522, 10);
            this.btnPesquisarConsultas.Name = "btnPesquisarConsultas";
            this.btnPesquisarConsultas.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarConsultas.TabIndex = 3;
            this.btnPesquisarConsultas.Text = "Pesquisar";
            this.btnPesquisarConsultas.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(524, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(577, 193);
            this.dataGridView1.TabIndex = 6;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(58, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(458, 20);
            this.textBox1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(524, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Pesquisar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(22, 56);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(577, 193);
            this.dataGridView2.TabIndex = 6;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(58, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(458, 20);
            this.textBox2.TabIndex = 4;
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
            this.tabConsultas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaConsultas)).EndInit();
            this.tabPesquisarPaciente.ResumeLayout(false);
            this.tabPesquisarPaciente.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.Label lblNomePesquisa;
        private System.Windows.Forms.TextBox txtNomePesquisa;
        private System.Windows.Forms.DataGridView dtgListaConsultas;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnPesquisarConsultas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
    }
}