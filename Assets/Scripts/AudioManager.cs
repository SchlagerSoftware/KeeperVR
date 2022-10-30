using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    #region Singleton

    private static AudioManager instance;

    private void Awake()
    {
        AudioListener.volume = PlayerPrefs.GetFloat(PrefsEnumClass.MUSIC_VOLUME);
        instance = this;
    }

    public static AudioManager GetInstance()
    {
        return instance;
    }

    #endregion

    [SerializeField]
    private AudioSource menuItemClick;

    [SerializeField]
    private AudioSource referee;

    [SerializeField]
    private AudioSource kick;


    public void PlayMenuItemClick()
    {
        menuItemClick.Play();
    }

    public void Referee()
    {
        referee.Play();
    }

    public void Kick()
    {
        kick.Play();
    }
}
