using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BallController : MonoBehaviour
{
    [SerializeField]
    private GameObject targetPlane;

    [SerializeField]
    private float speed = 0.001f;

    private Rigidbody rb;
    private Vector3 startPosition;
    private bool isGoal;

    private PointManager pointManager;
    private ShootManager shootManager;

    void Start()
    {
        this.rb = gameObject.GetComponent<Rigidbody>();
        this.startPosition = gameObject.transform.position;
        this.pointManager = GameObject.FindObjectOfType<PointManager>();
        this.shootManager = GameObject.FindObjectOfType<ShootManager>();
    }

    public void Reset()
    {
        gameObject.transform.position = this.startPosition;
        rb.velocity = Vector3.zero;
    }

    public void Grabbed()
    {
        this.pointManager.AddSave();
    }

    public void Shot()
    {
        this.isGoal = false;
        Vector3 target = this.GenerateTargetPoint();
        this.rb.AddForce((target - this.transform.position).normalized * this.speed + new Vector3(0, 3f, 0), ForceMode.Impulse);
        this.pointManager.AddShot();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "GoalLine" && isGoal == false)
        {
            this.isGoal = true;
            this.pointManager.AddGoal();
            this.shootManager.Reset();
        }
    }

    private Vector3 GenerateTargetPoint()
    {
        Bounds bounds = this.targetPlane.GetComponent<Collider>().bounds;
        return new Vector3(
        Random.Range(bounds.min.x, bounds.max.x),
        Random.Range(bounds.min.y, bounds.max.y),
        Random.Range(bounds.min.z, bounds.max.z)
    );
    }
}
