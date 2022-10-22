using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootManager : MonoBehaviour
{
    [SerializeField]
    private BallController ballController;

    [SerializeField]
    private AudioManager audioManager;

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
        StartCoroutine(ShotProcess());
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
