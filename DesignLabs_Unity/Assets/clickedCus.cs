using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickedCus : MonoBehaviour, IInputClickHandler{


    public void OnInputClicked(InputClickedEventData eventData)
    {
        GameObject obj = eventData.selectedObject;

        transform.position = new Vector3(transform.position.x - 0.01f, transform.position.y - 0.01f, transform.position.z - 0.1f);

        Destroy(obj);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
