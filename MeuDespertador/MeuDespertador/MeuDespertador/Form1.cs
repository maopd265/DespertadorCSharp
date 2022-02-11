using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace MeuDespertador
{
    public partial class Frm_Temporizador : Form
    {
        SoundPlayer soundMedia = new SoundPlayer(@"C:\Users\User\Downloads\sound.wav");
        public Frm_Temporizador()
        {
            InitializeComponent();

        }

        private async void Btn_Ativar_Click(object sender, EventArgs e)
        {
            string horario ;
            int min;
            if (Txt_Minutos.Text != "")
            {
                Txt_Minutos.ReadOnly = true;
            }
           
            soundMedia.Load();
            DateTime dt = new DateTime();
            dt = DateTime.Now;
                horario = Convert.ToString(dt.Hour + ":" + dt.Minute + ":" + dt.Second);
            Lbl_TempoInicial.Text = horario;
            if (Txt_Minutos.Text != "")
            {
                min = int.Parse(Txt_Minutos.Text);
                //Thread.Sleep(min* 60000);
                await Task.Delay(min * 60000);
                dt = DateTime.Now;
                horario = Convert.ToString(dt.Hour + ":" + dt.Minute + ":" + dt.Second);
                Lbl_TempoAtual.Text = horario;
                Lbl_TempoAtual.ForeColor = Color.Red;
                soundMedia.PlayLooping();
                Txt_Minutos.ReadOnly = false;
                MessageBox.Show("Hora do intervalo!", "Mensagem de aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Preencha o campo de minutos!", "Mensagem de erro",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }

        private void Btn_Pausar_Click(object sender, EventArgs e)
        {
            soundMedia.Stop();
        }

        private void Btn_Resetar_Click(object sender, EventArgs e)
        {
            Lbl_TempoAtual.Text = "";
            Lbl_TempoInicial.Text = "";
            Txt_Minutos.Text = "";
        }
    }
}
