using UnityEngine;
using System.Collections;

public class ClickableTile : MonoBehaviour {

    public int tileX;
    public int tileY;
    public World map;

    void OnMouseUp()
    {
        Debug.Log("Click!" + " " + tileX + " " + tileY);

        map.go.transform.position = new Vector3(tileX, tileY, -0.75f);

        //map.MoveSelectedUnitTo(tileX, tileY);
    }
}
