using UnityEngine;

[System.Serializable]
public class FieldProperties : System.Object {
    public int _size;
    public int _properties = 5;
}

public enum CardID { Startpoint, Pointcard, Blankcard,
    Doublecard, Blockcard, Deletecard,
    Burncard, Infernocard, Changecard,
    Cancercard, HotPotatoe, Nukecard,
    Vortexcard, Anchorcard, Sufflecard }

public class Materials {
    //Material transparent = new Material();
}