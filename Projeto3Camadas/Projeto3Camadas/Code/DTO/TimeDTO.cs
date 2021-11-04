using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3Camadas.Code.DTO
{
    class TimeDTO
    {
        private int _id;
        private string _futebol;
        private string _torcida;

        public int id { get => _id; set => _id = value;  }

        public string futebol { get => _futebol; set => _futebol = value; }

        public string torcida { get => _torcida; set => _torcida = value; }
    }
}
