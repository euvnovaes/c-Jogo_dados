using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjJogoDados
{
    public partial class JogoDados : Form
    {
        Sortear sorteio = new Sortear();

        public JogoDados()
        {
            InitializeComponent();
        }

        private void btnDado_Click(object sender, EventArgs e)
        {
            int x = sorteio.sorteio();
            if(x == 0)
                pctDado.Image = Image.FromFile(@"C:\Users\Lab\Desktop\PrjJogoDados\PrjJogoDados\Img\dado1.png");
            if(x == 1)
                pctDado.Image = Image.FromFile(@"C:\Users\Lab\Desktop\PrjJogoDados\PrjJogoDados\Img\dado2.png");
            if(x == 2)
                pctDado.Image = Image.FromFile(@"C:\Users\Lab\Desktop\PrjJogoDados\PrjJogoDados\Img\dado3.png");
            if (x == 3)
                pctDado.Image = Image.FromFile(@"C:\Users\Lab\Desktop\PrjJogoDados\PrjJogoDados\Img\dado4.png");
            if (x == 4)
                pctDado.Image = Image.FromFile(@"C:\Users\Lab\Desktop\PrjJogoDados\PrjJogoDados\Img\dado5.png");
            if (x == 5)
                pctDado.Image = Image.FromFile(@"C:\Users\Lab\Desktop\PrjJogoDados\PrjJogoDados\Img\dado6.png");
        }

        private void rdoAutomatico_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = sorteio.sorteio();
            if (x == 0)
                pctDado.Image = Image.FromFile(@"C:\Users\Lab\Desktop\PrjJogoDados\PrjJogoDados\Img\dado1.png");
            if (x == 1)
                pctDado.Image = Image.FromFile(@"C:\Users\Lab\Desktop\PrjJogoDados\PrjJogoDados\Img\dado2.png");
            if (x == 2)
                pctDado.Image = Image.FromFile(@"C:\Users\Lab\Desktop\PrjJogoDados\PrjJogoDados\Img\dado3.png");
            if (x == 3)
                pctDado.Image = Image.FromFile(@"C:\Users\Lab\Desktop\PrjJogoDados\PrjJogoDados\Img\dado4.png");
            if (x == 4)
                pctDado.Image = Image.FromFile(@"C:\Users\Lab\Desktop\PrjJogoDados\PrjJogoDados\Img\dado5.png");
            if (x == 5)
                pctDado.Image = Image.FromFile(@"C:\Users\Lab\Desktop\PrjJogoDados\PrjJogoDados\Img\dado6.png");
        }

        private void rdoManual_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void btnDado2_Click(object sender, EventArgs e)
        {

            int y = sorteio.sorteio();
            if (y == 0)
                pctDado2.Image = Image.FromFile(@"C:\Users\Lab\Desktop\PrjJogoDados\PrjJogoDados\Img\dado1.png");
            if (y == 1)
                pctDado2.Image = Image.FromFile(@"C:\Users\Lab\Desktop\PrjJogoDados\PrjJogoDados\Img\dado2.png");
            if (y == 2)
                pctDado2.Image = Image.FromFile(@"C:\Users\Lab\Desktop\PrjJogoDados\PrjJogoDados\Img\dado3.png");
            if (y == 3)
                pctDado2.Image = Image.FromFile(@"C:\Users\Lab\Desktop\PrjJogoDados\PrjJogoDados\Img\dado4.png");
            if (y == 4)
                pctDado2.Image = Image.FromFile(@"C:\Users\Lab\Desktop\PrjJogoDados\PrjJogoDados\Img\dado5.png");
            if (y == 5)
                pctDado2.Image = Image.FromFile(@"C:\Users\Lab\Desktop\PrjJogoDados\PrjJogoDados\Img\dado6.png");

        }

    }
}
