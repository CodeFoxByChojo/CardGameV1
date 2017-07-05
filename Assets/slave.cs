using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slave {
    public string generatefolderpath() {
        string _databaseurl = "URI=file:" + Application.dataPath + "/gamedata.s3db";

        return _databaseurl;
    }
}
