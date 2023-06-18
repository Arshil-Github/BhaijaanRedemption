using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Vector3 spawnLoc;
    public float speed;

    public float spawnTimeGap;
    public GameObject[] spawnables;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawning());
    }
    IEnumerator spawning()
    {

        int randomObject = Random.Range(0, spawnables.Length);

        GameObject spawned = Instantiate(spawnables[randomObject], transform);
        spawned.transform.position = spawnLoc;
        spawned.AddComponent<LeftMovers>();
        spawned.AddComponent<DestroyOnWall>();
        spawned.GetComponent<LeftMovers>().speed = speed;

        yield return new WaitForSeconds(spawnTimeGap);
        StartCoroutine(spawning());

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
