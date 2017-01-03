using UnityEngine;
using System.Collections;

public class MoveGuy : MonoBehaviour {

    public float mult = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float vecY = this.transform.position.y;
        float vecX = this.transform.position.x;
        float vecZ = this.transform.position.z;
        this.transform.position = new Vector3(vecX += Input.GetAxis("Horizontal")*mult, vecY, vecZ += Input.GetAxis("Vertical")*mult);

        if(Input.GetButton("Jump")){
            this.transform.Translate(0, mult, 0);
        }
	}
}
