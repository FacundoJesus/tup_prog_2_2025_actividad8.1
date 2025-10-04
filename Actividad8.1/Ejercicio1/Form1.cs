using Ejercicio1.Models;
using System.Runtime.Intrinsics.X86;
namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Cuenta> cuentas = new List<Cuenta>();
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;
            int dni = Convert.ToInt32(tbDNI.Text);
            double importe = Convert.ToDouble(tbImporte.Text);

            Cuenta nuevaCuenta = new Cuenta(nombre, dni, importe);
            cuentas.Sort();
            int idx = cuentas.BinarySearch(nuevaCuenta);
            if (idx > -1)
            {
                cuentas[idx].Nombre = nuevaCuenta.Nombre;
                cuentas[idx].Importe = nuevaCuenta.Importe;
            }
            else
            {
                cuentas.Add(nuevaCuenta);
            }
            btnActualizar.PerformClick();

            #region Limpio campos
            tbNombre.Clear();
            tbImporte.Clear();
            tbDNI.Clear();
            #endregion
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            lsbResult.Items.Clear();
            foreach (Cuenta c in cuentas)
            {
                lsbResult.Items.Add(c);
            }
        }

        private void lsbResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cuenta c = lsbResult.SelectedItem as Cuenta;
            if (c != null)
            {
                tbNombre.Text = c.Nombre;
                tbDNI.Text = Convert.ToString(c.DNI);
                tbImporte.Text = Convert.ToString(c.Importe);

            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivos TXT|*.txt|Todos los archivos|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                FileStream fs = null;
                StreamReader sr = null;
                
                try
                {
                    fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);
                    while (!sr.EndOfStream)
                    {
                        string linea = sr.ReadLine();

                        string dni = linea.Substring(0, 9).Trim();
                        string nombre = linea.Substring(9, 10).Trim();
                        string importe = linea.Substring(19, 9).Trim();

                        Cuenta c = new Cuenta(nombre, Convert.ToInt32(dni), Convert.ToDouble(importe));
                        cuentas.Sort();
                        int idx = cuentas.BinarySearch(c);
                        if (idx > -1)
                        {
                            cuentas[idx].Nombre = c.Nombre;
                            cuentas[idx].Importe = c.Importe;
                        }
                        else
                        {
                            cuentas.Add(c);
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (sr != null) { sr.Close(); }
                    if (fs != null) { fs.Close(); }
                }
                btnActualizar.PerformClick();
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Archivos TXT|*.txt|Todos los archivos|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) { 
                string path = saveFileDialog1.FileName;
                FileStream fs = null;
                StreamWriter sw = null;
                try
                {
                    fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                    sw = new StreamWriter(fs);
                    foreach(Cuenta c in cuentas)
                    {
                        string nombre = c.Nombre;
                        if(nombre.Length > 10)
                        {
                            nombre = c.Nombre.Substring(0, 10);
                        }
                        string linea = $"{c.DNI,+9}{nombre,-10}{c.Importe,+9:f2}";
                        sw.WriteLine(linea);
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if(sw!=null) sw.Close();
                    if (fs != null) fs.Close();
                }
            }
        }


        
    }
}
