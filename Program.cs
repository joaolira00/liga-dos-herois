using Classes.Arena;
using Classes.Herois;
using Classes.Viloes;

class Program
{
	static void Main()
	{
		Heroi Nightwing = new (_Nome: "Asa Noturna", _Poder: "Bastões Elétricos", _Nivel: 30, _TituloDeHeroi: "O Protetor de Blüdhaven");
        Heroi Batman = new (_Nome: "Batman", _Poder: "Chamar Batwing", _Nivel: 30, _TituloDeHeroi: "O Cavaleiro das Trevas");

        Vilao Espantalho = new(_Nome: "Espantalho", _Poder: "Toxina do Medo", _Nivel:31, _TituloDeVilao: "O Mestre do Medo");
        Vilao Coringa = new(_Nome: "Coringa", _Poder: "Gás do Riso", _Nivel:15, _TituloDeVilao: "O Palhaço do Crime");

        Batalha ArenaDeBatalha = new (_HeroiCompetidor:Nightwing, _VilaoCompetidor: Espantalho);
        Batalha ArenaDeBatalha2 = new (_HeroiCompetidor:Batman, _VilaoCompetidor: Coringa);

        Console.WriteLine(ArenaDeBatalha.IniciarEmbate());

        Console.WriteLine("====================================================\n");

        Console.WriteLine(ArenaDeBatalha2.IniciarEmbate());
	}
}

