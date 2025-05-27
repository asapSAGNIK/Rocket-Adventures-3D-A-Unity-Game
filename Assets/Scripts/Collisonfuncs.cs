using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collisonfuncs : MonoBehaviour
{ AudioSource asrc;
  [SerializeField] float leveldelay=1f;
  [SerializeField] AudioClip collision;
  [SerializeField] AudioClip success;
  [SerializeField] ParticleSystem collisionparticles;
  [SerializeField]  ParticleSystem successparticles;
  bool cheat=false;
  
   
   bool change= false;

  void Start()
   {
    asrc =GetComponent<AudioSource>();
   }
   void Update()
   {
    if(Input.GetKeyDown(KeyCode.Z))
    {
      cheat= !cheat;
    }

   }
     void OnCollisionEnter(Collision other) 
    {  
      if(change||cheat)
      {return;}
      
      switch(other.gameObject.tag)
      {
        case "Spawn":
          Debug.Log("U r at the start");
          break;
        case "Obst":
          Debug.Log("Oops Dont hit the obstacles");
          fail();
          break;
        case "Finish":
          Debug.Log("Congrats!!! u finished");
          donedeal();

          break;
        default :
          Debug.Log("TIme up");
          fail(); 
          break;

          
      }
      
    }
  void nextlevel()
  { 
    int currentscene=SceneManager.GetActiveScene().buildIndex;
    int nextscene = currentscene +1;
  
    if (nextscene==SceneManager.sceneCountInBuildSettings)
    {
       nextscene=1;
    }
    else
    {
      SceneManager.LoadScene(nextscene);
    }

  }
  void donedeal()
  {
    change=true;
    asrc.Stop();
    successparticles.Play();
    asrc.PlayOneShot(success);
    GetComponent<Movement>().enabled=false;
    Invoke("nextlevel",leveldelay);

  }
  void reloadlevel()
  { 
    
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
  }
  void fail()
  {
    change=true;
    asrc.Stop();
    collisionparticles.Play();
    asrc.PlayOneShot(collision);
    GetComponent<Movement>().enabled=false;
    Invoke("reloadlevel",leveldelay);
  
  }
}
