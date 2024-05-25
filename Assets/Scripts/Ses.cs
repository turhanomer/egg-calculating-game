using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ses : MonoBehaviour
{
    public AudioSource AudioSource;
    // Start is called before the first frame update
    void Start()
    {
        if (AudioSource == null) 
        { 
            AudioSource = GetComponent<AudioSource>();
            AudioSource.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
