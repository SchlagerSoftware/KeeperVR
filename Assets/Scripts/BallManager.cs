using UnityEngine;
using UnityEngine.UI;

public class BallManager : MonoBehaviour
{
    [SerializeField]
    private Slider speedSlider;

    void Start()
    {
        if (!PlayerPrefs.HasKey(PrefsEnumClass.BALL_SPEED))
        {
            PlayerPrefs.SetFloat(PrefsEnumClass.BALL_SPEED, 0.5f);
        }
        Load();
    }

    public void ChangeSpeed()
    {
        PlayerPrefs.SetFloat(PrefsEnumClass.BALL_SPEED, speedSlider.value);
    }

    private void Load()
    {
        speedSlider.value = PlayerPrefs.GetFloat(PrefsEnumClass.BALL_SPEED);
    }
}
