// See https://aka.ms/new-console-template for more information
using HomeWork_Adapter_Pattern;

var url = new List<IApiUrl> 
{ 
    new OmbpApiAdapter(new OmbApi()),
    new OpenWeatherAdapter(new OpenWeather()),
    new DeezerAdapter(new Dezer())
};


foreach (var item in url)
{
    item.Url();
}
