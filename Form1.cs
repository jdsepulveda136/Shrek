using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shrek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bt_calcula_Click(object sender, EventArgs e)
        {
            double avenca;

            avenca = Convert.ToUInt32(txt_base.Text);

            //Desconto da idade
            float ano = Convert.ToInt32(txt_nascimento.Text);
            if (ano>=2000)
            {
                avenca = avenca * 0.90;
            }

            //desconto escalão
            if (chk_escalao.Checked)
            {
                avenca = avenca * 0.9;
            }

            //desconto sócio
            if (chk_socio.Checked)
            {
                avenca = avenca * 0.95;
            }

            //agravamento
            if (chk_agrava.Checked)
            {
                avenca = avenca + 12;
            }

            //desconto por residir no disytrito




            txt_result.Text = Convert.ToString(avenca);
        }
    }
}
