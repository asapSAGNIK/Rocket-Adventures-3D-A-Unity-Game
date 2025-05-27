using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{Rigidbody rb;
 AudioSource asrc;
 [SerializeField] float thrstspd = 1f;
 [SerializeField] float rtnspd = 10f;
 [SerializeField] AudioClip engine;
 [SerializeField]  ParticleSystem vertparticles;
 [SerializeField]  ParticleSystem leftparticles;
 [SerializeField]  ParticleSystem rightparticles;
   
    // Start is called before the first frame update
    void Start()
    {
       rb= GetComponent<Rigidbody>();
       asrc =GetComponent<AudioSource>();
      
    }

    // Update is called once per frame
    void Update()
    {
        Thruster();

    }
    void Thruster()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(Vector3.up * thrstspd*Time.deltaTime);
            
           if(!asrc.isPlaying)
           {
            asrc.PlayOneShot(engine);
           }
           if(!vertparticles.isPlaying)
           {
            vertparticles.Play();
           }
        }   
        else
        {
            asrc.Stop();
            vertparticles.Stop();
        }
        
        if (Input.GetKey(KeyCode.A) && !(Input.GetKey(KeyCode.D)) )
        {
            Rotnf(rtnspd);
            if(!leftparticles.isPlaying)
           {
            leftparticles.Play();
           }
           
        }
            
        else if(Input.GetKey(KeyCode.D) && !(Input.GetKey(KeyCode.A)) )
        {
            Rotnf(-rtnspd);
           if(!rightparticles.isPlaying)
           {
            rightparticles.Play();
           }
        }
            
            else
            {
                rightparticles.Stop();
                leftparticles.Stop();
            }
         
        

    
    }

    public void Rotnf(float rotnfnc)
    {
        rb.freezeRotation=true;
        transform.Rotate(Vector3.forward * rotnfnc * Time.deltaTime);
        rb.freezeRotation=false;
    }
    
}