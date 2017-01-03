using UnityEngine;
using System.Collections;

public class MoveGuy : MonoBehaviour {

    public float mult = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float vecX = this.transform.position.x;
        float vecZ = this.transform.position.z;
        this.transform.position = new Vector3(vecX += Input.GetAxis("Horizontal")*mult, 1, vecZ += Input.GetAxis("Vertical")*mult);
	}
}
