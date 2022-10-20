using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField]
    private Slider volumeSlider;

    void Start()
    {
        if (!PlayerPrefs.HasKey(PrefsEnumClass.MUSIC_VOLUME))
        {
            PlayerPrefs.SetFloat(PrefsEnumClass.MUSIC_VOLUME, 1);
        }
        Load();
    }

    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        Save();
    }

    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat(PrefsEnumClass.MUSIC_VOLUME);
    }

    private void Save()
    {
        PlayerPrefs.SetFloat(PrefsEnumClass.MUSIC_VOLUME, volumeSlider.value);
    }

}
