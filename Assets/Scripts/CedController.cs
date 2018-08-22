using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CedController : MonoBehaviour {

    public CedController instance;


    private Animator anim;
    private AudioSource aSource;

    private void Awake()
    {
        instance = this;
    }
    
	public void Stop()
    {
        anim.StopPlayback();
        aSource.Pause();
    }

    public void Play()
    {
        anim.StartPlayback();
    }
}
