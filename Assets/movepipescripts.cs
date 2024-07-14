using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movepipescripts : MonoBehaviour
{
  
    [SerializeField] private float _speed = 0.65f;// it can change in the untity editor

   // private float _speed = 0.65f; it cant chnage in the unity editor
    // Update is called once per frame
    private void Update()

    {
        transform.position += Vector3.left * _speed * Time.deltaTime;
        
    }
}
