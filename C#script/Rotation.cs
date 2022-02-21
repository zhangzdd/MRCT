using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float speedX = 0;
    public float speedY = 0;
    public float speedZ = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(Vector3.up * speedX);
        this.transform.Rotate(Vector3.right * speedY);
        this.transform.Rotate(Vector3.back * speedZ);
    }
}
