using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colour : MonoBehaviour {

    public Color color;
    public SpriteRenderer rend;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.D))
        {
            rend.color = new Color(0f, 0f, 1f); //gör så att när du trycker ner D så blir skeppets sidodelar BLÅa
        }
        if (Input.GetKey(KeyCode.A))
        {
            rend.color = new Color(0f, 1f, 0f); //gör så att när du trycker ner A så blir skeppets sidodelar GRÖNa
        }




    }
}
