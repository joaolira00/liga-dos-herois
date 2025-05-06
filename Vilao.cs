using Classes.Superhumanos;

namespace Classes.Viloes
{
    public class Vilao: Superhumano
    {
        public string TituloDeVilao;

        public Vilao(string _Nome, string _Poder, int _Nivel, string _TituloDeVilao) : base(_Nome, _Poder, _Nivel)
        {
            TituloDeVilao = _TituloDeVilao;
        }

        public override string Usar_Poder()
        {
            return $"Após um breve momento de preparação, {Nome} usa seu poder {Poder} para acabar com os planos de seu oponente!\n";
        }
    }
}