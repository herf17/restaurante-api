namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPf = new System.Windows.Forms.TabPage();
            this.flpCplatosfue = new System.Windows.Forms.FlowLayoutPanel();
            this.flpProductos = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btcompra = new System.Windows.Forms.Button();
            this.txtidcli = new System.Windows.Forms.TextBox();
            this.lbpunts = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbnombre = new System.Windows.Forms.Label();
            this.btcli = new System.Windows.Forms.Button();
            this.btnelim = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbtotal = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idproducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.canti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPf.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.875F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.125F));
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 402F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(867, 424);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flpProductos);
            this.splitContainer1.Size = new System.Drawing.Size(582, 418);
            this.splitContainer1.SplitterDistance = 197;
            this.splitContainer1.TabIndex = 1;
            this.splitContainer1.Text = "splitContainer1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPf);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(582, 197);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPf
            // 
            this.tabPf.Controls.Add(this.flpCplatosfue);
            this.tabPf.Location = new System.Drawing.Point(4, 24);
            this.tabPf.Name = "tabPf";
            this.tabPf.Size = new System.Drawing.Size(574, 169);
            this.tabPf.TabIndex = 2;
            this.tabPf.Text = "Categorias";
            // 
            // flpCplatosfue
            // 
            this.flpCplatosfue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpCplatosfue.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.flpCplatosfue.Location = new System.Drawing.Point(0, 0);
            this.flpCplatosfue.Name = "flpCplatosfue";
            this.flpCplatosfue.Size = new System.Drawing.Size(574, 169);
            this.flpCplatosfue.TabIndex = 0;
            // 
            // flpProductos
            // 
            this.flpProductos.AutoScroll = true;
            this.flpProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpProductos.Location = new System.Drawing.Point(0, 0);
            this.flpProductos.Name = "flpProductos";
            this.flpProductos.Size = new System.Drawing.Size(582, 217);
            this.flpProductos.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(591, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 418);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btcompra);
            this.panel2.Controls.Add(this.txtidcli);
            this.panel2.Controls.Add(this.lbpunts);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lbnombre);
            this.panel2.Controls.Add(this.btcli);
            this.panel2.Controls.Add(this.btnelim);
            this.panel2.Controls.Add(this.btnedit);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txbtotal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 272);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 146);
            this.panel2.TabIndex = 1;
            // 
            // btcompra
            // 
            this.btcompra.Location = new System.Drawing.Point(20, 114);
            this.btcompra.Name = "btcompra";
            this.btcompra.Size = new System.Drawing.Size(75, 23);
            this.btcompra.TabIndex = 11;
            this.btcompra.Text = "Guardar";
            this.btcompra.UseVisualStyleBackColor = true;
            this.btcompra.Click += new System.EventHandler(this.btcompra_Click);
            // 
            // txtidcli
            // 
            this.txtidcli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtidcli.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtidcli.Location = new System.Drawing.Point(20, 31);
            this.txtidcli.Name = "txtidcli";
            this.txtidcli.Size = new System.Drawing.Size(100, 23);
            this.txtidcli.TabIndex = 1;
            // 
            // lbpunts
            // 
            this.lbpunts.AutoSize = true;
            this.lbpunts.Location = new System.Drawing.Point(245, 57);
            this.lbpunts.Name = "lbpunts";
            this.lbpunts.Size = new System.Drawing.Size(0, 15);
            this.lbpunts.TabIndex = 10;
            this.lbpunts.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Puntos:";
            // 
            // lbnombre
            // 
            this.lbnombre.AutoSize = true;
            this.lbnombre.Location = new System.Drawing.Point(101, 57);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(0, 15);
            this.lbnombre.TabIndex = 8;
            // 
            // btcli
            // 
            this.btcli.Location = new System.Drawing.Point(20, 60);
            this.btcli.Name = "btcli";
            this.btcli.Size = new System.Drawing.Size(75, 23);
            this.btcli.TabIndex = 7;
            this.btcli.Text = "Cliente";
            this.btcli.UseVisualStyleBackColor = true;
            this.btcli.Click += new System.EventHandler(this.btcli_Click);
            // 
            // btnelim
            // 
            this.btnelim.Location = new System.Drawing.Point(164, 4);
            this.btnelim.Name = "btnelim";
            this.btnelim.Size = new System.Drawing.Size(75, 23);
            this.btnelim.TabIndex = 6;
            this.btnelim.Text = "Eliminar";
            this.btnelim.UseVisualStyleBackColor = true;
            this.btnelim.Click += new System.EventHandler(this.btnelim_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(20, 6);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 22);
            this.btnedit.TabIndex = 5;
            this.btnedit.Text = "Editar";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(72, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total a pagar";
            // 
<<<<<<< HEAD
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(72, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Importe";
            // 
=======
>>>>>>> f8bf9d364f5500e1629f5d5c7f52450607b6b2e9
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(45, 10);
            this.label1.Name = "label1";
<<<<<<< HEAD
            this.label1.Size = new System.Drawing.Size(83, 15);
=======
            this.label1.Size = new System.Drawing.Size(0, 15);
>>>>>>> f8bf9d364f5500e1629f5d5c7f52450607b6b2e9
            this.label1.TabIndex = 2;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbtotal
            // 
            this.txbtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbtotal.Location = new System.Drawing.Point(164, 96);
            this.txbtotal.Name = "txbtotal";
            this.txbtotal.Size = new System.Drawing.Size(100, 23);
            this.txbtotal.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproducto,
            this.Descripc,
            this.canti,
            this.preci});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(273, 418);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Text = "dataGridView1";
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idproducto
            // 
            this.idproducto.HeaderText = "idprod";
            this.idproducto.Name = "idproducto";
            this.idproducto.ReadOnly = true;
            this.idproducto.Visible = false;
            // 
            // Descripc
            // 
            this.Descripc.HeaderText = "Decripción";
            this.Descripc.Name = "Descripc";
            this.Descripc.ReadOnly = true;
            // 
            // canti
            // 
            this.canti.HeaderText = "Cantidad";
            this.canti.Name = "canti";
            this.canti.ReadOnly = true;
            // 
            // preci
            // 
            this.preci.HeaderText = "Precio Uni.";
            this.preci.Name = "preci";
            this.preci.ReadOnly = true;
            // 
            // id
            // 
            this.id.HeaderText = "";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 424);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPf.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbtotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flpProductos;
        private System.Windows.Forms.TabPage tabPf;
        private System.Windows.Forms.FlowLayoutPanel flpCplatosfue;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripc;
        private System.Windows.Forms.DataGridViewTextBoxColumn canti;
        private System.Windows.Forms.DataGridViewTextBoxColumn preci;
        private System.Windows.Forms.Button btnelim;
        private System.Windows.Forms.Button btcli;
        private System.Windows.Forms.Label lbpunts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbnombre;
        private System.Windows.Forms.TextBox txtidcli;
        private System.Windows.Forms.Button btcompra;
    }
}

