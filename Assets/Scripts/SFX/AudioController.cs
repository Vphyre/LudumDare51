using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] backgroundMusics;
    public int indexMusic = -1;

    // Start is called before the first frame update
    void Start()
    {
        if (indexMusic < 0)
        {
            indexMusic = Random.Range(1, backgroundMusics.GetLength(0));
        }

        AudioClip musicaCorrente = backgroundMusics[indexMusic];
        audioSource.clip = musicaCorrente;
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
