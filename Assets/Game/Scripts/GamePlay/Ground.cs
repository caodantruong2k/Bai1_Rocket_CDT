using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : ColorObject
{
    public static Ground Instance;
    public Transform[] spherePoint;
    private List <Vector3> emtypoint = new List <Vector3> ();
    [SerializeField] GameObject spherePrefabs;
    public List<Sphere> sphereList = new List <Sphere> ();

    private Vector3[,] sphereArray;
    private int width = 11;
    private int height = 11;
    // Start is called before the first frame update
    private void Awake()
    {
       
    }
    void Start()
    {
       Instance = this;
    }
    public void Init()
    {
        TFSphere();
        MakerSphere();
        for (int i = 0; i < spherePoint.Length; i++)
        {
            emtypoint.Add(spherePoint[i].position);
        }   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void TFSphere()
    {
        sphereArray = new Vector3[width, height];
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                float Posx = i * 2f;
                float Posz = j * 2f;
                Vector3 sphere = new Vector3(Posx - 10f, .3f, Posz - 10f);
                sphereArray[i, j] = sphere;
            }

        }
    }
    private void MakerSphere()
    {
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                
               Sphere sphere = SimplePool.Spawn<Sphere>(PoolType.sphere, sphereArray[i, j], Quaternion.identity);
                sphere.ChangColor((ColorType)Random.Range(0, 3));
                sphereList.Add(sphere);
            }
        }

    }
    public void AddPoint(Vector3 sphere)
    {
       
        emtypoint.Add(sphere);
        NewSphere();
    }

    public void NewSphere()
    {
        int rand = Random.Range(0,emtypoint.Count);
        
        Sphere sphere = SimplePool.Spawn<Sphere>(PoolType.sphere, emtypoint[rand], Quaternion.identity);

        sphere.ChangColor((ColorType)Random.Range(0, 3));
        sphere.Init();
        sphereList.Add(sphere);

        emtypoint.RemoveAt(rand);
    }
    public void DestroySphere()
    {
       for(int i = 0;i < sphereList.Count; i++)
        {
            SimplePool.Despawn(sphereList[i]);

        }
    }
}
