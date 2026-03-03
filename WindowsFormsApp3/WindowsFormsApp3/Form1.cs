using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp3
{
    public partial class Form1: Form
    {
        int n, m, i, j;

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {
                dataGridView1.Rows.RemoveAt(cell.RowIndex);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog
                folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Выбирете папку для сохранения";
                folderDialog.ShowNewFolderButton = true;
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string selectedPath = folderDialog.SelectedPath;
                        string fileName = $"База_данных_{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.txt";
                        string fullPath = Path.Combine(selectedPath, fileName);
                        List<string> lines = new List<string>();
                        lines.Add("Фамилия\tИмя\tТелефон");
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                string lastName = row.Cells["Фамилия"].Value?.ToString() ?? "";
                                string firstName = row.Cells["Имя"].Value?.ToString() ?? "";
                                string phone = row.Cells["Телефон"].Value?.ToString() ?? "";
                                lines.Add($"{lastName}\t{firstName}\t{phone}");
                            }
                        }
                        File.WriteAllLines(fullPath, lines, Encoding.UTF8);
                        MessageBox.Show($"База успешно сохранена!\nПуть: {fullPath}",
                            "Сохранение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }      
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Диалог выбора файла
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Выберите базу данных";
            openFileDialog.Filter = "Все файлы (*.*)|*.*|База данных (*.db;*.sql;*.txt)|*.db;*.sql;*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                // Тут можно обработать выбранный файл
                MessageBox.Show($"Вы выбрали файл: {selectedFilePath}");
                // Например, загрузить базу или обработать файл
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int rowNumber = dataGridView1.Rows.Add();
            
            dataGridView1.Rows[rowNumber].Cells["ID"].Value = rowNumber;
            dataGridView1.Rows[rowNumber].Cells[1].Value = textBox1.Text;
            dataGridView1.Rows[rowNumber].Cells[2].Value = textBox2.Text;
            
            dataGridView1.Rows[rowNumber].Cells["Tel"].Value = textBox3.Text;
            
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("ID", "Id");
            dataGridView1.Columns.Add("Fa", "Фамилия");
            dataGridView1.Columns.Add("Name", "Имя");
            dataGridView1.Columns.Add("Tel", "Телефон");
        }
    }
}
