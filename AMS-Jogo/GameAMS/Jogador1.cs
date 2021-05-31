namespace GameAMS
{
    public class Jogador1 : IJogador
    {
        public readonly string Nome;

        public Jogador1(string nome  = "Eduardo")
        {
            Nome =  nome;
        }

        public string Chutar()
        {
            return $"{Nome} esta chutando a bola!";
        }

        public string Correr()
        {
            return $"{Nome} esta correndo!";
        }

        public string Passar()
        {
            return $"{Nome} esta passando a bola!";
        }
    }
}