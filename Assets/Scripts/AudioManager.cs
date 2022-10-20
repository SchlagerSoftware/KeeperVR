using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    #region Singleton

    private static AudioManager instance;

    private void Awake()
    {
        instance = this;
    }

    public static AudioManager GetInstance()
    {
        return instance;
    }

    #endregion

    [SerializeField]
    private AudioSource menuItemClick;


    public void PlayMenuItemClick()
    {
        menuItemClick.Play();
    }
}
