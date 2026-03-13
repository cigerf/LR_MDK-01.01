using ChartTest.Views;

namespace LiveCharts
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.pieChart = new LiveCharts.WinForms.PieChart();
            this.CartesianChart = new ChartTest.Views.SalesCartesianChart();
            this.SuspendLayout();
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.Location = new System.Drawing.Point(0, 0);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(120, 450);
            this.ItemsListBox.TabIndex = 0;
            this.ItemsListBox.SelectedIndexChanged += new System.EventHandler(this.ItemsList_SelectedIndexChanged);
            // 
            // pieChart
            // 
            this.pieChart.Dock = System.Windows.Forms.DockStyle.Right;
            this.pieChart.Location = new System.Drawing.Point(600, 0);
            this.pieChart.Name = "pieChart";
            this.pieChart.Size = new System.Drawing.Size(200, 450);
            this.pieChart.TabIndex = 2;
            // 
            // CartesianChart
            // 
            this.CartesianChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CartesianChart.Location = new System.Drawing.Point(120, 0);
            this.CartesianChart.Name = "CartesianChart";
            this.CartesianChart.Size = new System.Drawing.Size(680, 450);
            this.CartesianChart.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pieChart);
            this.Controls.Add(this.CartesianChart);
            this.Controls.Add(this.ItemsListBox);
            this.Name = "MainForm";
            this.Text = "Кафе";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ItemsListBox;
        private WinForms.CartesianChart Cartesian;
        private WinForms.PieChart pieChart;
        private SalesCartesianChart CartesianChart;
    }
}

