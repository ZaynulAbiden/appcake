using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonDataContainer : MonoBehaviour
{

    public static JsonDataContainer instance;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this.gameObject);
    }

    public List<Code> Codes = new List<Code>();


    public List<Cheat> Cheats = new List<Cheat>();


    public List<Guide> Guides = new List<Guide>();


    public List<Hero> Heroes = new List<Hero>();


    public List<Item> Items = new List<Item>();


    public List<Mod> Mods = new List<Mod>();


    public List<ReservoirRaid> ReservoirRaids = new List<ReservoirRaid>();


    public List<Tip> Tips = new List<Tip>();



    public void PraseCodeData(string jsonString)
    {
        JsonDataClass jsonDataClass = JsonConvert.DeserializeObject<JsonDataClass>(jsonString);


        Codes = jsonDataClass.Codes;

    }

    public void PraseCheatsData(string jsonString)
    {
        JsonDataClass jsonDataClass = JsonConvert.DeserializeObject<JsonDataClass>(jsonString);


        Cheats = jsonDataClass.Cheats;

    }

    public void PraseGuideData(string jsonString)
    {
        JsonDataClass jsonDataClass = JsonConvert.DeserializeObject<JsonDataClass>(jsonString);


        Guides = jsonDataClass.Guides;
    }

    public void PraseHeroesData(string jsonString)
    {
        JsonDataClass jsonDataClass = JsonConvert.DeserializeObject<JsonDataClass>(jsonString);


        Heroes = jsonDataClass.Heroes;
    }

    public void PraseItemData(string jsonString)
    {
        JsonDataClass jsonDataClass = JsonConvert.DeserializeObject<JsonDataClass>(jsonString);


        Items = jsonDataClass.Items;
    }

    public void PraseModsData(string jsonString)
    {
        JsonDataClass jsonDataClass = JsonConvert.DeserializeObject<JsonDataClass>(jsonString);


        Mods = jsonDataClass.Mods;
    }

    public void PraseReservoirRaidsData(string jsonString)
    {
        JsonDataClass jsonDataClass = JsonConvert.DeserializeObject<JsonDataClass>(jsonString);


        ReservoirRaids = jsonDataClass.ReservoirRaids;
    }

    public void PraseTipsData(string jsonString)
    {
        JsonDataClass jsonDataClass = JsonConvert.DeserializeObject<JsonDataClass>(jsonString);


        Tips = jsonDataClass.Tips;
    }
}
