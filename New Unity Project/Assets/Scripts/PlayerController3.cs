using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController3 : MonoBehaviour
{
  public float jumpForce;
  public float gravityModifier;
  public bool isOnGround = true;
  public bool gameOver = false;
  
  private Rigidbody _playerRb;
  
  // Start is called before the first frame update
  void Start()
  {
    _playerRb = GetComponent<Rigidbody>();
    Physics.gravity *= gravityModifier;
  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
    {
      _playerRb.AddForce(Vector3.up * jumpForce);
      isOnGround = false;
    }
  }

  private void OnCollisionEnter(Collision collision)
  {
    isOnGround = true;
    if (collision.gameObject.CompareTag("Ground"))
    {
      isOnGround = true;
    }
    else if (collision.gameObject.CompareTag("Obstacle"))
    {
      gameOver = true;
      Debug.Log("Game Over, man!");
    }

  }
}
