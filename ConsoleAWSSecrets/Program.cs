
using ConsoleAWSSecrets.Helpers;
using ConsoleAWSSecrets.Models;
using Newtonsoft.Json;

Console.WriteLine("----------------- SECRETS---------");
string mySecret = await HelperSecretManager.GetSecretAsync();
Console.WriteLine(mySecret);

KeysModel model = JsonConvert.DeserializeObject<KeysModel>(mySecret);
Console.WriteLine(model);
Console.WriteLine(model.Mysql);

Console.WriteLine("----------------- FIN SECRETS---------");
