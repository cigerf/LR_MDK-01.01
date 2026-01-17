using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //FileNamesListBox.Items.Add("Шышка");
            //FileNamesListBox.Items.Add("Дом");
            //FileNamesListBox.Items.Add("Кот");
        }

        private void FileNamesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(FileNamesListBox.SelectedIndex.ToString());
            //MessageBox.Show(FileNamesListBox.SelectedItem.ToString());
            PictureArea.Image = Image.FromFile(FileNamesListBox.SelectedItem.ToString());
            PictureArea.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                var filePath = string.Empty;

                openFileDialog.Filter = "image files (*.JPG)|*.JPG|image files (*.PNG)|*.PNG|image files (*.BMP)|*.BMP";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    FileNamesListBox.Items.Add(filePath);
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string message = "Точно хотите удалить?";
            string caption = "Удаление";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if(result == System.Windows.Forms.DialogResult.Yes)
            {
                int index = FileNamesListBox.SelectedIndex;
                FileNamesListBox.Items.RemoveAt(index);
            }
        }
    }
}
