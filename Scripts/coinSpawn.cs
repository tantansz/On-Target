using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinSpawn : MonoBehaviour
{
    [SerializeField] private GameObject[] coinPrefab;

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
            int rand = Random.Range(0, coinPrefab.Length);
            GameObject coinToSpawn = coinPrefab[rand];

            Instantiate(coinToSpawn, transform.position, Quaternion.identity);
        }       
    }
}
