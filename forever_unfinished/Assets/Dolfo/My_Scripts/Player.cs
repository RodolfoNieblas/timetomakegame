using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.SceneManagement; // I am using this header in order to change scenes


public class Player : MonoBehaviour
{
    public float speed;
    public Animator Player_Animator;
    bool right = false;
    bool left = false;
    bool up = false;
    bool down = false;

    void Start()
    {
        Player_Animator = GetComponent<Animator>();
    }

    
    void Update()
    {
        //Code for Movement
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0f);
        transform.position = transform.position + (movement.normalized * speed * Time.deltaTime);

        //Code for Animator
        if(Input.GetKeyDown(KeyCode.W)){
            up = true;
            Player_Animator.SetBool("Up", up);
        }
        else if(Input.GetKeyUp(KeyCode.W)){
            up = false;
            Player_Animator.SetBool("Up", up);
        }
    }
}
