using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class API
{
    public static T[] getJsonArray<T>(string json)
    {
        string newJson = "{ \"array\": " + json + "}";
        SerializeMe<T> wrapper = JsonUtility.FromJson<SerializeMe<T>>(newJson);
        return wrapper.array;
    }

    /// <summary>
    ///  Ensures each object shows up in the inspector. *Needs to be wrapped*
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [System.Serializable]
    private class SerializeMe<T>
    {
        public T[] array;
    }
}

/*
Used json2csharp website to convert restcountries.eu/rest/v2/all to csharp classes
*/


[System.Serializable]
public class Currency
{
    public string code { get; set; }
    public string name { get; set; }
    public string symbol { get; set; }
}

[System.Serializable]
public class Language
{
    public string iso639_1 { get; set; }
    public string iso639_2 { get; set; }
    public string name { get; set; }
    public string nativeName { get; set; }
}

[System.Serializable]
public class Translations
{
    public string de { get; set; }
    public string es { get; set; }
    public string fr { get; set; }
    public string ja { get; set; }
    public string it { get; set; }
    public string br { get; set; }
    public string pt { get; set; }
    public string nl { get; set; }
    public string hr { get; set; }
    public string fa { get; set; }
}

[System.Serializable]
public class RootObject
{
    public string name { get; set; }
    public List<string> topLevelDomain { get; set; }
    public string alpha2Code { get; set; }
    public string alpha3Code { get; set; }
    public List<string> callingCodes { get; set; }
    public string capital { get; set; }
    public List<object> altSpellings { get; set; }
    public string region { get; set; }
    public string subregion { get; set; }
    public int population { get; set; }
    public List<object> latlng { get; set; }
    public string demonym { get; set; }
    public double? area { get; set; }
    public double? gini { get; set; }
    public List<string> timezones { get; set; }
    public List<object> borders { get; set; }
    public string nativeName { get; set; }
    public string numericCode { get; set; }
    public List<Currency> currencies { get; set; }
    public List<Language> languages { get; set; }
    public Translations translations { get; set; }
    public string flag { get; set; }
    public List<object> regionalBlocs { get; set; }
    public string cioc { get; set; }
}