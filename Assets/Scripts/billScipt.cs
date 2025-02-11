using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class billScipt : MonoBehaviour

{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision collision){
        print(collision.gameObject.name + " : " + collision.gameObject.tag);
        if(collision.gameObject.CompareTag("Cible")){
            Destroy(collision.gameObject);
        }
    }
}
