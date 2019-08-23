using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdHelper : MonoBehaviour
{
    // private values
    private Rigidbody2D rigidbody;
    private GameHelper gameHelper;

    // public values
    public float force;

    /// <summary>
    /// Private Methods.
    /// </summary>
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        gameHelper = Camera.main.GetComponent<GameHelper>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.AddForce(Vector2.up * (force - rigidbody.velocity.y), ForceMode2D.Impulse);
        }
        rigidbody.MoveRotation(rigidbody.velocity.y * 2.0f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
	{
        gameHelper.RestartButton.gameObject.SetActive(true);
        Time.timeScale = 0.0f;
	}

    private void OnTriggerExit2D(Collider2D other)
	{
        gameHelper.score++;
        Debug.Log(gameHelper.score);
	}
}
