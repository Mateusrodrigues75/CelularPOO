namespace CelularPOO.classes
{
    public class Celular
    {
        public string cor;
        public string modelo;
        public float tamanho;
        public bool ligado;

        public string Ligar()
        {
            return "Bem Vindo! \n - Inicializando o sistema...";
        }

        public string Desligar()
        {
            ligado = false;
            return "Desligando o dispositivo...";
        }

        public string Ligacao()
        {
            return "Ligando...";
        }

        public string EnviarMensagem()
        {
            return "Enviando...";
        }
    }
}