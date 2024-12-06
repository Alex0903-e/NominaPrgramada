using System;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            ConfigurarComboBoxTipoSalario();
            ConfigurarComboBoxTipoAusencia();
            ConfigurarComboBoxTipoPagoHorasExtra();
        }

        private void ConfigurarDataGridView()
        {
            dataGridNomina.ReadOnly = true;
            dataGridNomina.Columns.Add("codigo", "Código Trabajador");
            dataGridNomina.Columns.Add("nombre", "Nombre y Apellido");
            dataGridNomina.Columns.Add("categoria", "Categoría");
            dataGridNomina.Columns.Add("salarioMensual", "Salario Mensual");

            // Añadir las columnas Salario Quincenal y Salario Semanal
            dataGridNomina.Columns.Add("salarioQuincenal", "Salario Quincenal");
            dataGridNomina.Columns.Add("salarioSemanal", "Salario Semanal");

            dataGridNomina.Columns.Add("antigüedad", "Antigüedad");
            dataGridNomina.Columns.Add("horasExtra", "Horas Extra");
            dataGridNomina.Columns.Add("bonos", "Bonos");
            dataGridNomina.Columns.Add("salarioBruto", "Salario Bruto");
            dataGridNomina.Columns.Add("inss", "INSS");
            dataGridNomina.Columns.Add("ir", "IR");

            // Añadir nueva columna "Salario Neto"
            dataGridNomina.Columns.Add("salarioNeto", "Salario Neto");

            dataGridNomina.Columns.Add("treceavoMes", "13vo Mes");
            dataGridNomina.Columns.Add("inatec", "INATEC");
            dataGridNomina.Columns.Add("vacaciones", "Vacaciones");
            dataGridNomina.Columns.Add("indemnizacion", "Indemnización");
            dataGridNomina.Columns.Add("inssPatronal", "INSS Patronal");

            // Renombrar última columna de "Salario Neto" a "Total de Prestaciones Sociales"
            dataGridNomina.Columns.Add("totalPrestaciones", "Total de Prestaciones Sociales");
            dataGridNomina.Columns.Add("descuento", "Descuento por Ausencias");
        }


        private void ConfigurarComboBoxTipoSalario()
        {
            comboTipoSalario.Items.Add("Quincenal");
            comboTipoSalario.Items.Add("Semanal");
        }

        private void ConfigurarComboBoxTipoAusencia()
        {
            comboTipoAusencia.Items.Add("Días");
            comboTipoAusencia.Items.Add("Horas");
        }

        private void ConfigurarComboBoxTipoPagoHorasExtra()
        {
            comboTipoPagoHorasExtra.Items.Add("Normal");
            comboTipoPagoHorasExtra.Items.Add("Doble");
        }

        private void buttonCalcular_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Validaciones de los campos de texto y de ComboBox
                if (!EsNumero(textCodigo.Text) || string.IsNullOrWhiteSpace(textCodigo.Text))
                {
                    MessageBox.Show("El código de trabajador debe ser numérico.");
                    return;
                }

                if (!EsNumero(textSalario.Text) || string.IsNullOrWhiteSpace(textSalario.Text))
                {
                    MessageBox.Show("El salario mensual debe ser numérico.");
                    return;
                }

                if (!EsNumero(textAntiguedad.Text) || string.IsNullOrWhiteSpace(textAntiguedad.Text))
                {
                    MessageBox.Show("La antigüedad debe ser numérica.");
                    return;
                }

                if (!EsNumero(textHoras.Text) || string.IsNullOrWhiteSpace(textHoras.Text))
                {
                    MessageBox.Show("Las horas extra deben ser numéricas.");
                    return;
                }

                if (!EsNumero(textBonos.Text) || string.IsNullOrWhiteSpace(textBonos.Text))
                {
                    MessageBox.Show("Los bonos deben ser numéricos.");
                    return;
                }

                if (!EsNumero(textAusencias.Text) || string.IsNullOrWhiteSpace(textAusencias.Text))
                {
                    MessageBox.Show("El número de ausencias debe ser numérico.");
                    return;
                }

                if (!EsNombreValido(textNombre.Text))
                {
                    MessageBox.Show("El nombre y apellido solo debe contener letras y espacios.");
                    return;
                }

                if (!EsSoloLetras(textCategoria.Text))
                {
                    MessageBox.Show("La categoría solo debe contener letras.");
                    return;
                }

                if (comboTipoSalario.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, seleccione el tipo de salario.");
                    return;
                }

                if (comboTipoAusencia.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, seleccione el tipo de ausencia.");
                    return;
                }

                if (comboTipoPagoHorasExtra.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, seleccione el tipo de pago para horas extra.");
                    return;
                }

                // Obtener datos de entrada
                string tipoSalario = comboTipoSalario.SelectedItem?.ToString().ToLower();
                decimal salarioMensual = Convert.ToDecimal(textSalario.Text);
                decimal salarioQuincenal = 0;
                decimal salarioSemanal = 0;

                // Calcular salario quincenal o semanal según selección
                if (tipoSalario == "quincenal")
                {
                    salarioQuincenal = Math.Round(salarioMensual / 2, 2);
                }
                else if (tipoSalario == "semanal")
                {
                    salarioSemanal = Math.Round(salarioMensual / 4, 2);
                }

                decimal antiguedadPorcentaje = Convert.ToDecimal(textAntiguedad.Text) / 100;
                decimal antiguedad = Math.Round(antiguedadPorcentaje * salarioMensual, 2);
                decimal horasExtra = Convert.ToDecimal(textHoras.Text);
                decimal bonos = Convert.ToDecimal(textBonos.Text);

                // Calcular el pago por hora extra
                decimal pagoPorHoraExtra = Math.Round(salarioMensual / 30 / 8, 2);
                string tipoPagoHorasExtra = comboTipoPagoHorasExtra.SelectedItem.ToString();
                if (tipoPagoHorasExtra == "Doble")
                {
                    pagoPorHoraExtra *= 2; // Doblar el pago
                }
                decimal totalHorasExtra = Math.Round(pagoPorHoraExtra * horasExtra, 2);

                // Calcular descuento por ausencias
                string tipoAusencia = comboTipoAusencia.SelectedItem.ToString();
                decimal ausencias = Convert.ToDecimal(textAusencias.Text);
                decimal descuento = tipoAusencia == "Días"
                    ? Math.Round(salarioMensual / 30 * ausencias, 2)
                    : Math.Round((salarioMensual / 30 / 8) * ausencias, 2);

                // Calcular salario bruto
                decimal salarioBruto = Math.Round(salarioMensual + bonos + totalHorasExtra + antiguedad, 2);

                // Calcular deducciones y prestaciones
                decimal inss = Math.Round(salarioBruto * 0.07m, 2);
                decimal ir = CalcularIR(salarioBruto);
                decimal inssPatronal = Math.Round(salarioBruto * 0.225m, 2);
                decimal vacaciones = Math.Round(salarioBruto * (1 / 12m), 2);
                decimal indemnizacion = Math.Round(salarioBruto * (1 / 12m), 2);
                decimal decimoTercerMes = vacaciones;
                decimal inatec = Math.Round(salarioBruto * 0.02m, 2);

                // Calcular salario neto
                decimal salarioNeto = Math.Round(salarioBruto - inss - ir - descuento, 2);

                // Calcular total de prestaciones sociales
                decimal totalPrestaciones = Math.Round(decimoTercerMes + inatec + inssPatronal + indemnizacion + vacaciones, 2);

                // Obtener datos para agregar al DataGridView
                string codigo = textCodigo.Text;
                string nombreApellido = textNombre.Text;
                string categoria = textCategoria.Text;

                // Agregar los valores calculados al DataGridView
                dataGridNomina.Rows.Add(codigo, nombreApellido, categoria, salarioMensual,
                    (tipoSalario == "quincenal") ? salarioQuincenal.ToString() : string.Empty,
                    (tipoSalario == "semanal") ? salarioSemanal.ToString() : string.Empty,
                    antiguedad, totalHorasExtra, bonos, salarioBruto,
                    inss, ir, salarioNeto, // Nueva columna: Salario Neto
                    decimoTercerMes, inatec, vacaciones, indemnizacion, inssPatronal,
                    totalPrestaciones, // Nueva columna: Total de Prestaciones Sociales
                    descuento);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, asegúrese de que todos los campos numéricos estén llenos correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }



        private decimal CalcularIR(decimal salarioBruto)
        {
            decimal salarioAnual = (salarioBruto - (salarioBruto * 0.07m)) * 12;
            decimal ir = 0;

            if (salarioAnual <= 100000)
            {
                ir = 0;
            }
            else if (salarioAnual <= 200000)
            {
                ir = ((salarioAnual - 100000) * 0.15m) / 12;
            }
            else if (salarioAnual <= 350000)
            {
                ir = ((salarioAnual - 200000) * 0.20m + 15000) / 12;
            }
            else if (salarioAnual <= 500000)
            {
                ir = ((salarioAnual - 350000) * 0.25m + 45000) / 12;
            }
            else
            {
                ir = ((salarioAnual - 500000) * 0.30m + 82500) / 12;
            }
            return Math.Round(ir, 2);
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (dataGridNomina.Rows.Count == 0)
            {
                MessageBox.Show("No se ha calculado ningún empleado. Primero debe calcular un empleado.");
                return;
            }

            string codigo = textCodigo.Text;
            string nombreApellido = textNombre.Text;
            string categoria = textCategoria.Text;

            if (string.IsNullOrWhiteSpace(codigo) || string.IsNullOrWhiteSpace(nombreApellido) || string.IsNullOrWhiteSpace(categoria))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de guardar.");
                return;
            }

            foreach (DataGridViewRow fila in dataGridNomina.Rows)
            {
                if (fila.Cells["codigo"].Value.ToString() == codigo)
                {
                    MessageBox.Show("Este código de trabajador ya existe. Por favor, use un código diferente.");
                    return;
                }
            }

            dataGridNomina.Rows.Add(codigo, nombreApellido, categoria); // Cambiar esto para incluir otros campos si es necesario

            LimpiarCampos();
        }

        private void buttonSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLimpiar_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            textSalario.Clear();
            textAntiguedad.Clear();
            textHoras.Clear();
            textBonos.Clear();
            textAusencias.Clear();
            textCodigo.Clear();
            textNombre.Clear();
            textCategoria.Clear();
            comboTipoSalario.SelectedIndex = -1;
            comboTipoAusencia.SelectedIndex = -1;
            comboTipoPagoHorasExtra.SelectedIndex = -1; // Limpiar el ComboBox de horas extra
        }

        private bool EsNumero(string valor)
        {
            return decimal.TryParse(valor, out _);
        }

        private bool EsNombreValido(string valor)
        {
            return valor.All(c => char.IsLetter(c) || char.IsWhiteSpace(c));
        }

        private bool EsSoloLetras(string valor)
        {
            return valor.All(char.IsLetter);
        }
        public void exportarAExcel(DataGridView tabla)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);

            int IndiceColumna = 0;

            foreach (DataGridViewColumn col in tabla.Columns)
            {
                IndiceColumna++;
                excel.Cells[1, IndiceColumna] = col.HeaderText;
            }

            int IndiceFila = 0;

            foreach (DataGridViewRow row in tabla.Rows)
            {
                IndiceFila++;
                IndiceColumna = 0;

                foreach (DataGridViewColumn col in tabla.Columns)
                {
                    IndiceColumna++;
                    excel.Cells[IndiceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;
                }
            }

            excel.Visible = true;
        }

        private void buttonExportarExcel_Click_1(object sender, EventArgs e)
        {
            exportarAExcel(dataGridNomina);
        }

       
          
        }

       
    }

