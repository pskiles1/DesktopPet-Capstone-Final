using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zill : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject activeGameObject;

    public void ActivateObject()
    {
        if (activeGameObject.activeSelf != true)
        {
            Randomizedwalking.instance.OnEnable();
            activeGameObject.SetActive(true);
        }
        else
        {
            activeGameObject.SetActive(false);
        }
    }
}
