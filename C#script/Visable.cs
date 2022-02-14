using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Visable : MonoBehaviour
{
    public Transform cam;
    [SerializeField] private List<GameObject> buttons = default;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(var i = 0; i < buttons.Count;i++)
        { 
            if (Vector3.Distance(buttons[i].transform.position, cam.position) < 0.6)
                buttons[i].SetActive(true);
            else
                buttons[i].SetActive(false);
        }

    }
}
