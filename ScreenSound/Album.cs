class Album
{
    // Constructor
    public Album(string nome)
    {
        NomeAlbum = nome;
    }

    // Declaração de atributos e propriedades da classe
    private List<Musica> musicas = new List<Musica>();

    public string NomeAlbum { get; }
    public int DuracaoTotal => musicas.Sum(x => x.Duracao);

    //Método para adicionar músicas ao álbum
    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    //Método para exibir as músicas e a soma das durações das músicas do álbum
    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"\nLista de músicas do álbum {NomeAlbum}:\n");

        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.NomeMusica}");
        }

        Console.WriteLine($"\nPara ouvir esse álbum inteiro você precisa de {DuracaoTotal}");
    }
}