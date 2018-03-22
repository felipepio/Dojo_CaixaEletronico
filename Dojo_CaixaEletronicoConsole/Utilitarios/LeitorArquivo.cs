using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitarios
{
    public class LeitorArquivo
    {
        public LeitorArquivo()
        {

        }

        public IList<string> LerLinhasArquivo(string caminhoArquivo, string nomeArquivo)
        {
            var retorno = new List<string>();
            StreamReader sr = null;
            string arquivo = caminhoArquivo + nomeArquivo;
            try
            {
                sr = new StreamReader(arquivo);
                using (sr)
                {
                    var linha = sr.ReadLine();
                    while (linha != null)
                    {
                        retorno.Add(linha);
                        linha = sr.ReadLine();
                    }
                }
            }
            catch (Exception ex)
            {
                //TO DO: Tratar exception
            }
            finally
            {
                if (sr != null)
                    sr.Close();
            }

            return retorno;

        }

        public string dirLeitura = "d:\\Users\\314594\\Desktop\\Dojo C#\\CaixaEletronico\\Logs\\";

    }
}
