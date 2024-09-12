using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class woodScript : MonoBehaviour
{
    [SerializeField] private GameObject[] madeiraPrefab;

    [SerializeField] private float spawnRate = 2f;

    [SerializeField] private bool canSpawn = true;


    private void Start()
    {
        StartCoroutine(Spawner());
    }
    
    private IEnumerator Spawner()
    {
        WaitForSeconds wait = new WaitForSeconds(spawnRate);

        while (canSpawn)
        {
            yield return wait;
            int rand = Random.Range(0, madeiraPrefab.Length);
            GameObject madeiraToSpawn = madeiraPrefab[rand];

            Instantiate(madeiraToSpawn, transform.position, Quaternion.identity);
        }
    }
}
