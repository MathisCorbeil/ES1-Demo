using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demarerScipt : MonoBehaviour
{
    [SerializeReference] public GameObject _platformDepart;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public void startPiste(){
        _platformDepart.SetActive(false);
    }
}
