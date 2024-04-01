using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class Sphere : ColorObject
{
    [SerializeField] Transform sphere;

    Vector3 left;
    Vector3 right;
    public float speed = 2;
    bool onTop;
    // Start is called before the first frame update
    void Start()
    {
        Init();

    }

    // Update is called once per frame
    void LateUpdate()
    {
        Move();
        if (transform.position == left)
        {
            onTop = true;
        }
        if (transform.position == right)
        { onTop = false; }
     


    }
   public void Init()
    {
        left = sphere.transform.position + Vector3.left * 0.5f;
        right = sphere.transform.position + Vector3.right * 0.5f;
        Randommove();

    }
    private void Move()
    { 
        if (GameManager.Ins.game)
        {
            if (!onTop)
            {
                transform.position = Vector3.MoveTowards(TF.position, left, Time.deltaTime * speed);

            }
            else
            {
                transform.position = Vector3.MoveTowards(TF.position, right, Time.deltaTime * speed);

            }

        }
        


    }
    public void Randommove()
    {
        int i = Random.Range(0, 2);
        if (i != 1)
        {
            onTop = false;
        }
        else
        {
            onTop = true;
        }
    }

}
