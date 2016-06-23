using UnityEngine;
using System.Collections;

public class Bright : MonoBehaviour {
    public Light prefabLight;

    public void CreateLight() {
        Light newLight = Instantiate<Light>(prefabLight);
        newLight.transform.position = transform.position;
    } 
}
