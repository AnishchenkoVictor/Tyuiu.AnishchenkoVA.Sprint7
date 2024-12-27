namespace Tyuiu.AnishchenkoVA.Sprint7.Project.V14
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            panelHeader_AVA = new Panel();
            buttonHelp_AVA = new Button();
            buttonSave_AVA = new Button();
            buttonAboutProgram_AVA = new Button();
            labelTitle_AVA = new Label();
            panelMiddle_AVA = new Panel();
            chartNumbersOfTransport_AVA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            transportBindingSource = new BindingSource(components);
            buttonSeek_AVA = new Button();
            groupBoxSerch_AVA = new GroupBox();
            textBoxNameSearch_AVA = new TextBox();
            panelInput_AVA = new Panel();
            dataGridViewInput_AVA = new DataGridView();
            splitterData_AVA = new Splitter();
            panelOutput_AVA = new Panel();
            dataGridViewOutput_AVA = new DataGridView();
            toolTipButton_AVA = new ToolTip(components);
            saveFileDialog_AVA = new SaveFileDialog();
            panelHeader_AVA.SuspendLayout();
            panelMiddle_AVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartNumbersOfTransport_AVA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)transportBindingSource).BeginInit();
            groupBoxSerch_AVA.SuspendLayout();
            panelInput_AVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_AVA).BeginInit();
            panelOutput_AVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_AVA).BeginInit();
            SuspendLayout();
            // 
            // panelHeader_AVA
            // 
            panelHeader_AVA.BackColor = Color.LightSkyBlue;
            panelHeader_AVA.Controls.Add(buttonHelp_AVA);
            panelHeader_AVA.Controls.Add(buttonSave_AVA);
            panelHeader_AVA.Controls.Add(buttonAboutProgram_AVA);
            panelHeader_AVA.Controls.Add(labelTitle_AVA);
            panelHeader_AVA.Dock = DockStyle.Top;
            panelHeader_AVA.Location = new Point(0, 0);
            panelHeader_AVA.Name = "panelHeader_AVA";
            panelHeader_AVA.Size = new Size(1848, 120);
            panelHeader_AVA.TabIndex = 0;
            // 
            // buttonHelp_AVA
            // 
            buttonHelp_AVA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_AVA.BackColor = Color.Azure;
            buttonHelp_AVA.FlatStyle = FlatStyle.Flat;
            buttonHelp_AVA.Location = new Point(1752, 32);
            buttonHelp_AVA.Name = "buttonHelp_AVA";
            buttonHelp_AVA.Size = new Size(84, 50);
            buttonHelp_AVA.TabIndex = 4;
            buttonHelp_AVA.Text = "Помощь";
            toolTipButton_AVA.SetToolTip(buttonHelp_AVA, "Нажмите, чтобы получить справку по работе с программой");
            buttonHelp_AVA.UseVisualStyleBackColor = false;
            buttonHelp_AVA.Click += buttonHelp_AVA_Click;
            buttonHelp_AVA.MouseEnter += buttonHelp_AVA_MouseEnter;
            // 
            // buttonSave_AVA
            // 
            buttonSave_AVA.BackColor = Color.SkyBlue;
            buttonSave_AVA.FlatStyle = FlatStyle.Flat;
            buttonSave_AVA.Image = Properties.Resources.page_save;
            buttonSave_AVA.Location = new Point(1372, 12);
            buttonSave_AVA.Name = "buttonSave_AVA";
            buttonSave_AVA.Size = new Size(142, 92);
            buttonSave_AVA.TabIndex = 3;
            buttonSave_AVA.Text = "Сохранить";
            buttonSave_AVA.TextAlign = ContentAlignment.BottomCenter;
            toolTipButton_AVA.SetToolTip(buttonSave_AVA, "Нажмите, чтобы сохранить файл в формате CSV.");
            buttonSave_AVA.UseVisualStyleBackColor = false;
            buttonSave_AVA.Click += buttonSave_AVA_Click;
            buttonSave_AVA.MouseEnter += buttonSave_AVA_MouseEnter;
            // 
            // buttonAboutProgram_AVA
            // 
            buttonAboutProgram_AVA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAboutProgram_AVA.BackColor = Color.Azure;
            buttonAboutProgram_AVA.FlatStyle = FlatStyle.Flat;
            buttonAboutProgram_AVA.Location = new Point(1616, 32);
            buttonAboutProgram_AVA.Name = "buttonAboutProgram_AVA";
            buttonAboutProgram_AVA.Size = new Size(116, 50);
            buttonAboutProgram_AVA.TabIndex = 2;
            buttonAboutProgram_AVA.Text = "О программе";
            toolTipButton_AVA.SetToolTip(buttonAboutProgram_AVA, "Нажмите, чтобы получить информацию о программе.");
            buttonAboutProgram_AVA.UseVisualStyleBackColor = false;
            buttonAboutProgram_AVA.Click += buttonAboutProgram_AVA_Click;
            buttonAboutProgram_AVA.MouseEnter += buttonAboutProgram_AVA_MouseEnter;
            // 
            // labelTitle_AVA
            // 
            labelTitle_AVA.AutoSize = true;
            labelTitle_AVA.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTitle_AVA.Location = new Point(12, 20);
            labelTitle_AVA.Name = "labelTitle_AVA";
            labelTitle_AVA.Size = new Size(494, 62);
            labelTitle_AVA.TabIndex = 0;
            labelTitle_AVA.Text = "Городской транспорт";
            // 
            // panelMiddle_AVA
            // 
            panelMiddle_AVA.BackColor = Color.AliceBlue;
            panelMiddle_AVA.Controls.Add(chartNumbersOfTransport_AVA);
            panelMiddle_AVA.Controls.Add(buttonSeek_AVA);
            panelMiddle_AVA.Controls.Add(groupBoxSerch_AVA);
            panelMiddle_AVA.Dock = DockStyle.Top;
            panelMiddle_AVA.Location = new Point(0, 120);
            panelMiddle_AVA.Name = "panelMiddle_AVA";
            panelMiddle_AVA.Size = new Size(1848, 305);
            panelMiddle_AVA.TabIndex = 1;
            // 
            // chartNumbersOfTransport_AVA
            // 
            chartNumbersOfTransport_AVA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            chartArea2.Name = "ChartArea1";
            chartNumbersOfTransport_AVA.ChartAreas.Add(chartArea2);
            chartNumbersOfTransport_AVA.DataSource = transportBindingSource;
            legend2.Name = "Legend1";
            chartNumbersOfTransport_AVA.Legends.Add(legend2);
            chartNumbersOfTransport_AVA.Location = new Point(825, 6);
            chartNumbersOfTransport_AVA.Margin = new Padding(3, 4, 3, 4);
            chartNumbersOfTransport_AVA.Name = "chartNumbersOfTransport_AVA";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartNumbersOfTransport_AVA.Series.Add(series2);
            chartNumbersOfTransport_AVA.Size = new Size(611, 296);
            chartNumbersOfTransport_AVA.TabIndex = 2;
            chartNumbersOfTransport_AVA.Text = "chartNumbersOfTransport";
            title2.Name = "Title1";
            title2.Text = "Время в пути";
            chartNumbersOfTransport_AVA.Titles.Add(title2);
            toolTipButton_AVA.SetToolTip(chartNumbersOfTransport_AVA, "Диаграмма времени в пути.");
            chartNumbersOfTransport_AVA.MouseEnter += chartNumbersOfTransport_AVA_MouseEnter;
            // 
            // transportBindingSource
            // 
            transportBindingSource.DataSource = typeof(Lib.Transport);
            // 
            // buttonSeek_AVA
            // 
            buttonSeek_AVA.BackColor = Color.SkyBlue;
            buttonSeek_AVA.FlatStyle = FlatStyle.Flat;
            buttonSeek_AVA.Image = Properties.Resources.zoom;
            buttonSeek_AVA.Location = new Point(473, 93);
            buttonSeek_AVA.Name = "buttonSeek_AVA";
            buttonSeek_AVA.Size = new Size(117, 89);
            buttonSeek_AVA.TabIndex = 1;
            buttonSeek_AVA.Text = "Найти";
            buttonSeek_AVA.TextAlign = ContentAlignment.BottomCenter;
            toolTipButton_AVA.SetToolTip(buttonSeek_AVA, "Нажмите, чтобы найти номер введенного маршрута.");
            buttonSeek_AVA.UseVisualStyleBackColor = false;
            buttonSeek_AVA.Click += buttonSeek_AVA_Click;
            buttonSeek_AVA.MouseEnter += buttonSeek_AVA_MouseEnter;
            // 
            // groupBoxSerch_AVA
            // 
            groupBoxSerch_AVA.BackColor = SystemColors.MenuHighlight;
            groupBoxSerch_AVA.Controls.Add(textBoxNameSearch_AVA);
            groupBoxSerch_AVA.Location = new Point(12, 75);
            groupBoxSerch_AVA.Name = "groupBoxSerch_AVA";
            groupBoxSerch_AVA.Size = new Size(427, 125);
            groupBoxSerch_AVA.TabIndex = 0;
            groupBoxSerch_AVA.TabStop = false;
            groupBoxSerch_AVA.Text = "Поиск";
            // 
            // textBoxNameSearch_AVA
            // 
            textBoxNameSearch_AVA.Location = new Point(6, 49);
            textBoxNameSearch_AVA.Name = "textBoxNameSearch_AVA";
            textBoxNameSearch_AVA.PlaceholderText = "Введите номер маршрута";
            textBoxNameSearch_AVA.Size = new Size(415, 27);
            textBoxNameSearch_AVA.TabIndex = 0;
            // 
            // panelInput_AVA
            // 
            panelInput_AVA.BackColor = Color.AliceBlue;
            panelInput_AVA.Controls.Add(dataGridViewInput_AVA);
            panelInput_AVA.Dock = DockStyle.Left;
            panelInput_AVA.Location = new Point(0, 425);
            panelInput_AVA.Name = "panelInput_AVA";
            panelInput_AVA.Size = new Size(993, 546);
            panelInput_AVA.TabIndex = 2;
            // 
            // dataGridViewInput_AVA
            // 
            dataGridViewInput_AVA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewInput_AVA.BackgroundColor = SystemColors.ControlLight;
            dataGridViewInput_AVA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInput_AVA.Location = new Point(3, 6);
            dataGridViewInput_AVA.Name = "dataGridViewInput_AVA";
            dataGridViewInput_AVA.RowHeadersVisible = false;
            dataGridViewInput_AVA.RowHeadersWidth = 51;
            dataGridViewInput_AVA.Size = new Size(987, 537);
            dataGridViewInput_AVA.TabIndex = 0;
            dataGridViewInput_AVA.ColumnHeaderMouseClick += dataGridViewInput_AVA_ColumnHeaderMouseClick;
            // 
            // splitterData_AVA
            // 
            splitterData_AVA.Location = new Point(993, 425);
            splitterData_AVA.Name = "splitterData_AVA";
            splitterData_AVA.Size = new Size(4, 546);
            splitterData_AVA.TabIndex = 3;
            splitterData_AVA.TabStop = false;
            // 
            // panelOutput_AVA
            // 
            panelOutput_AVA.BackColor = Color.AliceBlue;
            panelOutput_AVA.Controls.Add(dataGridViewOutput_AVA);
            panelOutput_AVA.Dock = DockStyle.Fill;
            panelOutput_AVA.Location = new Point(997, 425);
            panelOutput_AVA.Name = "panelOutput_AVA";
            panelOutput_AVA.Size = new Size(851, 546);
            panelOutput_AVA.TabIndex = 4;
            // 
            // dataGridViewOutput_AVA
            // 
            dataGridViewOutput_AVA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewOutput_AVA.BackgroundColor = SystemColors.ControlLight;
            dataGridViewOutput_AVA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutput_AVA.Location = new Point(6, 6);
            dataGridViewOutput_AVA.Name = "dataGridViewOutput_AVA";
            dataGridViewOutput_AVA.RowHeadersVisible = false;
            dataGridViewOutput_AVA.RowHeadersWidth = 51;
            dataGridViewOutput_AVA.Size = new Size(842, 537);
            dataGridViewOutput_AVA.TabIndex = 0;
            dataGridViewOutput_AVA.ColumnHeaderMouseClick += dataGridViewOutput_AVA_ColumnHeaderMouseClick;
            // 
            // toolTipButton_AVA
            // 
            toolTipButton_AVA.ToolTipIcon = ToolTipIcon.Info;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1848, 971);
            Controls.Add(panelOutput_AVA);
            Controls.Add(splitterData_AVA);
            Controls.Add(panelInput_AVA);
            Controls.Add(panelMiddle_AVA);
            Controls.Add(panelHeader_AVA);
            MinimumSize = new Size(1866, 1018);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 7 | Проект | Вариант 14 | Анищенко В.А.";
            WindowState = FormWindowState.Maximized;
            Load += FormMain_Load;
            panelHeader_AVA.ResumeLayout(false);
            panelHeader_AVA.PerformLayout();
            panelMiddle_AVA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartNumbersOfTransport_AVA).EndInit();
            ((System.ComponentModel.ISupportInitialize)transportBindingSource).EndInit();
            groupBoxSerch_AVA.ResumeLayout(false);
            groupBoxSerch_AVA.PerformLayout();
            panelInput_AVA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_AVA).EndInit();
            panelOutput_AVA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_AVA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader_AVA;
        private Label labelTitle_AVA;
        private Button buttonSave_AVA;
        private Button buttonAboutProgram_AVA;
        private Panel panelMiddle_AVA;
        private Button buttonSeek_AVA;
        private GroupBox groupBoxSerch_AVA;
        private TextBox textBoxNameSearch_AVA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartNumbersOfTransport_AVA;
        private Panel panelInput_AVA;
        private DataGridView dataGridViewInput_AVA;
        private Splitter splitterData_AVA;
        private Panel panelOutput_AVA;
        private DataGridView dataGridViewOutput_AVA;
        private ToolTip toolTipButton_AVA;
        private SaveFileDialog saveFileDialog_AVA;
        private BindingSource transportBindingSource;
        private Button buttonHelp_AVA;
    }
}