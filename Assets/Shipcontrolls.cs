using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shipcontrolls : MonoBehaviour
{
    public float Hastighetframmåt = 10;
    public float Svänghastighet = 180;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(0, -Hastighetframmåt * Time.deltaTime, 0, Space.Self); //gör så att du åker konstant frammåt

        if (Input.GetKey(KeyCode.S))
            transform.Translate(0, (Hastighetframmåt / 2) * Time.deltaTime, 0, Space.Self); //gör så att du åker i hälften av hastigheten frammåt

        if (Input.GetKey(KeyCode.D))
            transform.Rotate(0, 0, -Svänghastighet / 2 * Time.deltaTime); //gör så att skeppet svänger vänster lite långsammare än åt höger //if (Input.GetKey(KeyCode.D)) transform.Rotate(0, 0, Svänghastighet-60 * Time.deltaTime); ha inte såhär det händer något konstigt

        if (Input.GetKey(KeyCode.A))
            transform.Rotate(0, 0, Svänghastighet * Time.deltaTime);  //gör så att skepet svänger höger 

        if (transform.position.y >= 22.5f)
        {
            transform.position = new Vector3(transform.position.x, -22f); // gör så att om du åker utanför skärmen så warpar du till andra sidan på Y axeln men X axeln är densamma
        }

        if (transform.position.y <= -22.1f)
        {
            transform.position = new Vector3(transform.position.x, 22.4f); // gör så att om du åker utanför skärmen så warpar du till andra sidan på Y axeln men X axeln är densamma
        }

        if (transform.position.x >= 38.5f)
        {
            transform.position = new Vector3(-38.4f, transform.position.y); // gör så att om du åker utanför skärmen så warpar du till andra sidan på X axeln men Y axeln är densamma
        }

        if (transform.position.x <= -38.5f)
        {
            transform.position = new Vector3(38.4f, transform.position.y); // gör så att om du åker utanför skärmen så warpar du till andra sidan på X axeln men Y axeln är densamma
        }


    }
}
