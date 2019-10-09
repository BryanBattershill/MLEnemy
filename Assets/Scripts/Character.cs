using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour{
    public float SPEED = 1f;
    protected Animator anim;
    public GameObject swingObj;
    public void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void move(float x, float y)
    {
        float actualSpeed = 1 / 10f * SPEED;
        float factor = 1f;
        if (Mathf.Abs(x) == 1 && Mathf.Abs(y) == 1)
        {
            factor = Mathf.Sqrt(2) / 2;
        }
        transform.position += new Vector3(x*actualSpeed*factor,y*actualSpeed*factor);
    }

}
