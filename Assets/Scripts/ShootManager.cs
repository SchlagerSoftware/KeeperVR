using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootManager : MonoBehaviour
{
    [SerializeField]
    private BallController ballController;

    [SerializeField]
    private AudioManager audioManager;

    [SerializeField]
    private GameObject startButton;

    [SerializeField]
    private GameObject resetButton;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Shot()
    {
        this.startButton.SetActive(false);
        this.resetButton.SetActive(true);
        StartCoroutine(ShotProcess());
    }

    public void Reset()
    {
        this.ballController.Reset();
        this.startButton.SetActive(true);
        this.resetButton.SetActive(false);
    }


    private IEnumerator ShotProcess()
    {
        audioManager.Referee();
        yield return new WaitForSeconds(2);
        audioManager.Kick();
        yield return new WaitForSeconds(.3f);
        ballController.Shot();
    }
}
