using UnityEngine;
using System.Collections;

public class Swing : MonoBehaviour {
    private int frame = 0;
    private float dist = 0.5f;
	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update() {
        frame += 1;
        float distPerFrame = dist / 20;
        transform.position += new Vector3(distPerFrame, 0);
        if (frame == 21)
        {
            Object.Destroy(this.gameObject);
        }
	}
}
