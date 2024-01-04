namespace DesafioPOO.Models
{    
    public class Iphone: Smartphone
    {
       public Iphone (string numero,string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
       {
        
       }
       List<string> AppsInstaladosIphone = new List<string>();
       public override void InstalarAplicativo(string nomeApp)
        {
            if (!AppsInstaladosIphone.Contains(nomeApp))
            {
                Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\" no Iphone.");
                AppsInstaladosIphone.Add(nomeApp);
            }
            else
            {
                Console.WriteLine("Aplicativo já instalado.");  
            }
        }
        public override void DesinstalarAplicativo(string nomeApp)
        {
            if (AppsInstaladosIphone.Contains(nomeApp))
            {
                Console.WriteLine($"Desinstalando o aplicativo \"{nomeApp}\" no Iphone.");
                AppsInstaladosIphone.Remove(nomeApp);
            }
            else
            {
                Console.WriteLine($"Não foi possível desistalar. O aplicativo \"{nomeApp}\" não está instalado.");
            }
        }
        public override void ListarAppsInstalados()
        {
            if (AppsInstaladosIphone.Any())
            {   
                Console.WriteLine("Apps Instalados: ");
                foreach(var item in AppsInstaladosIphone)
                {
                    Console.WriteLine($"\t{item}");
                }
            }
            else
            {
                Console.WriteLine("Nenhum App Instalado no Iphone.");
            }
        }
    }
}