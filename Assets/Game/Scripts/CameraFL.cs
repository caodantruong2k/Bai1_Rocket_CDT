using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFL : Singleton <CameraFL>
{
    [SerializeField] Transform tf;
    [SerializeField] Transform tfPlayer;
    [SerializeField] Vector3 offset;

    public float speed = 10f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (tfPlayer == null)
        {
            return;
          }
        tf.position = Vector3.Lerp(tf.position,tfPlayer.position+ offset, speed *Time.deltaTime);

    }
    public void  FlashMove( int key)
    {
        switch (key)
        {
            case 1: 
             tf.position = new Vector3 (-15f,tf.position.y,tf.position.z);
                break;
            case 2:
                tf.position = new Vector3(15f, tf.position.y, tf.position.z);
                break;
            case 3:
                tf.position = new Vector3(-transform.position.x, tf.position.y, -15f);
                break;
            case 4:
                tf.position = new Vector3(tf.position.x, tf.position.y, 15f);
                break;


        }

    }
}
