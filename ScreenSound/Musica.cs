class Musica
{
    // Constructor
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        NomeMusica = nome;
    }

    // Declaração de atributos e propriedades da classe
    public string NomeMusica { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }

    // Atribuição feita através de expressões Lambda
    public string DescricaoResumida => $"A música {NomeMusica} pertence à banda {Artista}";

    // Método que exibe a ficha técnica da música
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"\nNome: {NomeMusica}");
        Console.WriteLine($"Artista: {Artista.NomeBanda}");
        Console.WriteLine($"Duração: {Duracao}");

        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }

}

