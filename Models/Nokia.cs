namespace DesafioPOO.Models
{
    public class Nokia: Smartphone
    {   
        public Nokia(string numero,string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            
        }
        List<string> AppsInstaladosNokia = new List<string>();
       public override void InstalarAplicativo(string nomeApp)
        {
            if (!AppsInstaladosNokia.Contains(nomeApp))
            {
                Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\" no Nokia.");
                AppsInstaladosNokia.Add(nomeApp);
            }
            else
            {
                Console.WriteLine("Aplicativo já instalado.");  
            }
        }
        public override void DesinstalarAplicativo(string nomeApp)
        {
            if (AppsInstaladosNokia.Contains(nomeApp))
            {
                Console.WriteLine($"Desinstalando o aplicativo \"{nomeApp}\" no Nokia.");
                AppsInstaladosNokia.Remove(nomeApp);
            }
            else
            {
                Console.WriteLine($"Não foi possível desistalar. O aplicativo \"{nomeApp}\" não está instalado.");
            }
        }
        public override void ListarAppsInstalados()
        {
            if (AppsInstaladosNokia.Any())
            {   
                Console.WriteLine("Apps Instalados: ");
                foreach(var item in AppsInstaladosNokia)
                {
                    Console.WriteLine($"\t{item}");
                }
            }
            else
            {
                Console.WriteLine("Nenhum App Instalado no Nokia.");
            }
        }
    }
}