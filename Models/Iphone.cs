namespace DesafioPOO.Models
{

    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override void InstalarAplicativo(string nomeApp)
        {
             System.Console.WriteLine($"Instalando app {nomeApp} no Iphone");;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}