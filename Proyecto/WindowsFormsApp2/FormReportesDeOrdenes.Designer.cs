namespace Parcial1
{
    partial class FormReportesDeOrdenes
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.dgvReportesDeOrdenes = new System.Windows.Forms.DataGridView();
            this.ColumnIdOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFechaHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNumeroDeMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportesDeOrdenes)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(283, 323);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Borrar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Descripción del producto";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.Width = 205;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Precio Unitario";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.Width = 134;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Precio Total";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.Width = 115;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btnImprimir);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dgvReportesDeOrdenes);
            this.groupBox1.Location = new System.Drawing.Point(10, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(915, 370);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnImprimir.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnImprimir.Location = new System.Drawing.Point(539, 323);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(90, 29);
            this.btnImprimir.TabIndex = 1;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            // 
            // dgvReportesDeOrdenes
            // 
            this.dgvReportesDeOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportesDeOrdenes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIdOrden,
            this.ColumnFechaHora,
            this.ColumnTotal,
            this.ColumnUsuario,
            this.ColumnNumeroDeMesa,
            this.ColumnCliente,
            this.ColumnEstado});
            this.dgvReportesDeOrdenes.Location = new System.Drawing.Point(46, 31);
            this.dgvReportesDeOrdenes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvReportesDeOrdenes.Name = "dgvReportesDeOrdenes";
            this.dgvReportesDeOrdenes.RowHeadersWidth = 51;
            this.dgvReportesDeOrdenes.Size = new System.Drawing.Size(835, 268);
            this.dgvReportesDeOrdenes.TabIndex = 0;
            this.dgvReportesDeOrdenes.Text = "dataGridView1";
            // 
            // ColumnIdOrden
            // 
            this.ColumnIdOrden.HeaderText = "IdOrden";
            this.ColumnIdOrden.MinimumWidth = 6;
            this.ColumnIdOrden.Name = "ColumnIdOrden";
            this.ColumnIdOrden.ReadOnly = true;
            this.ColumnIdOrden.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnIdOrden.Width = 125;
            // 
            // ColumnFechaHora
            // 
            this.ColumnFechaHora.HeaderText = "Fecha Hora";
            this.ColumnFechaHora.MinimumWidth = 6;
            this.ColumnFechaHora.Name = "ColumnFechaHora";
            this.ColumnFechaHora.ReadOnly = true;
            this.ColumnFechaHora.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnFechaHora.Width = 125;
            // 
            // ColumnTotal
            // 
            this.ColumnTotal.HeaderText = "Total";
            this.ColumnTotal.MinimumWidth = 6;
            this.ColumnTotal.Name = "ColumnTotal";
            this.ColumnTotal.ReadOnly = true;
            this.ColumnTotal.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnTotal.Width = 125;
            // 
            // ColumnUsuario
            // 
            this.ColumnUsuario.HeaderText = "Usuario";
            this.ColumnUsuario.MinimumWidth = 6;
            this.ColumnUsuario.Name = "ColumnUsuario";
            this.ColumnUsuario.ReadOnly = true;
            this.ColumnUsuario.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnUsuario.Width = 125;
            // 
            // ColumnNumeroDeMesa
            // 
            this.ColumnNumeroDeMesa.HeaderText = "Número de Mesa";
            this.ColumnNumeroDeMesa.MinimumWidth = 6;
            this.ColumnNumeroDeMesa.Name = "ColumnNumeroDeMesa";
            this.ColumnNumeroDeMesa.ReadOnly = true;
            this.ColumnNumeroDeMesa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnNumeroDeMesa.Width = 150;
            // 
            // ColumnCliente
            // 
            this.ColumnCliente.HeaderText = "Cliente";
            this.ColumnCliente.MinimumWidth = 6;
            this.ColumnCliente.Name = "ColumnCliente";
            this.ColumnCliente.ReadOnly = true;
            this.ColumnCliente.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnCliente.Width = 125;
            // 
            // ColumnEstado
            // 
            this.ColumnEstado.HeaderText = "Estado";
            this.ColumnEstado.MinimumWidth = 6;
            this.ColumnEstado.Name = "ColumnEstado";
            this.ColumnEstado.ReadOnly = true;
            this.ColumnEstado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnEstado.Width = 125;
            // 
            // FormReportesDeOrdenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 408);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormReportesDeOrdenes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reportes De Ordenes";
            this.Load += new System.EventHandler(this.FormReportesDeOrdenes_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportesDeOrdenes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvReportesDeOrdenes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFechaHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumeroDeMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEstado;
    }
}