namespace GameAMS
{
    public class Jogador2 : IJogador
    {
        public string Chutar()
        {
            return $"Pedro esta chutando a bola!";
        }

        public string Correr()
        {
            return $"Pedro esta correndo!";
        }

        public string Passar()
        {
            return $"Pedro esta passando a bola!";
        }
    }
}
