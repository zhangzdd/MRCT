using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dontdestroyonload : MonoBehaviour
{
    public static Dontdestroyonload Instance { get; private set; }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Awake()
    {
        if (Instance == null)
        {
            //Debug.Log("1");
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            //Debug.Log("2");
            //Destroy(gameObject);
        }
    }
}
