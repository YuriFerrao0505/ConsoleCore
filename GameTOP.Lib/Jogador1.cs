using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador1 : iJogador
    {
        public readonly string _Nome;
        public Jogador1(string nome = "Ronaldo")
        {
            _Nome = nome;
        }

        //Chutar
        public string Chuta()
        {
            return $"{_Nome} está chutando\n";
        }

        //Correr
        public string Corre()
        {
            return $"{_Nome} está correndo\n";
        }

        //Passar
        public string Passe()
        {
            return $"{_Nome} está passando\n";
        }
    }
}