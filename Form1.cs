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
            double avenca_inicial=0;
            double avenca_final = 0;
            double descontos = 0;
            double agravamento = 0;

            avenca_inicial = Convert.ToUInt32(txt_base.Text);

            //Desconto da idade
            float ano = Convert.ToInt32(txt_nascimento.Text);
            if (ano>=2000)
            {
                descontos = descontos+(avenca_inicial * 0.10);
            }

            //desconto escalão
            if (chk_escalao.Checked)
            {
                descontos = descontos + (avenca_inicial * 0.10);
            }

            //desconto sócio
            if (chk_socio.Checked)
            {
                descontos = descontos + (avenca_inicial * 0.05);
            }

            //agravamento
            if (chk_agrava.Checked)
            {
                agravamento = 12;
            }

            //desconto por residir no disytrito



            //calculo da avenca final
            avenca_final = avenca_inicial - descontos + agravamento;

            txt_result.Text = Convert.ToString(avenca_final);
        }
    }
}
