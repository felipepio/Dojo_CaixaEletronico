using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitarios
{
    public class GravadorArquivo
    {
        public GravadorArquivo()
        {

        }

        public bool EscreverArquivo(string caminhoArquivo, string nomeArquivo, string linha)
        {
            string arquivo = caminhoArquivo + nomeArquivo;
            try
            {
                using (var writer = new StreamWriter(arquivo, true, Encoding.Default))
                {
                    writer.WriteLine(linha);
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool SobreescreverArquivo(string caminhoArquivo, string nomeArquivo)
        {
            {
                string arquivo = caminhoArquivo + nomeArquivo;
                try
                {
                    using (var writer = new StreamWriter(arquivo, false, Encoding.UTF8))
                    {
                        writer.Write("");
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public string dirGravacao = "d:\\Users\\314594\\Desktop\\Dojo C#\\CaixaEletronico\\Logs\\";

    }
}
