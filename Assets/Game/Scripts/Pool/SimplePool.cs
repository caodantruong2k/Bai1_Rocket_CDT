//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using static UnityEditor.PlayerSettings;

//public static class SimplePool 
//{
//    private  static Dictionary<PoolType,Pool> poolInstance =  new Dictionary<PoolType, Pool>();

//    public static void Preload(GameUnit prefab,int amout, Transform parent)
//    {
//        if(prefab == null) 
//        {
//            Debug.Log("PREFAB IS EMPTY");
//            return;
//        }
//        if (!poolInstance.ContainsKey(prefab.PoolType) || poolInstance[prefab.PoolType] == null )
//        {
//            Pool pool = new Pool();
//            pool.PreLoad(prefab, amout, parent);
//            poolInstance[prefab.PoolType]   = pool;
//        }
//    }
//    public static T Spawn <T> (PoolType poolType,Vector3 pos ,Quaternion rot ) where T : GameUnit
//    {
//        if(!poolInstance.ContainsKey(poolType))
//        {
//            Debug.Log(poolType +"NOT PRELOAD !!!");
//            return null;
//        }
//        return poolInstance[poolType].Spawn(pos,rot)as T;
//    }
//    public static   void Despawn(GameUnit gameUnit)
//    {
//        if (!poolInstance.ContainsKey(gameUnit.PoolType))
//        {
//            Debug.Log(gameUnit.PoolType + "NOT PRELOAD !!!");
           
//        }
//        poolInstance[gameUnit.PoolType].Despawn(gameUnit);
//    }
//    public static void Collect(PoolType poolType)
//    {
//        if (!poolInstance.ContainsKey(poolType))
//        {
//            Debug.Log(poolType + "NOT PRELOAD !!!");
           
//        }
//         poolInstance[poolType].Collet();
//    }
     
//    public static void ColletAll()
//    {
//        foreach (var item in poolInstance.Values)
//        {
//           item.Collet();
//        }
//    }

//    public static void Release(PoolType poolType)
//    {
//        if(!poolInstance.ContainsKey(poolType))
//        {
//            Debug.Log(poolType + "IS NOT PRELOAD !!!");


//        }
//        poolInstance[poolType].Release();
//    }
//    public static void ReleaseAll()
//    {
//        foreach(var item in poolInstance.Values)
//        {
//            item.Release();
//        }
//    }

    
//}
//public class Pool
//{
//    Transform parent;
//    GameUnit prefabs;
//    Queue<GameUnit>  inactives = new Queue<GameUnit>();
//    List<GameUnit> active = new List<GameUnit>();

//    public void PreLoad(GameUnit prefabs,int amout,Transform parent)
//    {
//        this.parent = parent;
//        this.prefabs = prefabs;
//        for (int i = 0; i< amout; i++)
//        {
//            Despawn(Spawn(Vector3.zero, Quaternion.identity));
//        }

//    }
//    public GameUnit Spawn(Vector3 pos ,Quaternion rot)
//    {
//        GameUnit unit;
//        if(inactives.Count <= 0)
//        {

//            unit = GameObject.Instantiate(prefabs, parent);
//        }
//        else
//        {
//            unit = inactives.Dequeue();
//        }
//        unit.TF.SetPositionAndRotation(pos, rot);
//        active.Add(unit);
//        unit.gameObject.SetActive(true);
//        return unit;

//    }
//    public void Despawn(GameUnit unit)
//    {

//        if(unit != null && unit.gameObject.activeSelf)
//        {
//            active.Remove(unit);
//            inactives.Enqueue(unit);
//            unit.gameObject.SetActive(false);
                
//        }
//    }
//    public void Collet()
//    {
//        while(active.Count > 0)
//        {
//            Despawn(active[0]);
//        }
//    }
//    public void Release()
//    {
//        Collet();
//       while(inactives.Count > 0)
//        {
//            GameObject.Destroy(inactives.Dequeue().gameObject);    
//        }
//        inactives.Clear();           
//    }
//}
