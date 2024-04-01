using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : ColorObject
{
    [SerializeField] public float speed = 5f;
    
   
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(Constant.TAG_Sphere))

        {
            Sphere sphere = Cache.GetSphere(other);
            if(sphere.colorType == colorType)
            {
                Vector3 posSphere = sphere.TF.position;
                StartCoroutine(DelaySpawn(posSphere));
                SimplePool.Despawn(sphere);
                Ground.Instance.sphereList.Remove(sphere);
                RandomColor();
                GameManager.Ins.UpScore();
                
              
               
            }
            if(sphere.colorType != colorType)
            {
                Dead();
            }

        }

        
        
    }
    public void RandomColor()
    {
        ChangColor((ColorType)Random.Range(0, 3));

    }
    private void Dead()
    {
        GameManager.Ins.Dead(); 

    }
   IEnumerator  DelaySpawn(Vector3 pos)
    {
        yield return new WaitForSeconds(0f);
        Ground.Instance.AddPoint(pos);
    }

   

}
