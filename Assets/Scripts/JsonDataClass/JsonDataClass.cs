using Newtonsoft.Json;
using System;
using System.Collections.Generic;


public class JsonDataClass
{

    [JsonProperty("8iia_list")]
    public List<Code> Codes = new List<Code>();

    [JsonProperty("y28_list")]
    public List<Cheat> Cheats = new List<Cheat>();

    [JsonProperty("ay5t03_list")]
    public List<Guide> Guides = new List<Guide>();

    [JsonProperty("l3b3c_list")]
    public List<Hero> Heroes = new List<Hero>();

    [JsonProperty("rzdv_list")]
    public List<Item> Items = new List<Item>();

    [JsonProperty("iax_list")]
    public List<Mod> Mods = new List<Mod>();

    [JsonProperty("3kk9nj_list")]
    public List<ReservoirRaid> ReservoirRaids = new List<ReservoirRaid>();

    [JsonProperty("8qfiv_list")]
    public List<Tip> Tips = new List<Tip>();






}

// Code Data Class 
[Serializable]
public class Code
{
    [JsonProperty("8iiad4")]
    public string CodeDescription;

    [JsonProperty("8iiai1")]
    public string CodeValue;

    [JsonProperty("new")]
    public bool IsNew;

    public bool isFavorite;
}

// Cheats Data Class
[Serializable]
public class Cheat
{
    [JsonProperty("y28i1")]
    public string CheatDescription;

    [JsonProperty("8iiai1")]
    public string CheatValue;

    [JsonProperty("y28d4")]
    public string CheatAbility;


    [JsonProperty("new")]
    public bool IsNew;

    public bool isFavorite;
}

// Guides Data Class

[Serializable]
public class Guide
{
    [JsonProperty("ay5t03d4")]
    public string GuideName;

    [JsonProperty("ay5t03i1")]
    public string GuideDescription;

    [JsonProperty("ay5t03f2")]
    public string GuideImagePath;

    [JsonProperty("new")]
    public bool IsNew;

    public bool isFavorite;
}

// Heros Data Class

[Serializable]
public class Hero
{
    [JsonProperty("l3b3cd4")]
    public string HeroName;

    [JsonProperty("l3b3ci1")]
    public string HeroDescription;

    [JsonProperty("l3b3cf2")]
    public string HeroImagePath;

    [JsonProperty("new")]
    public bool IsNew;

    public bool isFavorite;
}

// Items

[Serializable]
public class Item
{
    [JsonProperty("rzdvd4")]
    public string ItemName;

    [JsonProperty("rzdvf2")]
    public string ItemImagePath;

    [JsonProperty("new")]
    public string IsNew;

    public bool isFavorite;
}

// Modes
[Serializable]
public class Mod
{
    [JsonProperty("iaxd4")]
    public string ModName;

    [JsonProperty("iaxi1")]
    public string ModDescription;

    [JsonProperty("iaxf2")]
    public string ModImagePath;

    [JsonProperty("new")]
    public bool IsNew;

    public bool isFavorite;
}

//Reservoir Raid
[Serializable]
public class ReservoirRaid
{
    [JsonProperty("3kk9njd4")]
    public string ReservoirRaidName;

    [JsonProperty("3kk9nji1")]
    public string ReservoirRaidDescription;

    [JsonProperty("3kk9njf2")]
    public string ReservoirRaidImagePath;

    [JsonProperty("new")]
    public bool IsNew;

    public bool isFavorite;
}

// Tips

[Serializable]
public class Tip
{
    [JsonProperty("8qfivd4")]
    public string TipName;

    [JsonProperty("8qfivi1")]
    public string TipDescription;

    [JsonProperty("8qfivf2")]
    public string TipImagePath;

    [JsonProperty("new")]
    public bool IsNew;

    public bool isFavorite;
}
