using UnityEngine;
using System.Collections;

public class Unit : MonoBehaviour {

    public int tileX;
    public int tiley;

    public GameObject wo;
    private World world;

    // need to change the script so that the unit can move its self.
    // also need to add path finding.

    // get position of unit
    // implement getting clickable tile position.
    // implement path finding.
    
    
	// Use this for initialization
	void Start () {
        world = (World)wo.GetComponent<World>();
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    // change colour on mouse over
    void OnMouseEnter()
    {
        GetComponent<Renderer>().material.color -= new Color(0.5F, 0, 0);  
    }

    // change colour on mouse out
    void OnMouseExit()
    {
        GetComponent<Renderer>().material.color += new Color(0.5F, 0, 0);
    }

    void OnMouseDown()
    {
        Debug.Log("Click!");
        world.go = this.gameObject;
    }
}
