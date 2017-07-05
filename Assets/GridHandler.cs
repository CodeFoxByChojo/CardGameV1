using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ArrayHandler : System.Object{

    public Board board;
    public string[,,] grid;
    public CardID CardID;
    public FieldProperties field;
    public GameObject[,] cards;

    public void generateArrays() {
        grid = new string[field._size, field._size, field._properties];
        cards = new GameObject[field._size, field._size];
    }

    public string GetName(int x, int y) {
        return grid[x, y, 0];
    }

    public void SetName(int x, int y) {
        grid[x, y, 0] = "Kachel (" + x + "," + y + ")";
    }

    //States: 0 = empty; 1 = card
    public int GetState(int x, int y) {
        int result;
        int.TryParse(grid[x, y, 1], out result);
        return result;
    }

    public void SetState(int x, int y, int state) {
        grid[x, y, 1] = state.ToString();
    }

    //Teams: 0 = empty; 1 = blue; 2 = red
    public int GetTeam(int x, int y) {
        int result;
        int.TryParse(grid[x, y, 2], out result);
        return result;
        }

    public void SetTeam(int x, int y, int team) {
        grid[x, y, 2] = team.ToString();
    }


    public int GetCardID(int x, int y) {
        int result;
        int.TryParse(grid[x, y, 3], out result);
        return result;

    }

    public void SetCardID(int x, int y, int cardID) {
        grid[x, y, 3] = cardID.ToString();
    }


    public string GetSpecial(int x, int y) {
        return grid[x, y, 4];
    }

    public void SetSpecial(int x, int y, int special) {
        grid[x, y, 4] = special.ToString();
    }
}