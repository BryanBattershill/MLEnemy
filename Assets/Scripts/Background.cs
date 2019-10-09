using UnityEngine;
using System.Collections;

public class Background : MonoBehaviour {
    void resizeBG()
    {
        Vector3 scale = new Vector3(Camera.main.aspect*2, 2, 1);
        transform.localScale = scale;
    }
	// Use this for initialization
	void Start () {
        resizeBG();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
