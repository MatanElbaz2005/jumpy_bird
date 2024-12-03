using UnityEngine;
using UnityEngine.UIElements;

public class pillerSpawnerScript : MonoBehaviour
{
    public GameObject piller;
    public float spawnRate = 5;
    private float timer = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnObject(piller, new Vector3(15, 0, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnObject(piller, transform.position, transform.rotation);
            timer = 0;
        }
    }

    void SpawnObject(GameObject gameObject, Vector3 position, Quaternion rotation)
    {
        float highestPoint = position.y + 10;
        float lowestPoint = position.y - 10;
        Instantiate(gameObject, new Vector3(position.x, Random.Range(lowestPoint, highestPoint), position.z), rotation);
    }
}
