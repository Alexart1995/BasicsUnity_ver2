using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5f;
    Rigidbody arigidBody;
    // Start is called before the first frame update
    void Start()
    {
        arigidBody = GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void Update()
    {
        float VertMove = Input.GetAxis("Vertical");
        float HorMove = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(HorMove, 0f, VertMove);
        arigidBody.AddForce(movement * speed);
        
    }
}
