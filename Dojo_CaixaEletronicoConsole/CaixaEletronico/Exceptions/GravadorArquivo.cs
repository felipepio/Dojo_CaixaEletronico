using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico.Util
{
    public class GravadorArquivo
    {
        public GravadorArquivo()
        {

        }

        public bool EscreverArquivo(string nomeArquivo, string linha)
        {
            try
            {
                using (var writer = new StreamWriter(nomeArquivo, true, Encoding.UTF8))
                {
                    writer.Write(linha + "\n");
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
