using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCustomComponent : MonoBehaviour {

    public MonoBehaviour Handler = null;
    
	// Use this for initialization
	void Start () {
        
        Handler.Invoke("OnSaveFunc", 0.0f);
	}
	
}
