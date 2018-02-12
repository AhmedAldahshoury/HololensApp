using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class welcome : MonoBehaviour {


    public float Showtime = 0f;
    public int counter = 5;
    public GameObject menu;
    // Use this for initialization
    void Start () {
        menu.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {


        if (counter > 0)
        {
            Showtime = 12f;
            counter = counter - 1;
        }

        if (Showtime > 0f)
        {
            Showtime = Showtime - (Time.deltaTime);
            //Do your thing for 5 seconds.... change colour etc.  
            transform.Rotate(0, 0, 120 * Time.deltaTime);

        }
        else
        {
            menu.SetActive(true);
            Destroy(this.gameObject);
        }
    }
   
 
}
