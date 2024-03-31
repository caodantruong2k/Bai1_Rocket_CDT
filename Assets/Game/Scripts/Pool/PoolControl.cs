//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class PoolControl : MonoBehaviour
//{
//    [SerializeField] PoolAmout[] poolamount;

//    private void Awake()
//    {
//        for (int i = 0; i < poolamount.Length; i++)
//        {
//            SimplePool.Preload(poolamount[i].prefab, poolamount[i].amount, poolamount[i].parent);
//        }
//    }
//}
//public class PoolAmout
//{
//    public GameUnit prefab;
//    public Transform parent;
//    public int amount;
//}
//public enum PoolType
//{
//    Sphere = 0,
//}
