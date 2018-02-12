
using HUX.Dialogs;

using HUX.Interaction;

using HUX.Receivers;

using System.Collections;

using UnityEngine;

public class customizedButton : HUX.Receivers.InteractionReceiver{


    private GameObject x;

   

    // Use this for initialization
    void Start () {

        Debug.Log("wfwefwef");
    }




    // Update is called once per frame
    void Update () {
		
	}


    protected override void OnTapped(GameObject obj, InteractionManager.InteractionEventArgs eventArgs)
    {
        Debug.Log("lollllll");

        Destroy(this.gameObject);
        Destroy(obj);
        Destroy(obj.gameObject);


    }


}



