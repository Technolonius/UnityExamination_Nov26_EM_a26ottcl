using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objectToSpawn;


    public void Spawn()
    {
        Instantiate(objectToSpawn);
    }
}
