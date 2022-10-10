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

    void Start()
    {
        this.rb = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        //! MOCK UNITY NO START GAME BUTTON
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.Shot();
        }
    }

    public void Shot()
    {
        Vector3 target = this.GenerateTargetPoint();
        this.rb.AddForce((target - this.transform.position).normalized * this.speed + new Vector3(0, 3f, 0), ForceMode.Impulse);
    }

    private Vector3 GenerateTargetPoint()
    {
        Bounds bounds = this.targetPlane.GetComponent<Collider>().bounds;
        print(bounds.min);
        print(bounds.max);
        return new Vector3(
        Random.Range(bounds.min.x, bounds.max.x),
        Random.Range(bounds.min.y, bounds.max.y),
        Random.Range(bounds.min.z, bounds.max.z)
    );
    }
}
