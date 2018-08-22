using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CedVuforiaBehavior : DefaultTrackableEventHandler
{

    private void Awake()
    {
        var audioSources = GetComponentsInChildren<AudioSource>();
        var animators = GetComponentsInChildren<Animator>();

        foreach (AudioSource audSource in audioSources)
        {
            audSource.Pause();
        }

        foreach (Animator anim in animators)
        {
            anim.StartPlayback();
        }
    }
    protected override void Start()
    {
        base.Start();
    }
    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();

        var audioSources = GetComponentsInChildren<AudioSource>();
        var animators = GetComponentsInChildren<Animator>();

        foreach(AudioSource audSource in audioSources)
        {
            audSource.Play();
        }

        foreach(Animator anim in animators)
        {
            anim.StopPlayback();
        }
    }

    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();

        var audioSources = GetComponentsInChildren<AudioSource>();
        var animators = GetComponentsInChildren<Animator>();

        foreach (AudioSource audSource in audioSources)
        {
            audSource.Pause();
        }

        foreach (Animator anim in animators)
        {
            anim.StopPlayback();
        }
    }
}