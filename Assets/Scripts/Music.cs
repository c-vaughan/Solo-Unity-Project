using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    private static FMOD.Studio.EventInstance myMusicInstance;



    // Start is called before the first frame update
    void Start()
    {
        myMusicInstance = FMODUnity.RuntimeManager.CreateInstance("event:/Music");
        myMusicInstance.start();
        myMusicInstance.release();
    }

    // Update is called once per frame
    void Update()
    {
        ChangeTrack();
    }

    public static Music Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void ChangeTrack()
    {
        if (Input.GetKeyDown("1"))
        {
            myMusicInstance.setParameterByName("Music Track", 0);
        }
        if (Input.GetKeyDown("2"))
        {
            myMusicInstance.setParameterByName("Music Track", 1);
        }
        if (Input.GetKeyDown("3"))
        {
            myMusicInstance.setParameterByName("Music Track", 2);
        }
    }
}
