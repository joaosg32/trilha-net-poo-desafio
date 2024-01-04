using DesafioPOO.Models;

// Testes com as classes Nokia e Iphone.
Console.Clear();

// Nokia.
Nokia n1 = new Nokia("99888-3264", "n1Model", "33333", 128);
n1.InstalarAplicativo("WhatsApp");
n1.Ligar();
n1.ReceberLigacao();
n1.InstalarAplicativo("Telegram");
n1.ListarAppsInstalados();
n1.DesinstalarAplicativo("Facebook");
n1.ListarAppsInstalados();
n1.DesinstalarAplicativo("Telegram");
n1.ListarAppsInstalados();
n1.DesinstalarAplicativo("WhatsApp");
n1.ListarAppsInstalados();

Console.WriteLine("===================================================");
// Iphone.
Iphone i1 = new Iphone("99888-3333", "m1", "22222", 128);
i1.InstalarAplicativo("WhatsApp");
i1.Ligar();
i1.ReceberLigacao();
i1.InstalarAplicativo("Telegram");
i1.ListarAppsInstalados();
i1.DesinstalarAplicativo("Facebook");
i1.ListarAppsInstalados();
i1.DesinstalarAplicativo("Telegram");
i1.ListarAppsInstalados();
i1.DesinstalarAplicativo("WhatsApp");
i1.ListarAppsInstalados();
