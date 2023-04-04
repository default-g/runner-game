using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 3;
    public float leftRightSpeed = 4;
    public static bool canMove = false;
    public bool isJumping = false;
    public bool comingDown = false;
    public GameObject playerObject;

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * this.moveSpeed, Space.World);
        if (canMove == true)
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                if (this.gameObject.transform.position.x > LevelBoundary.leftSide)
                {
                    transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);
                }
            }

            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                if (this.gameObject.transform.position.x < LevelBoundary.rightSide)
                {
                    transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed * -1);
                }
            }

            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.Space))
            {
                if (isJumping == false)
                {
                    isJumping = true;
                    playerObject.GetComponent<Animator>().Play("Jump");
                    StartCoroutine(JumpSequence());
                }
            }
            if (isJumping == true)
            {
                if (comingDown == false)
                {
                    transform.Translate(Vector3.up * Time.deltaTime * 5, Space.World);
                }
                if (comingDown == true)
                {
                    transform.Translate(Vector3.up * Time.deltaTime * -5, Space.World);
                }
            }
        }
    }

    IEnumerator JumpSequence()
    {
        yield return new WaitForSeconds(0.5f);
        comingDown = true;
        yield return new WaitForSeconds(0.5f);
        isJumping = false;
        comingDown = false;
        if (canMove)
        {
            playerObject.GetComponent<Animator>().Play("Standard Run");

        }
    }
}

