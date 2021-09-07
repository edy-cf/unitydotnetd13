using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
  private float _speed = 30.0f;
  private PlayerController3 playerControllerScript;
  private float _leftBound = -15;

  // Start is called before the first frame update
  void Start()
  {
    playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController3>();
  }

  // Update is called once per frame
  void Update()
  {
    if (playerControllerScript.gameOver == false)
    {
      transform.Translate(Vector3.left * Time.deltaTime * _speed);
    }

    if (transform.position.x < _leftBound && gameObject.CompareTag("Obstacle"))
    {
      Destroy(gameObject);
    }
  }
}
