using Classes.Herois;
using Classes.Viloes;

namespace Classes.Arena
{
    public class Batalha
    {
        public Heroi? HeroiCompetidor;
        public Vilao? VilaoCompetidor;

        public Batalha(Heroi _HeroiCompetidor, Vilao _VilaoCompetidor)
        {
            HeroiCompetidor = _HeroiCompetidor;
            VilaoCompetidor = _VilaoCompetidor;
        }

        public string IniciarEmbate()
        {
            Console.WriteLine(HeroiCompetidor?.Apresentar());
            Console.WriteLine(VilaoCompetidor?.Apresentar());

            Console.WriteLine(HeroiCompetidor?.Usar_Poder());
            Console.WriteLine(VilaoCompetidor?.Usar_Poder());

            if (HeroiCompetidor?.Nivel > VilaoCompetidor?.Nivel)
            {
                return $"{HeroiCompetidor.Nome}, {HeroiCompetidor.TituloDeHeroi}, saiu com a vitória sobre a vilania!\n";
            }
            else if (VilaoCompetidor?.Nivel > HeroiCompetidor?.Nivel)
            {
                return $"{VilaoCompetidor.Nome}, {VilaoCompetidor.TituloDeVilao}, saiu com a vitória sobre a liga dos herois...\n";
            }
            else
            {
                return $"A luta acabou em um empate, ninguém saiu com a vitória.\n";
            }
        }
    }
}