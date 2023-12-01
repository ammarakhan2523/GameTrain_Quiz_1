using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveFarword : MonoBehaviour
{
    public float speed = 40.0f;
    public bool flag ;
    private CollisionDetection collisionDetectionScript;
    // Start is called before the first frame update
    void Start()
    {
        collisionDetectionScript = GetComponent<CollisionDetection>();
    }

    // Update is called once per frame
    void Update()
    {
        // it will move the knife in forwaed direction
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
