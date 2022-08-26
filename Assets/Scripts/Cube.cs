using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class Cube : MonoBehaviour
{
    public int streakValue;
    public int score;


    private MeshRenderer mr;



    private void Awake()
    {
        mr = GetComponent<MeshRenderer>();
    }

    void Start()
    {

    }

    public void SetPlayer(int _streakValue, Color _color, int _score)
    {
        streakValue = _streakValue;
        mr.material.color = _color;
        score = _score;
    }
}
