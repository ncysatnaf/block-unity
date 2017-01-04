using UnityEngine;
using System.Collections;

public class interactionControl : MonoBehaviour {

    private Animator anim;

    void OnTriggerEnter(Collider obj)
    {
        Debug.Log("onTrigger");
        anim.SetBool("isUp", true);
    }

    void OnTriggerExit(Collider obj)
    {
        Debug.Log("outTrigger");
        anim.SetBool("isUp", false);
    }

	// Use this for initialization
	void Start () {
        anim = this.transform.parent.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
