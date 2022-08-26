using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public static SpawnManager Instance;

    public GameObject cubePrefab;
    public Material cubeMaterial;
    public int scoreValueForBlue = 20;
    public int scoreValueForRed = 30;

    public Vector3 minBounds;
    public Vector3 maxBounds;


    private GameObject cubeParent;


    private void Awake()
    {
        Instance = this;
    }


    void Start()
    {
        cubeParent = new GameObject("CubesParent");
    }

    public void SpawnObjects(int _count)
    {
        for (int i = 0; i < _count; i++)
        {
            int _streak = i < _count / 2 ? -1 : 1;
            Color _color = _streak > 0 ? Color.red : Color.blue;
            int _score = _streak > 0 ? scoreValueForRed : scoreValueForBlue;
            Instantiate(cubePrefab, GetRandomPosition(), Quaternion.identity, cubeParent.transform).GetComponent<Cube>().SetPlayer(_streak, _color, _score);
        }
    }


    private Vector3 GetRandomPosition()
    {
        return new Vector3(
            Random.Range(minBounds.x, maxBounds.x),
            minBounds.y,
            Random.Range(minBounds.z, maxBounds.z)
            );
    }
}
