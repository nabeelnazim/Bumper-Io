using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyprefab;
    public float spawnrange = 6;
    public float startinterval = 2f;

    // Start is called before the first frame update
    void Start()
    {
        spawngameobjects();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private Vector3 spawnposition()
    {
        float spawnX = Random.Range(-spawnrange, spawnrange);
        float spawnZ = Random.Range(-spawnrange, spawnrange);
        Vector3 spawnPos = new Vector3(spawnX, 0, spawnZ);
        return spawnPos;
    }
    public void spawngameobjects()
    {
        for (int i = 0; i < enemyprefab.Length; i++)
        {
            Instantiate(enemyprefab[i], spawnposition(), this.transform.rotation);
        }
    }
}
