using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3Camadas.Code.BLL
{
    class TimeBLL
    {

        AcessoBancoDados conexao = new AcessoBancoDados();
        string tabela = "tbl_Time";

        public void inserir(TimeDTO medDto)
        {
            string inserir = $"insert into {tabela} values (null,'{medDto.Time} ";
            conexao.ExecutarComando(inserir);
        }
    }
}
