using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    private float horizontalMovement;
    private Vector3 velocity = Vector3.zero;
    public Rigidbody2D playerRigidBody;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal") * moveSpeed * Time.fixedDeltaTime; //si appuie sur fleche, adapte vitesse à changement frame et on applique une force
    }

    void FixedUpdate()
    {
        MovePlayer(horizontalMovement);
    }

    void MovePlayer(float _horizontalMovement)
    {

        Vector3 targetVelocity = new Vector2(_horizontalMovement, playerRigidBody.velocity.y);
        playerRigidBody.velocity = Vector3.SmoothDamp(playerRigidBody.velocity, targetVelocity, ref velocity, .05f); //re voit

    }
}
