namespace WinFormsApp1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textCodigo = new TextBox();
            textNombre = new TextBox();
            textSalario = new TextBox();
            textAntiguedad = new TextBox();
            textHoras = new TextBox();
            textBonos = new TextBox();
            textCategoria = new TextBox();
            dataGridNomina = new DataGridView();
            buttonCalcular = new Button();
            buttonLimpiar = new Button();
            buttonSalir = new Button();
            buttonGuardar = new Button();
            buttonExportarExcel = new Button();
            comboTipoSalario = new ComboBox();
            textAusencias = new TextBox();
            label9 = new Label();
            comboTipoAusencia = new ComboBox();
            comboTipoPagoHorasExtra = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridNomina).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(31, 28);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(161, 22);
            label1.TabIndex = 0;
            label1.Text = "Codigo Trabajador";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(31, 97);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(164, 22);
            label2.TabIndex = 1;
            label2.Text = "Nombre Y Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(346, 92);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(141, 22);
            label3.TabIndex = 2;
            label3.Text = "Salario Mensual";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(346, 26);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(91, 22);
            label4.TabIndex = 3;
            label4.Text = "Categoria";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(642, 26);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(132, 22);
            label5.TabIndex = 4;
            label5.Text = "Tipo de salario";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(642, 92);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(104, 22);
            label6.TabIndex = 5;
            label6.Text = "Antiguedad";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Transparent;
            label7.Location = new Point(937, 28);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(118, 22);
            label7.TabIndex = 6;
            label7.Text = "Horas Extras";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Transparent;
            label8.Location = new Point(937, 97);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(61, 22);
            label8.TabIndex = 7;
            label8.Text = "Bonos";
            // 
            // textCodigo
            // 
            textCodigo.Location = new Point(204, 26);
            textCodigo.Margin = new Padding(4);
            textCodigo.Name = "textCodigo";
            textCodigo.Size = new Size(127, 27);
            textCodigo.TabIndex = 8;
            // 
            // textNombre
            // 
            textNombre.Location = new Point(203, 92);
            textNombre.Margin = new Padding(4);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(127, 27);
            textNombre.TabIndex = 9;
            // 
            // textSalario
            // 
            textSalario.Location = new Point(495, 87);
            textSalario.Margin = new Padding(4);
            textSalario.Name = "textSalario";
            textSalario.Size = new Size(127, 27);
            textSalario.TabIndex = 11;
            // 
            // textAntiguedad
            // 
            textAntiguedad.Location = new Point(782, 92);
            textAntiguedad.Margin = new Padding(4);
            textAntiguedad.Name = "textAntiguedad";
            textAntiguedad.Size = new Size(127, 27);
            textAntiguedad.TabIndex = 13;
            // 
            // textHoras
            // 
            textHoras.Location = new Point(1063, 24);
            textHoras.Margin = new Padding(4);
            textHoras.Name = "textHoras";
            textHoras.Size = new Size(127, 27);
            textHoras.TabIndex = 14;
            // 
            // textBonos
            // 
            textBonos.Location = new Point(1017, 95);
            textBonos.Margin = new Padding(4);
            textBonos.Name = "textBonos";
            textBonos.Size = new Size(127, 27);
            textBonos.TabIndex = 15;
            // 
            // textCategoria
            // 
            textCategoria.Location = new Point(495, 26);
            textCategoria.Margin = new Padding(4);
            textCategoria.Name = "textCategoria";
            textCategoria.Size = new Size(127, 27);
            textCategoria.TabIndex = 16;
            // 
            // dataGridNomina
            // 
            dataGridNomina.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridNomina.Location = new Point(22, 227);
            dataGridNomina.Margin = new Padding(4, 3, 4, 3);
            dataGridNomina.Name = "dataGridNomina";
            dataGridNomina.RowHeadersWidth = 51;
            dataGridNomina.RowTemplate.Height = 29;
            dataGridNomina.Size = new Size(843, 355);
            dataGridNomina.TabIndex = 17;
            // 
            // buttonCalcular
            // 
            buttonCalcular.BackColor = SystemColors.ButtonHighlight;
            buttonCalcular.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCalcular.Location = new Point(34, 156);
            buttonCalcular.Margin = new Padding(4);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(96, 48);
            buttonCalcular.TabIndex = 18;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = false;
            buttonCalcular.Click += buttonCalcular_Click_1;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.BackColor = SystemColors.ButtonHighlight;
            buttonLimpiar.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLimpiar.Location = new Point(159, 156);
            buttonLimpiar.Margin = new Padding(4);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(96, 48);
            buttonLimpiar.TabIndex = 19;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = false;
            buttonLimpiar.Click += buttonLimpiar_Click_1;
            // 
            // buttonSalir
            // 
            buttonSalir.BackColor = SystemColors.ButtonHighlight;
            buttonSalir.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSalir.Location = new Point(281, 156);
            buttonSalir.Margin = new Padding(4);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(96, 48);
            buttonSalir.TabIndex = 20;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = false;
            buttonSalir.Click += buttonSalir_Click_1;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(3, 3);
            buttonGuardar.Margin = new Padding(4);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(13, 31);
            buttonGuardar.TabIndex = 21;
            buttonGuardar.UseVisualStyleBackColor = true;
            // 
            // buttonExportarExcel
            // 
            buttonExportarExcel.BackColor = SystemColors.ButtonHighlight;
            buttonExportarExcel.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExportarExcel.Location = new Point(404, 158);
            buttonExportarExcel.Margin = new Padding(4);
            buttonExportarExcel.Name = "buttonExportarExcel";
            buttonExportarExcel.Size = new Size(112, 44);
            buttonExportarExcel.TabIndex = 22;
            buttonExportarExcel.Text = "Exportar";
            buttonExportarExcel.UseVisualStyleBackColor = false;
            buttonExportarExcel.Click += buttonExportarExcel_Click_1;
            // 
            // comboTipoSalario
            // 
            comboTipoSalario.FormattingEnabled = true;
            comboTipoSalario.Location = new Point(782, 26);
            comboTipoSalario.Margin = new Padding(4);
            comboTipoSalario.Name = "comboTipoSalario";
            comboTipoSalario.Size = new Size(131, 28);
            comboTipoSalario.TabIndex = 24;
            // 
            // textAusencias
            // 
            textAusencias.Location = new Point(1246, 98);
            textAusencias.Margin = new Padding(4);
            textAusencias.Name = "textAusencias";
            textAusencias.Size = new Size(127, 27);
            textAusencias.TabIndex = 25;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Transparent;
            label9.Location = new Point(1152, 100);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(86, 22);
            label9.TabIndex = 26;
            label9.Text = "Ausencia";
            // 
            // comboTipoAusencia
            // 
            comboTipoAusencia.FormattingEnabled = true;
            comboTipoAusencia.Location = new Point(1246, 146);
            comboTipoAusencia.Margin = new Padding(4);
            comboTipoAusencia.Name = "comboTipoAusencia";
            comboTipoAusencia.Size = new Size(80, 28);
            comboTipoAusencia.TabIndex = 27;
            // 
            // comboTipoPagoHorasExtra
            // 
            comboTipoPagoHorasExtra.FormattingEnabled = true;
            comboTipoPagoHorasExtra.Location = new Point(1198, 22);
            comboTipoPagoHorasExtra.Margin = new Padding(4);
            comboTipoPagoHorasExtra.Name = "comboTipoPagoHorasExtra";
            comboTipoPagoHorasExtra.Size = new Size(98, 28);
            comboTipoPagoHorasExtra.TabIndex = 28;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1370, 668);
            Controls.Add(comboTipoPagoHorasExtra);
            Controls.Add(comboTipoAusencia);
            Controls.Add(label9);
            Controls.Add(textAusencias);
            Controls.Add(comboTipoSalario);
            Controls.Add(buttonExportarExcel);
            Controls.Add(buttonGuardar);
            Controls.Add(buttonSalir);
            Controls.Add(buttonLimpiar);
            Controls.Add(buttonCalcular);
            Controls.Add(dataGridNomina);
            Controls.Add(textCategoria);
            Controls.Add(textBonos);
            Controls.Add(textHoras);
            Controls.Add(textAntiguedad);
            Controls.Add(textSalario);
            Controls.Add(textNombre);
            Controls.Add(textCodigo);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridNomina).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textCodigo;
        private TextBox textNombre;
        private TextBox textSalario;
        private TextBox textAntiguedad;
        private TextBox textHoras;
        private TextBox textBonos;
        private TextBox textCategoria;
        private DataGridView dataGridNomina;
        private Button buttonCalcular;
        private Button buttonLimpiar;
        private Button buttonSalir;
        private Button buttonGuardar;
        private Button buttonExportarExcel;
        private ComboBox comboTipoSalario;
        private TextBox textAusencias;
        private Label label9;
        private ComboBox comboTipoAusencia;
        private ComboBox comboTipoPagoHorasExtra;
    }
}