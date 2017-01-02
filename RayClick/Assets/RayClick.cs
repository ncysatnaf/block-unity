using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RayClick : MonoBehaviour 
{

    private Camera Cam = null;

    void Awake() 
    {
        Cam = GetComponent<Camera>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Ray R = Cam.ScreenPointToRay(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0f));

            RaycastHit Hit;


            if(Physics.Raycast(R, out Hit, Mathf.Infinity))
            {
                Debug.Log(Hit.collider.gameObject.name);
            }
        }
	}
}
