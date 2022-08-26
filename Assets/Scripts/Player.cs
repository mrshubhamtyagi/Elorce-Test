using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10;
    public Vector3 movement;
    public int currentScore;

    public int currentStreak = -1;  //-1 for red | 1 for blue


    void Start()
    {
        currentStreak = 0;
    }

    void Update()
    {
        GetInputs();
        transform.Translate(movement * speed * Time.deltaTime, Space.World);
    }


    public void GetInputs()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.z = Input.GetAxis("Vertical");
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.gameObject.GetComponent<Cube>())
        {
            Cube _cube = collision.gameObject.gameObject.GetComponent<Cube>();
            if (_cube.streakValue == currentStreak)
            {
                currentScore += _cube.score;
            }
            else
            {
                currentScore = currentScore == 0 ? _cube.score : currentScore = 0;
                currentStreak = _cube.streakValue;
            }

            MainController.Instance.UpdateScore(currentScore);
            collision.gameObject.SetActive(false);

        }
    }

}
