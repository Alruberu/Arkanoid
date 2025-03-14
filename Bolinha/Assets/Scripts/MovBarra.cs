using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovBarra : MonoBehaviour
{
    public float speed = 5;
    public float maxX = 7.5f;
    float movimentHorizontal;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movimentHorizontal = Input.GetAxis("Horizontal");
        if((movimentHorizontal>0 && transform.position.x<maxX) || (movimentHorizontal<0 && transform.position.x > -maxX))
        {
        transform.position += Vector3.right*movimentHorizontal*speed*Time.deltaTime;
        }
    }
}
