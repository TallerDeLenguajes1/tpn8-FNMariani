using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TP8
{
    public partial class Calc : Form
    {
        Calculadora InstanciaCalculadora;
        string expresion;
        bool n1Cargado = false;
        string operacion = "";

        List<Calculadora> listaCalculadora = new List<Calculadora>();
        public Calc()
        {
            InitializeComponent();
            InstanciaCalculadora = new Calculadora();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            expresion = null;
            tbText.Text = expresion;
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            //if(e.GetType.)
            expresion += "0";
            tbText.Text = expresion;
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            expresion += "1";
            tbText.Text = expresion;
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            expresion += "2";
            tbText.Text = expresion;
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            expresion += "3";
            tbText.Text = expresion;
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            expresion += "4";
            tbText.Text = expresion;
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            expresion += "5";
            tbText.Text = expresion;
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            expresion += "6";
            tbText.Text = expresion;
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            expresion += "7";
            tbText.Text = expresion;
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            expresion += "8";
            tbText.Text = expresion;
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            expresion += "9";
            tbText.Text = expresion;
        }

        private void btPunto_Click(object sender, EventArgs e)
        {
            if(expresion != null && !expresion.Contains("."))
            {
                expresion += ".";
                tbText.Text = expresion;
            }
        }

        private void btSuma_Click(object sender, EventArgs e)
        {
            operacion = "+";
            if (expresion != null)
            {
                if (n1Cargado == false)
                {
                    n1Cargado = true;
                    InstanciaCalculadora.Numero1 = float.Parse(expresion);
                    expresion = null;
                    tbText.Text = expresion;
                }
                else
                {
                    InstanciaCalculadora.Numero2 = float.Parse(expresion);
                    expresion = null;

                    tbText.Text = Convert.ToString(InstanciaCalculadora.Suma());

                    //Reseteamos valores
                    n1Cargado = false;
                }
            }
        }

        private void btResta_Click(object sender, EventArgs e)
        {
            operacion = "-";
            if (expresion != null)
            {
                if (n1Cargado == false)
                {
                    n1Cargado = true;
                    InstanciaCalculadora.Numero1 = float.Parse(expresion);
                    expresion = null;
                    tbText.Text = expresion;
                }
                else
                {
                    InstanciaCalculadora.Numero2 = float.Parse(expresion);
                    expresion = null;

                    tbText.Text = Convert.ToString(InstanciaCalculadora.Resta());

                    //Reseteamos valores
                    n1Cargado = false;
                }
            }
        }

        private void btMultiplicacion_Click(object sender, EventArgs e)
        {
            operacion = "*";
            if (expresion != null)
            {
                if (n1Cargado == false)
                {
                    n1Cargado = true;
                    InstanciaCalculadora.Numero1 = float.Parse(expresion);
                    expresion = null;
                    tbText.Text = expresion;
                }
                else
                {
                    InstanciaCalculadora.Numero2 = float.Parse(expresion);
                    expresion = null;

                    tbText.Text = Convert.ToString(InstanciaCalculadora.Multiplicacion());

                    //Reseteamos valores
                    n1Cargado = false;
                }
            }
        }

        private void btDivision_Click(object sender, EventArgs e)
        {
            operacion = "/";
            if (expresion != null)
            {
                if (n1Cargado == false)
                {
                    n1Cargado = true;
                    InstanciaCalculadora.Numero1 = float.Parse(expresion);
                    expresion = null;
                    tbText.Text = expresion;
                }
                else
                {
                    InstanciaCalculadora.Numero2 = float.Parse(expresion);
                    //Consideramos en caso de que el segundo numero sea 0
                    if(InstanciaCalculadora.Numero2 == 0)
                    {
                        expresion = "ERROR! No se puede dividir.";
                        tbText.Text = expresion;
                        expresion = null;
                    }
                    else
                    {
                        expresion = null;
                        tbText.Text = Convert.ToString(InstanciaCalculadora.Division());
                    }

                    //Reseteamos valores
                    n1Cargado = false;
                }
            }
        }

        private void btIgual_Click(object sender, EventArgs e)
        {
            if (expresion != null)
            {
                if (n1Cargado == true)
                {
                    InstanciaCalculadora.Numero2 = float.Parse(expresion);
                    expresion = null;
                    //tbText.Text = InstanciaCalculadora.Numero1 + operacion + InstanciaCalculadora.Numero2;

                    if(operacion == "+") tbText.Text = Convert.ToString(InstanciaCalculadora.Suma());
                    if(operacion == "-") tbText.Text = Convert.ToString(InstanciaCalculadora.Resta());
                    if(operacion == "*") tbText.Text = Convert.ToString(InstanciaCalculadora.Multiplicacion());
                    if(operacion == "/")
                    {
                        //Consideramos en caso de que el segundo numero sea 0
                        if (InstanciaCalculadora.Numero2 == 0)
                        {
                            expresion = "ERROR! No se puede dividir.";
                            tbText.Text = expresion;
                            expresion = null;
                        }
                        else
                        {
                            expresion = null;
                            tbText.Text = Convert.ToString(InstanciaCalculadora.Division());
                        }
                    }

                    //Agregamos fecha de la operacion
                    InstanciaCalculadora.Fecha = DateTime.Now;

                    //Agregamos la expresion en la instancia de calculadora
                    InstanciaCalculadora.Expresion = InstanciaCalculadora.Fecha.ToString("MM/dd/yyyy H:mm") + " ---> " + InstanciaCalculadora.Numero1 + operacion + InstanciaCalculadora.Numero2 + '=' + tbText.Text;

                    //Agregamos la instancia a la lista
                    listaCalculadora.Add(InstanciaCalculadora);

                    //Agregamos la lista en el listBox
                    lbHistorial.Items.Add(InstanciaCalculadora.Expresion);

                    InstanciaCalculadora = new Calculadora();
                    n1Cargado = false;
                }
                else
                {

                }
            }
        }

        private void formKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0) bt0_Click(sender, e);
            if (e.KeyCode == Keys.NumPad1) bt1_Click(sender, e);
            if (e.KeyCode == Keys.NumPad2) bt2_Click(sender, e);
            if (e.KeyCode == Keys.NumPad3) bt3_Click(sender, e);
            if (e.KeyCode == Keys.NumPad4) bt4_Click(sender, e);
            if (e.KeyCode == Keys.NumPad5) bt5_Click(sender, e);
            if (e.KeyCode == Keys.NumPad6) bt6_Click(sender, e);
            if (e.KeyCode == Keys.NumPad7) bt7_Click(sender, e);
            if (e.KeyCode == Keys.NumPad8) bt8_Click(sender, e);
            if (e.KeyCode == Keys.NumPad9) bt9_Click(sender, e);

            if (e.KeyCode == Keys.Decimal) btPunto_Click(sender, e);

            if (e.KeyCode == Keys.Add) btSuma_Click(sender, e);
            if (e.KeyCode == Keys.Subtract) btResta_Click(sender, e);
            if (e.KeyCode == Keys.Multiply) btMultiplicacion_Click(sender, e);
            if (e.KeyCode == Keys.Divide) btDivision_Click(sender, e);

            if (e.KeyCode == Keys.Return) btIgual_Click(sender, e);

        }

        private void tbText_Enter(object sender, EventArgs e)
        {
            this.Focus();
            HideCaret();
        }

        //Para esconder el cursor de input del textbox
        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);
        public void HideCaret()
        {
            HideCaret(tbText.Handle);
        }

        private void lbHistorial_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbHistorial.SelectedItem != null)
            {
                //Removemos item del listBox y de la lista
                listaCalculadora.RemoveAt(lbHistorial.SelectedIndex);
                lbHistorial.Items.Remove(lbHistorial.SelectedItem);
                //Refrescamos el listBox
                lbHistorial.Refresh();
            }
        }
    }
}
