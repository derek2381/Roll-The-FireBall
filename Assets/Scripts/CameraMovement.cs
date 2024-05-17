using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 3.7f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if( transform.position.x <= 80)
        transform.Translate(0, 0, -(speed * Time.deltaTime));
    }
}
