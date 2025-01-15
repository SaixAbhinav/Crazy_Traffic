using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{   
    bool alive = true;
    public Rigidbody rb;
    public float speed = 5f;
    float horizontalInput;
    public float horizontalMultiplier = 2;

    // Start is called before the first frame update
   void Start()
    {
        rb =  GetComponent<Rigidbody>();
    }
    
    void FixedUpdate()
    {
        if(!alive) return;


        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime * horizontalMultiplier;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);
    }

    // Update is called once per frame
    void Update()
    {   
        horizontalInput = Input.GetAxis("Horizontal");
    
    }
    public void Die()
    {
        alive = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

}
