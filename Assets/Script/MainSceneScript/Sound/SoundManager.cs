using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    private AudioSource audioSource;

    public AudioClip[] audioclip;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            audioSource = GetComponent<AudioSource>();
        }
        else
            Destroy(gameObject);
    }

    private void Start()
    {

        audioSource.clip = audioclip[0];
        audioSource.Play();
    }


    public void ChangeBgm(int num)
    {
        audioSource.Stop();
        audioSource.clip = audioclip[num];
        audioSource.Play();
    }



}

