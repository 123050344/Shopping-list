using Microsoft.Office.Interop.Word;
using OfficeOpenXml;
using Shopping_list;
using System.Diagnostics;
using System.IO;

namespace Informacion_estudiantes
{
    public partial class Form1 : Form
    {
        private int number;
        public Form1()
        {
            InitializeComponent();
            number = 0;

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string buys = txtcompras.Text;
            number++;
            slist compra = new slist(number, buys);
            listcompras.Items.Add(compra.ToString());

        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            try
            {

                string carpetaDestino = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                string rutaArchivo = Path.Combine(carpetaDestino, "Shopping list.txt");


                using (StreamWriter writer = new StreamWriter(rutaArchivo))
                {

                    foreach (ListViewItem item in listcompras.Items)
                    {
                        writer.WriteLine(item.Text);
                        foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                        {
                            writer.WriteLine(subItem.Text);
                        }
                    }
                }

                MessageBox.Show("Data saved correctly in: " + rutaArchivo, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

