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
using clasesParaCalculadora;

namespace TareaDeCalculadora
{
    public partial class Form1 : Form
    {
        Calculadora instaciaCalc;
        List<Calculadora> ListaDeCalculadora;
        string numero;
        double result = 0;
        public Form1()
        {
            InitializeComponent();
             
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TbCampoText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bt0_Click(object sender, EventArgs e)
        {
            tbCampoText.Text = tbCampoText.Text + "0";
        }

        private void Bt1_Click(object sender, EventArgs e)
        {
            tbCampoText.Text = tbCampoText.Text + "1";
        }

        private void Bt2_Click(object sender, EventArgs e)
        {
            tbCampoText.Text = tbCampoText.Text + "2";
        }

        private void Bt3_Click(object sender, EventArgs e)
        {
            tbCampoText.Text = tbCampoText.Text + "3";
        }

        private void Bt4_Click(object sender, EventArgs e)
        {
            tbCampoText.Text = tbCampoText.Text + "4";
        }

        private void Bt5_Click(object sender, EventArgs e)
        {
            tbCampoText.Text = tbCampoText.Text + "5";
        }

        private void Bt6_Click(object sender, EventArgs e)
        {
            tbCampoText.Text = tbCampoText.Text + "6";
        }

        private void Bt7_Click(object sender, EventArgs e)
        {
            tbCampoText.Text = tbCampoText.Text + "7";
        }

        private void Bt8_Click(object sender, EventArgs e)
        {
            tbCampoText.Text = tbCampoText.Text + "8";
        }

        private void Bt9_Click(object sender, EventArgs e)
        {
            tbCampoText.Text = tbCampoText.Text + "9";
        }

        private void BtPuntp_Click(object sender, EventArgs e)
        {
            tbCampoText.Text = tbCampoText.Text + ".";
        }

        private void BtSuma_Click(object sender, EventArgs e)
        {
            tbCampoText.Text = tbCampoText.Text + "+";
        }

        private void BtResta_Click(object sender, EventArgs e)
        {
            tbCampoText.Text = tbCampoText.Text + "-";
        }

        private void BtMultiplicacion_Click(object sender, EventArgs e)
        {
            tbCampoText.Text = tbCampoText.Text + "*";
        }

        private void BtDivicion_Click(object sender, EventArgs e)
        {
            tbCampoText.Text = tbCampoText.Text + "/";
        }

        private void BtC_Click(object sender, EventArgs e)
        {
            tbCampoText.Text = "";
        }

        private void BtIgual_Click(object sender, EventArgs e)
        {
            //tbCampoText.Text = tbCampoText.Text + "=" ;
            instaciaCalc = new Calculadora();
            numero = tbCampoText.Text;
            result = instaciaCalc.Calculador(numero);
            tbCampoText.Text = Convert.ToString(result);
            ListaDeCalculadora = new List<Calculadora>();
            ListaDeCalculadora.Add(instaciaCalc);
            foreach (Calculadora item in ListaDeCalculadora)
            {
                lbListaHistorial.Items.Add(item.Mostrar(numero));
            }

        }
        private void formKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0) Bt0_Click(sender, e);
            if (e.KeyCode == Keys.NumPad1) Bt1_Click(sender, e);
            if (e.KeyCode == Keys.NumPad2) Bt2_Click(sender, e);
            if (e.KeyCode == Keys.NumPad3) Bt3_Click(sender, e);
            if (e.KeyCode == Keys.NumPad4) Bt4_Click(sender, e);
            if (e.KeyCode == Keys.NumPad5) Bt5_Click(sender, e);
            if (e.KeyCode == Keys.NumPad6) Bt6_Click(sender, e);
            if (e.KeyCode == Keys.NumPad7) Bt7_Click(sender, e);
            if (e.KeyCode == Keys.NumPad8) Bt8_Click(sender, e);
            if (e.KeyCode == Keys.NumPad9) Bt9_Click(sender, e);

            if (e.KeyCode == Keys.Decimal) BtPuntp_Click(sender, e);

            if (e.KeyCode == Keys.Add) BtSuma_Click(sender, e);
            if (e.KeyCode == Keys.Subtract) BtResta_Click(sender, e);
            if (e.KeyCode == Keys.Multiply) BtMultiplicacion_Click(sender, e);
            if (e.KeyCode == Keys.Divide) BtDivicion_Click(sender, e);

            if (e.KeyCode == Keys.Return) BtIgual_Click(sender, e);

        }

        private void tbText_Enter(object sender, EventArgs e)
        {
            this.Focus();
            HideCaret();
        }
        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);
        public void HideCaret()
        {
            HideCaret(tbCampoText.Handle);
        }

        private void LbListaHistorial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbListaHistorial.TopIndex != lbListaHistorial.SelectedIndex)
            { 
                lbListaHistorial.TopIndex = lbListaHistorial.SelectedIndex;
            }
            for (int x = (lbListaHistorial.SelectedIndex); x >= 0; x--)
            {
                lbListaHistorial.Items.RemoveAt(x);
            }

        }
    }
}
