using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : iJogador
    {
        public string Chuta()
        {
            return "Pelé está chutando\n";
        }

        public string Corre()
        {
            return "Pelé está correndo\n";
        }

        public string Passe()
        {
            return "Pelé está passando\n";
        }
    }
}