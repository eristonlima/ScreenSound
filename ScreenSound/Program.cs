Banda queen = new(); ;
queen.NomeBanda = "Queen";

Album albumDoQueen = new Album();

albumDoQueen.Nome = "A night at the opera";

Musica musica1 = new Musica(queen);
musica1.Nome = "Love Of My Life";
musica1.Duracao = 213;

// Outra forma de representar, criando um atributo novo de uma determinada classe e atribuindo valores
Musica musica2 = new Musica(queen)
{
    Nome = "Bohemian Rhapsody",
    Duracao = 354
};

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);

albumDoQueen.ExibirMusicasDoAlbum();

queen.AdicionarAlbum(albumDoQueen);
queen.ExibirDiscografia();
