using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    private void Awake()
    {
        SetUpSingleton();
    }

    private void SetUpSingleton()
    {
        if(FindObjectsOfType<MusicPlayer>().Length > 1)
        {
            gameObject.SetActive(false); // Because Destroy is being called a bit later we need to set gameObject to inactive.
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}
