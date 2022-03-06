using System.IO;

namespace ExemploPoo.Helper
{
    public class FileHelper
    {
        public void ListarDiretorios(string caminho)
        {
            var returnoCaminho = Directory.GetDirectories(caminho, "*", SearchOption.AllDirectories);

            foreach (var retorno in returnoCaminho)
            {
                System.Console.WriteLine(retorno);
            }
        }
        public void ListarArquivosDiretorios(string caminho)
        {
            var retornoArquivos = Directory.GetFiles(caminho, "*2*", SearchOption.AllDirectories);
            foreach (var retorno in retornoArquivos)
            {
                System.Console.WriteLine(retorno);
            }
        }

        internal void ApagarDiretorio(string v)
        {
            throw new NotImplementedException();
        }

        public void CriarDiretorio(string caminho)
        {
            var retorno = Directory.CreateDirectory(caminho);
            System.Console.WriteLine(retorno.FullName);
        }
        public void ApagarDiretorio(string caminho, bool apagarArquivos)
        {
            Directory.Delete(caminho, apagarArquivos);
        }
        public void CriarArquivoTexto(string caminho, string conteudo)
        {
            if (!File.Exists(caminho))
            {
                File.WriteAllText(caminho, conteudo);
            }
        }
        public void CriarArquivoTextoStream(string camimho, List<string> conteudo)
        {
            using (var stream = File.CreateText(camimho))
            {
                foreach (var linha in conteudo)
                {
                    stream.WriteLine(linha);
                }
            }
        }
        public void AdicionarTexto(string caminho, string conteudo)
        {
            File.AppendAllText(caminho, conteudo);
        }
        public void AdicionarTextoStream(string camimho, List<string> conteudo)
        {
            using (var stream = File.AppendText(camimho))
            {
                foreach (var linha in conteudo)
                {
                    stream.WriteLine(linha);
                }
            }
        }
        public void LerArquivo(string caminho)
        {
            var conteudo = File.ReadAllLines(caminho);
            foreach (var linha in conteudo)
            {
                System.Console.WriteLine(linha);
            }
        }
        public void LerArquivoStream(string camimho)
        {
            string linha = string.Empty;

            using (var stream = File.OpenText(camimho))
            {
                while ((linha = stream.ReadLine()) != null)
                {
                    System.Console.WriteLine(linha);
                }
            }
        }
        public void MoverArquivo(string caminho, string novoCaminho, bool sobrescrever)
        {
            File.Move(caminho, novoCaminho, sobrescrever);
        }
        public void CopiarArquivo(string caminho, string novoCaminho, bool sobrescrever)
        {
            File.Copy(caminho, novoCaminho, sobrescrever);
        }
        public void DeletarAquivo(string caminho)
        {
            File.Delete(caminho);
        }
    }
}