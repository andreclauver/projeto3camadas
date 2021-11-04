using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto3Camadas
{
    public partial class FrmFutebol : Form
    {
        TimeBLL medbll = new TimeBLL();
        TimeDTO meddto = new TimeDTO();

        public FrmFutebol()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            meddto.Time = txt_time.Text;
            meddto.Torcida = txt_torcida.Text;

            medbll.inserir(meddto);

            MessageBox.Show("Cadastrado", "time", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txt_ID.Clear();
            txt_time.Clear();
            txt_torcida.Clear();
        }
    }
}
