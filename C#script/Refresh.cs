using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Refresh : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    [SerializeField]
    private Transform standardposition;

    public void Refreshposition()
    {
        Vector3 P;
        P.x = standardposition.position.x;
        P.y = standardposition.position.y - 0.1f;
        P.z = standardposition.position.z + 1f;
        this.transform.position = P;
        this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
    }
}
