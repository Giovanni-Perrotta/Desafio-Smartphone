namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public Smartphone()
        {
            
        }
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            // TODO: Passar os parâmetros do construtor para as propriedades
            //Implementado
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        //Implementado
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}