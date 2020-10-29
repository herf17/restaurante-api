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
            this.tabEntr = new System.Windows.Forms.TabPage();
            this.flpCentra = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPf = new System.Windows.Forms.TabPage();
            this.flpCplatosfue = new System.Windows.Forms.FlowLayoutPanel();
            this.tabBebid = new System.Windows.Forms.TabPage();
            this.flpCbebidas = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPostr = new System.Windows.Forms.TabPage();
            this.flpCpostres = new System.Windows.Forms.FlowLayoutPanel();
            this.flpProductos = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colDescrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colimpo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabEntr.SuspendLayout();
            this.tabPf.SuspendLayout();
            this.tabBebid.SuspendLayout();
            this.tabPostr.SuspendLayout();
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
            this.tabControl1.Controls.Add(this.tabEntr);
            this.tabControl1.Controls.Add(this.tabPf);
            this.tabControl1.Controls.Add(this.tabBebid);
            this.tabControl1.Controls.Add(this.tabPostr);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(582, 197);
            this.tabControl1.TabIndex = 0;
            // 
            // tabEntr
            // 
            this.tabEntr.Controls.Add(this.flpCentra);
            this.tabEntr.Location = new System.Drawing.Point(4, 24);
            this.tabEntr.Name = "tabEntr";
            this.tabEntr.Padding = new System.Windows.Forms.Padding(3);
            this.tabEntr.Size = new System.Drawing.Size(574, 169);
            this.tabEntr.TabIndex = 0;
            this.tabEntr.Text = "Entradas";
            this.tabEntr.UseVisualStyleBackColor = true;
            // 
            // flpCentra
            // 
            this.flpCentra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpCentra.Location = new System.Drawing.Point(3, 3);
            this.flpCentra.Name = "flpCentra";
            this.flpCentra.Size = new System.Drawing.Size(568, 163);
            this.flpCentra.TabIndex = 0;
            this.flpCentra.Paint += new System.Windows.Forms.PaintEventHandler(this.flpCentra_Paint);
            // 
            // tabPf
            // 
            this.tabPf.Controls.Add(this.flpCplatosfue);
            this.tabPf.Location = new System.Drawing.Point(4, 24);
            this.tabPf.Name = "tabPf";
            this.tabPf.Size = new System.Drawing.Size(574, 169);
            this.tabPf.TabIndex = 2;
            this.tabPf.Text = "Platos fuertes";
            // 
            // flpCplatosfue
            // 
            this.flpCplatosfue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpCplatosfue.Location = new System.Drawing.Point(0, 0);
            this.flpCplatosfue.Name = "flpCplatosfue";
            this.flpCplatosfue.Size = new System.Drawing.Size(574, 169);
            this.flpCplatosfue.TabIndex = 0;
            // 
            // tabBebid
            // 
            this.tabBebid.Controls.Add(this.flpCbebidas);
            this.tabBebid.Location = new System.Drawing.Point(4, 24);
            this.tabBebid.Name = "tabBebid";
            this.tabBebid.Padding = new System.Windows.Forms.Padding(3);
            this.tabBebid.Size = new System.Drawing.Size(574, 169);
            this.tabBebid.TabIndex = 1;
            this.tabBebid.Text = "Bebidas";
            this.tabBebid.UseVisualStyleBackColor = true;
            // 
            // flpCbebidas
            // 
            this.flpCbebidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpCbebidas.Location = new System.Drawing.Point(3, 3);
            this.flpCbebidas.Name = "flpCbebidas";
            this.flpCbebidas.Size = new System.Drawing.Size(568, 163);
            this.flpCbebidas.TabIndex = 0;
            // 
            // tabPostr
            // 
            this.tabPostr.Controls.Add(this.flpCpostres);
            this.tabPostr.Location = new System.Drawing.Point(4, 24);
            this.tabPostr.Name = "tabPostr";
            this.tabPostr.Size = new System.Drawing.Size(574, 169);
            this.tabPostr.TabIndex = 3;
            this.tabPostr.Text = "Postres";
            // 
            // flpCpostres
            // 
            this.flpCpostres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpCpostres.Location = new System.Drawing.Point(0, 0);
            this.flpCpostres.Name = "flpCpostres";
            this.flpCpostres.Size = new System.Drawing.Size(574, 169);
            this.flpCpostres.TabIndex = 0;
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
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 272);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 146);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total a pagar";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Importe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total a pagar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(164, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(164, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDescrip,
            this.colCan,
            this.colPu,
            this.colimpo});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(273, 418);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Text = "dataGridView1";
            // 
            // colDescrip
            // 
            this.colDescrip.HeaderText = "Descripcion";
            this.colDescrip.Name = "colDescrip";
            // 
            // colCan
            // 
            this.colCan.HeaderText = "Cant.";
            this.colCan.Name = "colCan";
            // 
            // colPu
            // 
            this.colPu.HeaderText = "P.U.";
            this.colPu.Name = "colPu";
            // 
            // colimpo
            // 
            this.colimpo.HeaderText = "Importe";
            this.colimpo.Name = "colimpo";
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
            this.tabEntr.ResumeLayout(false);
            this.tabPf.ResumeLayout(false);
            this.tabBebid.ResumeLayout(false);
            this.tabPostr.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage tabEntr;
        private System.Windows.Forms.TabPage tabBebid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colimpo;
        private System.Windows.Forms.FlowLayoutPanel flpCentra;
        private System.Windows.Forms.FlowLayoutPanel flpCbebidas;
        private System.Windows.Forms.FlowLayoutPanel flpProductos;
        private System.Windows.Forms.TabPage tabPf;
        private System.Windows.Forms.FlowLayoutPanel flpCplatosfue;
        private System.Windows.Forms.TabPage tabPostr;
        private System.Windows.Forms.FlowLayoutPanel flpCpostres;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

