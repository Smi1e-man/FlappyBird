using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesHelper : MonoBehaviour
{
    //visual private values
    [SerializeField]
    private float speed;

    /// <summary>
    /// Private Methods.
    /// </summary>
    private void Start()
    {
        Vector2 position = transform.position;
        position.y = Random.Range(-0.3F, 1.8F);
        transform.position = position;
        Destroy(gameObject,6.0f);
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, transform.position - transform.right, speed * Time.deltaTime);
    }
}
