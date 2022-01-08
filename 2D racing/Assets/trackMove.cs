using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackMove : MonoBehaviour
{
    public float speed;
    Vector2 offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        offset = new Vector2(0, Time.fixedDeltaTime * speed);
        GetComponent<Renderer>().material.mainTextureOffset += offset;
    }
}
