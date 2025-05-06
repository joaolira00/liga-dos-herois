namespace Classes.Superhumanos
{
    public abstract class Superhumano
    {
        public string? Nome { get; set; }
        public string? Poder { get; set; }
        public int Nivel { get; set; }

        public Superhumano(string _Nome, string _Poder, int _Nivel)
        {
            Nome = _Nome;
            Poder = _Poder;
            Nivel = _Nivel;
        }

        public string Apresentar()
        {
            return $"Eu sou {Nome}! Meu poder é {Poder} e estou no nível {Nivel}!!!\n";
        }

        public abstract string Usar_Poder();
    }
}

