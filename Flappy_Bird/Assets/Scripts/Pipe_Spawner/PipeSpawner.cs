using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject Pipes;
    [SerializeField] private int StartingTime=1;
    [SerializeField] private  float SpawningTime = 2;
    [SerializeField] private float Spawn_position;
    

    private void Start()
    {
        InvokeRepeating("SpawnPipes",StartingTime,SpawningTime);
    }
    private void SpawnPipes()
    {
        Vector2 Spawn_Position = new Vector2(transform.position.x,Random.Range(-1*Spawn_position,Spawn_position));
        Instantiate(Pipes,Spawn_Position,Quaternion.identity);
    }
}
