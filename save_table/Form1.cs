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

namespace save_table
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileBTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog.FileName;
            // читаем файл в строку
            try
            {
                string fileText = File.ReadAllText(filename);
                //MessageBox.Show("Файл открыт");
                DataTable dt = new DataTable();
                using (StreamReader sr = new StreamReader(filename, Encoding.Default))
                {
                    string[] headers = sr.ReadLine().Split(';');
                    foreach (string header in headers)
                    {
                        dt.Columns.Add(header);
                    }
                    while (!sr.EndOfStream)
                    {
                        string[] rows = sr.ReadLine().Split(';');
                        DataRow dr = dt.NewRow();
                        if (rows.Count() < headers.Count())
                        {
                            dr[headers.Count() - 1] = rows[0];
                        }
                        else
                        {
                            for (int i = 0; i < headers.Length; i++)
                            {
                                dr[i] = rows[i];
                            }
                        }
                       
                        dt.Rows.Add(dr);
                    }

                }
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void saveInFileBTN_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files(*.csv)|*.csv|All files(*.*)|*.*|txt files(*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog.FileName;
            // сохраняем текст в файл
            FileStream fs = new FileStream(filename, FileMode.OpenOrCreate);
            StreamWriter streamWriter = new StreamWriter(fs);
            
            try
            {

                for (int k = 0; k < dataGridView1.Columns.Count; k++)
                {
                    streamWriter.Write(dataGridView1.Columns[k].HeaderText.ToString() );
                    if (k < dataGridView1.Columns.Count - 1) streamWriter.Write(";");
                }
                streamWriter.WriteLine();
                for (int j = 0; j < dataGridView1.Rows.Count-1; j++)
                {
                    for (int i = 0; i < dataGridView1.Rows[j].Cells.Count; i++)
                    {
                        streamWriter.Write(dataGridView1.Rows[j].Cells[i].Value);
                        if(i < dataGridView1.Rows[j].Cells.Count-1) streamWriter.Write(";");
                    }

                    streamWriter.WriteLine();
                }

                streamWriter.Close();
                fs.Close();

                MessageBox.Show("Файл успешно сохранен");
            }
            catch
            {
                MessageBox.Show("Ошибка при сохранении файла!");
            }
        }
    }
}
