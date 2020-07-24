using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEP.DTO
{
   public static class URL
    {
        private static string caminho { get { return "https://viacep.com.br/ws/{0}/json/"; } }

        public static string ConsultaCep { get { return caminho; } }
    }
}
