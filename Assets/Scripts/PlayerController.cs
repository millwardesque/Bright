using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    public Bright bright;
    public float lightSpeed = 1f;
    public GameObject centreCamera;

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update() {
        if (Input.GetButtonDown("Fire1")) {
            // @TODO Raycast from camera to find intersection point, then change Bright velocity to track to that point.
            bright.GetComponent<Rigidbody>().velocity = lightSpeed * centreCamera.transform.forward;
        }
    }
}
