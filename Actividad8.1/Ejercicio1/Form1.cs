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
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;

                FileStream fs = new FileStream(path,FileMode.Open,FileAccess.Read);
                StreamReader sr = new StreamReader(fs);

                while(!sr.EndOfStream)
                {
                    string linea = sr.ReadLine();

                    string dni = linea.Substring(0, 9);
                    string nombre = linea.Substring(9,10).Trim();
                    string importe = linea.Substring(19, 9);

                    Cuenta c = new Cuenta(nombre, Convert.ToInt32(dni), Convert.ToInt32(importe));

                    //BUSCARLO ORDENARLO Y SI NO EXISTE CREARLO



                }

            }
        }
    }
}
