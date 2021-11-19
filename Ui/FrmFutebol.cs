using Projeto3Camadas.Code.BLL;
using Projeto3Camadas.Code.DTO;
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

        private void FrmFutebol_Load(object sender, EventArgs e)
        {
            dgvFutebol.DataSource = medbll.Listar();
        }

        private void dvgFutebol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ID.Text = dvgFutebol.Rows{ e.RowIndex}.Cells{0}.Value.ToString();
            txt_time.Text = dvgFutebol.Rows{ e.RowIndex}.Cells{1}.Value.ToString();
            txt_torcida.Text = dvgFutebol.Rows{ e.RowIndex}.Cells{2}.Value.ToString();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            meddto.ID = int.Parse(txt_ID.Text);
            meddto.Time = txt_time.Text;
            meddto.Torcida = txt_torcida.Text;

            medbll.Editar(meddto);

            MessageBox.Show("Alterado!","Futebol", MessageBoxButtons.OK, MessageBoxIcon.Information);

            medbll.Listar();

            txt_ID.Clear();
            txt_time.Clear();
            txt_torcida.Clear();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            meddto.Id. = int.Parse(txt_ID.Text);

            medbll.Excluir(meddto);

            MessageBox.Show("Excluido!", "Futebol", MessageBoxButtons.OK, MessageBoxIcon.Information);

            medbll.Listar();

            txt_ID.Clear();
            txt_time.Clear();
            txt_torcida.Clear();
        }
    }
}
