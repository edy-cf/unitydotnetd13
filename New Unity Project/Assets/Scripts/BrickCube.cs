﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickCube : MonoBehaviour
{
  public Vector3 rotationChange;
  
  // Start is called before the first frame update
  void Start()
  {
    
  }

  // Update is called once per frame
  void Update()
  {
    transform.Rotate(rotationChange);
    Debug.Log("Rotation is: " + rotationChange);
  }
}
