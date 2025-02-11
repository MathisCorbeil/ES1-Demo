using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class billScipt : MonoBehaviour


{

    public float temps =0f;
    private bool terminer = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(terminer==true){
        temps+=Time.deltaTime;
        
        if(temps >= 5f){
            redemarrer();
            
        }
       }
       
    }


   public void OnCollisionEnter(Collision collision){
        
        if(collision.gameObject.CompareTag("Cible")){
            Destroy(collision.gameObject);
        }

        if(collision.gameObject.CompareTag("Terminus")){
           terminer = true;
          
           
        }
    }

    public void redemarrer(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

   
}
