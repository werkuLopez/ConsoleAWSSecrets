
using ConsoleAWSSecrets.Helpers;
using ConsoleAWSSecrets.Models;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

Console.WriteLine("----------------- SECRETS---------");
Console.WriteLine(HelperSecretManager.GetEnvironmentVariable("us-east-1"));
/*
Console.WriteLine("");
string mySecret = await HelperSecretManager.GetSecretAsync();
Console.WriteLine(mySecret);

KeysModel model = JsonConvert.DeserializeObject<KeysModel>(mySecret);
//Console.WriteLine(model);
Console.WriteLine(model.Mysql);


// almacenamos el objeto keysmodel dentro de DY

var proveedor =
    new ServiceCollection()
    .AddSingleton<Test>()
    .AddSingleton<KeysModel>(x => model)
    .BuildServiceProvider();

Console.WriteLine("");
// en cualquier clase/injection podemos recuperar las keys
var service = proveedor.GetService<KeysModel>();
string conn = service.Mysql;
Console.WriteLine(conn);

var test = proveedor.GetService<Test>();
Console.WriteLine("API: " + test.GetValue());
Console.WriteLine("");

Console.WriteLine(HelperSecretManager.GetEnvironmentVariable("us-east-1"));*/

Console.WriteLine("----------------- FIN SECRETS---------");
