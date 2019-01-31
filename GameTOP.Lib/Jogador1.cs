using GameTop.Interface;

namespace GameTOP.Lib
{
   public class Jogador1 : iJogador
    {
        public readonly string _Nome;

        public Jogador1(string nome)
        {
            _Nome = nome;
        }

        //Chura
        public string Chuta()
        {
            return $"{_Nome} está chutando \n";
        }
        //Corre
        public string Corre()
        {
            return $"{_Nome} está Correndo \n";
        }
        //Passe
        public string Passe()
        {
            return $"{_Nome} está passando \n";
        }
    }
}