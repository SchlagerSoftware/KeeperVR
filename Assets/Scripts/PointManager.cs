using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointManager : MonoBehaviour
{
    [SerializeField]
    private GameObject shootNumberText;

    [SerializeField]
    private GameObject goalsNumberText;

    [SerializeField]
    private GameObject savesNumberText;

    private TMP_Text shootText;
    private TMP_Text goalsText;
    private TMP_Text savesText;

    void Start()
    {
        this.shootText = shootNumberText.GetComponent<TMP_Text>();
        this.goalsText = goalsNumberText.GetComponent<TMP_Text>();
        this.savesText = savesNumberText.GetComponent<TMP_Text>();
        this.ResetResultBoard();
    }

    public void ResetResultBoard()
    {
        shootText.SetText("0");
        goalsText.SetText("0");
        savesText.SetText("0");
    }

    public void AddShot()
    {
        int currentValue = int.Parse(shootText.text);
        currentValue++;
        shootText.SetText(currentValue.ToString());
    }


    public void AddGoal()
    {
        int currentValue = int.Parse(goalsText.text);
        currentValue++;
        goalsText.SetText((currentValue).ToString());
    }

    public void AddSave()
    {
        int currentValue = int.Parse(savesText.text);
        currentValue++;
        savesText.SetText((currentValue).ToString());
    }

    // Update is called once per frame
    void Update()
    {

    }
}
