// See https://aka.ms/new-console-template for more information
using HomeWork_Adapter_Pattern;

//#region Variant 1
//var url = new List<IApiUrl>
//{
//    new OmbpApiAdapter(new OmbApi()),
//    new OpenWeatherAdapter(new OpenWeather()),
//    new DeezerAdapter(new Dezer())
//};


//foreach (var item in url)
//{
//    item.Url();
//}
//#endregion

#region Variant 2
Console.WriteLine("Введите название сайта: OmbpApi, OpenWeather, Deezer");
string name = Console.ReadLine();

switch (name)
{
    case "OmbpApi":
        var urlOmbp = new OmbpApiAdapter(new OmbApi());
        urlOmbp.Url();
        break;
    case "OpenWeather":
        var urlOpenWeather = new OpenWeatherAdapter(new OpenWeather());
        urlOpenWeather.Url();
        break;
    case "Deezer":
        var urlDeezer = new DeezerAdapter(new Dezer());
        urlDeezer.Url();
        break;
    default:
        Console.WriteLine("Такого сайта нет в списке");
        break;
}
#endregion
