using System;
using System.Collections.Generic;
using System.Data;
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

        public DataTable Listar()   
        {
            string sql = $"select * from {tabela} order by id;";
            return conexao.ExecutarConsulta(sql);
        }

        public void Editar(TimeDTO medDTO)
        {
            string alterar = $"update {tabela} set time = '{medDTO.Time}', torcida = '{medDTO.Torcida}' where id = '{medDTO.Id}';";]
            conexao.ExecutarComando(alterar);
        }

        public void Excluir(TimeDTO medDto)
        {
            string excluir = $" delete from {Tabela} where id = '{medDto.Id}';";
            conexao.ExecutarComand(excluir);
        }
    }
}
