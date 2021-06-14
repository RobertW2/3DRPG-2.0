using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public Image StaminaBar;
    private Rigidbody2D rb;
    private float move;

    [SerializeField] private float moveSpeed = 10;         // Var 1
    [SerializeField] private float jumpHeight = 5;         // Var 2
    [SerializeField] private bool grounded;
    [SerializeField] private float sprintMulti = 2;        // Var 3

    [SerializeField] private float maxFuel = 5;            // Var 4
    [SerializeField] private float currentFuel = 5;
    [SerializeField] private float jetpackForce = 5;       // Var 5





    [SerializeField] private float maxStamina = 10;        // Vr 6
    [SerializeField] private float currentStamina = 10;

    public bool CreatingCharacter = true;




    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        if (CreatingCharacter)
            return;




        // Sprint and Stamina

         
        move = Input.GetAxisRaw("Horizontal") * moveSpeed;

        if (Input.GetKey(KeyCode.LeftShift) && currentStamina > 0)
        {
            move = move * sprintMulti;
            if(move != 0)
                currentStamina -= 2 * Time.deltaTime;
        }

        else if (!Input.GetKey(KeyCode.LeftShift) && currentStamina < maxStamina)
        {
            currentStamina += 1 * Time.deltaTime;
        }
        StaminaBar.fillAmount = currentStamina / maxStamina;





      // Jump Mechanics



        if (Input.GetButtonDown("Jump") && grounded)
        {
            rb.velocity += Vector2.up * jumpHeight;
        }
        else if (Input.GetButton("Jump") && grounded == false)
        {
            if (currentFuel > 0)
            {
                rb.velocity += Vector2.up * jetpackForce * Time.deltaTime;
                currentFuel -= Time.deltaTime;
            }
        }
        else if (Input.GetButtonUp("Jump"))
        {

        }





    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(move, rb.velocity.y); 
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Ground")
        {
            grounded = true;
            currentFuel = maxFuel;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        grounded = false;
    }

    public void RaiseStat(int value)
    {
        switch (value)
        {
            case 1:
                moveSpeed += 1;
                break;
            case 2:
                jumpHeight += 1;
                break;
            case 3:
                sprintMulti += 0.2f;
                break;
            case 4:
                maxFuel += 1;
                break;
            case 5:
                jetpackForce += 1;
                break;
        }
    }


    public void LowerStat(int value)
    {
        switch (value)
        {
            case 1:
                moveSpeed -= 1;
                break;
            case 2:
                jumpHeight -= 1;
                break;
            case 3:
                sprintMulti -= 0.2f;
                break;
            case 4:
                maxFuel -= 1;
                break;
            case 5:
                jetpackForce -= 1;
                break;
        }
    }










}
