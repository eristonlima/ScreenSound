class Banda
{
    private List<Album> albuns = new List<Album>();
    public string NomeBanda { get; set; }

    // Método para adicionar albúns em uma lista de albuns
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
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
        }
    }
}