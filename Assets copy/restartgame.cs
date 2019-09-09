using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restartgame : MonoBehaviour
{
    public GameObject startPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            Debug.Log("in herc");
            gameObject.transform.position = startPoint.transform.position;
        }
    }
}
