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
            if (Valida_dados())
            {
                Calcula_avenca();
            }
        }

       private void Txt_nascimento_TextChanged(object sender, EventArgs e)
        {
            if (Valida_dados())
            {
                Calcula_avenca();
            }
        }

        private void Txt_base_TextChanged(object sender, EventArgs e)
        {
            if (Valida_dados())
            {
                Calcula_avenca();
            }
        }

        private void Chk_escalao_CheckedChanged(object sender, EventArgs e)
        {
            if (Valida_dados())
            {
                Calcula_avenca();
            }
        }

        private void Chk_socio_CheckedChanged(object sender, EventArgs e)
        {
            if (Valida_dados())
            {
                Calcula_avenca();
            }
        }

        private void Chk_agrava_CheckedChanged(object sender, EventArgs e)
        {
            if (Valida_dados())
            {
                Calcula_avenca();
            }
        }

        private void Rb_sim_CheckedChanged(object sender, EventArgs e)
        {
            if (Valida_dados())
            {
                Calcula_avenca();
            }
        }

        private void Cmb_concelho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Valida_dados())
            {
                Calcula_avenca();
            }
        }

        private void Rb_nao_CheckedChanged(object sender, EventArgs e)
        {
            if (Valida_dados())
            {
                Calcula_avenca();
            }
        }

        //#############################################################################################################################################################
        //Função que calcula o valor da avença final
        public void Calcula_avenca()
        {
            double avenca_inicial = 0;
            double avenca_final = 0;
            double descontos = 0;
            double agravamento = 0;
            double ano = 0;

            if (Valida_dados())
            {
               lbl_mensagem.Text = " ";
            }

            try
            {
                avenca_inicial = Convert.ToUInt32(txt_base.Text);
            }
            catch (Exception)
            {

                lbl_mensagem.Text = "Valor da avença inválido";
            }

            try
            {
                ano = Convert.ToInt32(txt_nascimento.Text);
            }
            catch (Exception)
            {
                lbl_mensagem.Text = "Ano de nascimento inválido.";
            }



            //Desconto da idade
            if (ano >= 2000)
            {
                descontos = descontos + (avenca_inicial * 0.10);
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

            //desconto por residir no distrito
            if (rb_sim.Checked)
            {
                descontos = descontos + (avenca_inicial * 0.01);
            }

            //Desconto por morar em Amares
            if (cmb_concelho.Text == "Amares")
            {
                descontos = descontos + (avenca_inicial * 0.20);
            }

            //calculo da avenca final
           avenca_final = avenca_inicial - descontos + agravamento;
            txt_result.Text = Convert.ToString(avenca_final);
           
        }


        //#############################################################################################################################################################
        //Função que valida se os dados foram preenchidos
        public Boolean Valida_dados()
        {
            bool estado = true;

         
            if (txt_nome.TextLength==0)
            {
                estado = false;
                lbl_mensagem.Text = "Porfavor preencha o nome";
            }
            else
            {
                if (txt_base.TextLength==0)
                {
                    estado = false;
                    lbl_mensagem.Text = "Por favor preencha o valor da avença";
                }
                else
                {
                    if (txt_nascimento.TextLength==0)
                    {
                        estado = false;
                        lbl_mensagem.Text = "Por favor preencha o ano de nascimento";
                    }
                }
            }

            return estado;
        }
    }
}
