class Banda
{
    // Constructor
    public Banda(string nome)
    {
        NomeBanda = nome;
    }
    // Declaração de atributos e propriedades da classe
    private List<Album> albuns = new List<Album>();
    public string NomeBanda { get; }

    // Método para adicionar albuns em uma lista de albuns da banda
    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }

    // Método para exibir a discografia de uma banda
    public void ExibirDiscografia()
    {
        Console.WriteLine($"\nDiscografia da banda {NomeBanda}");

        foreach(Album album in albuns)
        {
            Console.WriteLine($"Álbum: {album.NomeAlbum} ({album.DuracaoTotal})");
        }
    }
}