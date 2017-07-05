using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MySqlLite;

public class Board : MonoBehaviour {

    //Pos1 = Koord x;
    //Pos2 = Koord y;
    //Pos3 = 0 Name; 1 State; 2 Team; 3 CardID; 4 Special 

    public ArrayHandler ArrayHandler;
    public FieldProperties field;

    void Start() {
        debugfieldsize();
        print("size: " + field._size + ", x: " + field._size + ", y:" + field._size + " properties: " + field._properties);
        ArrayHandler.generateArrays();

        for (int x = 0; x < field._size; x++) {
            Debug.Log("Vorschleife 1");
            for (int y = 0; y < field._size; y++) {
                ArrayHandler.SetName(x, y);
                Debug.Log("Vorschleife 2");
                GameObject tile = GameObject.CreatePrimitive(PrimitiveType.Quad);
                tile.transform.position = new Vector2(x + 0.5f, y + 0.5f);
                tile.transform.parent = this.transform;
                tile.name = string.Format("Kachel ({0},{1})", x + 1, y + 1);
                ArrayHandler.cards[x, y] = tile;
                //tile.GetComponent<Light>();


                if (x == (field._size / 2) && y == (field._size / 2)) {
                    tile.GetComponent<Renderer>().material.color = Color.red;
                    ArrayHandler.SetCardID(x, y, -1);
                    Debug.Log("Startpunkt gesetzt auf:" + x + "," + y);
                } else {
                    tile.GetComponent<Renderer>().material.color = Color.green;
                    ArrayHandler.SetCardID(x, y, 0);
                    ArrayHandler.SetState(x, y, 0);
                    ArrayHandler.SetTeam(x, y, -1);
                }
            }
        }

        float camsize = field._size / 2 + 0.5f;
        Camera.main.transform.position = new Vector3(camsize, camsize, -10);
        Camera.main.orthographicSize = camsize;
    }

    void Update() {
        Color myColor;

        float turnTime = 5f;
        turnTime -= Time.deltaTime;

        if (turnTime <= 0) {
            int x = Random.Range(0, field._size);
            int y = Random.Range(0, field._size);
            if (x == (field._size / 2) && y == (field._size / 2)) {
                return;
            } else {
                ArrayHandler.cards[x, y].GetComponent<Renderer>().material.color = Color.magenta;
                turnTime = 0.01f;
                print("Color changed");
            }
        }
    }

    void debugfieldsize() {
        int debugsize = field._size;
        if (debugsize <= 10) {
            field._size = 11;
        }else if (debugsize % 2 != 1) {
            field._size += 1;
        }
    }
}
