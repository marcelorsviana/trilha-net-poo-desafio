namespace DesafioPOO.Models
{
    // TODO:FINALIZADO - Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : 
            base(numero, modelo, imei, memoria)
        {
            
        }
        // TODO: FINALIZADO - Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"{nomeApp} instalado com sucesso no Nokia!");
        }
    }
}