using Classes.Superhumanos;

namespace Classes.Herois
{
    public class Heroi: Superhumano
    {
        public string TituloDeHeroi;

        public Heroi(string _Nome, string _Poder, int _Nivel, string _TituloDeHeroi) : base(_Nome, _Poder, _Nivel)
        {
            TituloDeHeroi = _TituloDeHeroi;
        }

        public override string Usar_Poder()
        {
            return $"Após um breve momento de preparação, {Nome} usa seu poder {Poder} para derrotar seu oponente maligno! \n";
        }
    }
}