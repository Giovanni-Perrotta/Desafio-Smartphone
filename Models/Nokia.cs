namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    //Implementado
    public class Nokia : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        //Implementado
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Aplicativo {nomeApp} instalado no seu Nokia!");
        }
    }
}