using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    [Header("Enemy Movement")]
    public Bounds movementBound;
    public Bounds startRange;

    private float startingPoint;
    private float randomSpeed;

    // Start is called before the first frame update
    void Start()
    {
        randomSpeed = Random.Range(movementBound.min, movementBound.max);
        startingPoint = Random.Range(startRange.min, startRange.max);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(Mathf.PingPong(Time.time, randomSpeed) + startingPoint, transform.position.y);
    }
}
