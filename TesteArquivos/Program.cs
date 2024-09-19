using TesteArquivos.Entidades;

internal class Program
{
    static void Main(string[] args)
    {
        List<Pessoa> listaDeObjetos = new List<Pessoa>
            {
                new Pessoa { Nome = "João", Idade = 30, Profissao = "Engenheiro" },
                new Pessoa { Nome = "Maria", Idade = 25, Profissao = "Professora" },
                new Pessoa { Nome = "Pedro", Idade = 40, Profissao = "Arquiteto" }
            };

        string timestamp = DateTime.Now.ToString("yyyy_MM_dd_HH_mm");
        string caminhoArquivo = @$"C:\programas\arquivosteste\objetos_{timestamp}.txt";

        // Abre o arquivo com o nome dinâmico
        using (StreamWriter writer = new StreamWriter(caminhoArquivo))
        {
            foreach (var objeto in listaDeObjetos)
            {
                // Para cada objeto, escreve suas propriedades no arquivo
                writer.WriteLine($"Nome: {objeto.Nome}, Idade: {objeto.Idade}, Profissão: {objeto.Profissao}");
            }
        }

        Console.WriteLine($"Objetos gravados no arquivo '{caminhoArquivo}' com sucesso!");
    }
}