using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.AnishchenkoVA.Sprint7.Project.V14.Lib;

namespace Tyuiu.AnishchenkoVA.Sprint7.Project.V14
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonAboutProgram_AVA_Click(object sender, EventArgs e)
        {
            FormAbout FA = new FormAbout();
            FA.ShowDialog();
        }

        private void buttonSave_AVA_Click(object sender, EventArgs e)
        {
            saveFileDialog_AVA.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            if (saveFileDialog_AVA.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog_AVA.FileName;

                StringBuilder csvContent = new();

                for (int i = 0; i < dataGridViewOutput_AVA.Columns.Count; i++)
                {
                    csvContent.Append(dataGridViewOutput_AVA.Columns[i].HeaderText);
                    if (i < dataGridViewOutput_AVA.Columns.Count - 1)
                        csvContent.Append(",");
                }
                csvContent.AppendLine();

                foreach (DataGridViewRow row in dataGridViewOutput_AVA.Rows)
                {
                    for (int i = 0; i < dataGridViewOutput_AVA.Columns.Count; i++)
                    {
                        csvContent.Append(row.Cells[i].Value?.ToString());
                        if (i < dataGridViewOutput_AVA.Columns.Count - 1)
                            csvContent.Append(",");
                    }
                    csvContent.AppendLine();
                }

                File.WriteAllText(filename, csvContent.ToString());
                MessageBox.Show("Файл сохранен");
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            List<Transport> transports = ds.GetTransport();
            dataGridViewInput_AVA.AutoGenerateColumns = true;
            dataGridViewInput_AVA.DataSource = transports;
            dataGridViewOutput_AVA.AutoGenerateColumns = true;
            dataGridViewOutput_AVA.DataSource = transports;

            chartNumbersOfTransport_AVA.Series.Clear();

            foreach (var transport in transports)
            {
                if (!chartNumbersOfTransport_AVA.Series.IsUniqueName(transport.transport))
                {
                    var existingSeries = chartNumbersOfTransport_AVA.Series[transport.transport];
                    existingSeries.Points.AddXY(transport.transport, transport.timeOfRoute);
                }
                else
                {
                    var seriesNumberOfTransport = chartNumbersOfTransport_AVA.Series.Add(transport.transport);
                    seriesNumberOfTransport.Points.AddXY(transport.transport, transport.timeOfRoute);
                }
            }

            chartNumbersOfTransport_AVA.ChartAreas[0].AxisX.Title = "Транспорт";
            chartNumbersOfTransport_AVA.ChartAreas[0].AxisY.Title = "Время";
        }


        private void buttonSeek_AVA_Click(object sender, EventArgs e)
        {
            List<Transport> transports = ds.SearchTransport(Convert.ToInt32(textBoxNameSearch_AVA.Text));
            dataGridViewOutput_AVA.AutoGenerateColumns = true;
            dataGridViewOutput_AVA.DataSource = transports;
            chartNumbersOfTransport_AVA.Series.Clear();

            foreach (var transport in transports)
            {
                if (!chartNumbersOfTransport_AVA.Series.IsUniqueName(transport.transport))
                {
                    var existingSeries = chartNumbersOfTransport_AVA.Series[transport.transport];
                    existingSeries.Points.AddXY(transport.transport, transport.timeOfRoute);
                }
                else
                {
                    var seriesNumberOfTransport = chartNumbersOfTransport_AVA.Series.Add(transport.transport);
                    seriesNumberOfTransport.Points.AddXY(transport.transport, transport.timeOfRoute);
                }
            }

            chartNumbersOfTransport_AVA.ChartAreas[0].AxisX.Title = "Транспорт";
            chartNumbersOfTransport_AVA.ChartAreas[0].AxisY.Title = "Время";
        }

        private void dataGridViewInput_AVA_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridViewOutput_AVA_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int columnIndex = e.ColumnIndex;
            List<Transport> transports = ds.SortTransport(columnIndex);
            dataGridViewOutput_AVA.DataSource = transports;
            chartNumbersOfTransport_AVA.Series.Clear();

            foreach (var transport in transports)
            {
                if (!chartNumbersOfTransport_AVA.Series.IsUniqueName(transport.transport))
                {
                    var existingSeries = chartNumbersOfTransport_AVA.Series[transport.transport];
                    existingSeries.Points.AddXY(transport.transport, transport.timeOfRoute);
                }
                else
                {
                    var seriesNumberOfTransport = chartNumbersOfTransport_AVA.Series.Add(transport.transport);
                    seriesNumberOfTransport.Points.AddXY(transport.transport, transport.timeOfRoute);
                }
            }

            chartNumbersOfTransport_AVA.ChartAreas[0].AxisX.Title = "Транспорт";
            chartNumbersOfTransport_AVA.ChartAreas[0].AxisY.Title = "Время";
        }

        private void chartNumbersOfTransport_AVA_MouseEnter(object sender, EventArgs e)
        {
        }

        private void buttonSeek_AVA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_AVA.ToolTipTitle = "Найти маршрут";
        }

        private void buttonSave_AVA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_AVA.ToolTipTitle = "Сохранить файл";
        }

        private void buttonAboutProgram_AVA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_AVA.ToolTipTitle = "Сведения о программе";
        }

        private void buttonHelp_AVA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_AVA.ToolTipTitle = "Помощь по работе с программой";
        }

        private void buttonHelp_AVA_Click(object sender, EventArgs e)
        {
            FormHelp FH = new FormHelp();
            FH.ShowDialog();
        }
    }
}
