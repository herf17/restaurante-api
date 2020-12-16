namespace Parcial1
{
    partial class EstadoMesaO
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnanular = new System.Windows.Forms.Button();
            this.btnculm = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridview = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 273);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 100);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnanular, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnculm, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(795, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnanular
            // 
            this.btnanular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnanular.Location = new System.Drawing.Point(3, 3);
            this.btnanular.Name = "btnanular";
            this.btnanular.Size = new System.Drawing.Size(391, 94);
            this.btnanular.TabIndex = 0;
            this.btnanular.Text = "Anular";
            this.btnanular.UseVisualStyleBackColor = true;
            this.btnanular.Click += new System.EventHandler(this.btnanular_Click);
            // 
            // btnculm
            // 
            this.btnculm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnculm.Location = new System.Drawing.Point(400, 3);
            this.btnculm.Name = "btnculm";
            this.btnculm.Size = new System.Drawing.Size(392, 94);
            this.btnculm.TabIndex = 1;
            this.btnculm.Text = "Culminar";
            this.btnculm.UseVisualStyleBackColor = true;
            this.btnculm.Click += new System.EventHandler(this.btnculm_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridview);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(795, 273);
            this.panel2.TabIndex = 1;
            // 
            // gridview
            // 
            this.gridview.AllowUserToAddRows = false;
            this.gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridview.Location = new System.Drawing.Point(0, 0);
            this.gridview.Name = "gridview";
            this.gridview.ReadOnly = true;
            this.gridview.Size = new System.Drawing.Size(795, 273);
            this.gridview.TabIndex = 0;
            this.gridview.Text = "dataGridView1";
            // 
            // EstadoMesaO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 373);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "EstadoMesaO";
            this.Text = "EstadoMesaO";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnanular;
        private System.Windows.Forms.Button btnculm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView gridview;
    }
}