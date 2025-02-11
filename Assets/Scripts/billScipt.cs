using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class billScipt : MonoBehaviour


{

    public float temps =250f;
    public float time = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if( time > Time.deltaTime){
            time = 0f;
        }
    }


   public void OnCollisionEnter(Collision collision){
        
        if(collision.gameObject.CompareTag("Cible")){
            Destroy(collision.gameObject);
        }

        if(collision.gameObject.CompareTag("Terminus")){
           temps -= time;
           if (temps==0f){
            redemarrer();
           }
        }
    }

    public void redemarrer(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

   
}
