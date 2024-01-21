using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class useScriptableobject : MonoBehaviour
{
    [SerializeField] SAOB scriptableObject;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(scriptableObject.name);
        Debug.Log(scriptableObject.age);
    }   

    // Update is called once per frame
    void Update()
    {
        
    }
}
