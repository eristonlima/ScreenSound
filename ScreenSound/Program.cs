Episodio ep1 = new(1, "Técnicas de Facilitação", 45);
ep1.AdicionarConvidados("Maria");
ep1.AdicionarConvidados("Marcelo");

Episodio ep2 = new(2, "Técnicas de Aprendizado", 67);
ep2.AdicionarConvidados("Fernando");
ep2.AdicionarConvidados("Marcelo");
ep2.AdicionarConvidados("Flavia");

Podcast podcast = new("Podcast Especial", "Daniel");
podcast.AdicionarEpisodios(ep1);
podcast.AdicionarEpisodios(ep2);
podcast.ExibirDetalhes();