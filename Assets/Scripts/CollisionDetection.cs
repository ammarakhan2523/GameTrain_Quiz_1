using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    Rigidbody rigidBody;
    private moveFarword moveFarwordScript;
   int count;
    public bool gameOver;

    void Start()
    {
        moveFarwordScript = GetComponent<moveFarword>();
        rigidBody = GetComponent<Rigidbody>(); // rigidbody of knife
    }

    // Update is called once per frame
    void Update()
    {
       
       
    }
    private void OnCollisionEnter(Collision collision)
    {
        // It will stick the knife to the dart when knife collide with dart
        if (collision.gameObject.CompareTag("Dart") && moveFarwordScript.flag==true && gameOver==false)
        {
            transform.Translate(Vector3.zero);
            rigidBody.isKinematic = true;
            gameObject.transform.parent = collision.transform;
            moveFarwordScript.flag = false;
            count++;
            if(count == 4)
            {
                Destroy(collision.gameObject);
               // Destroy(gameObject);
            }
         
        }
        // will destroy knife and make game over when collide with another knife
        if (collision.gameObject.CompareTag("knife") )
        {

            Destroy(gameObject);
            gameOver = true;
            print("Game Over");

        }
    }
}
