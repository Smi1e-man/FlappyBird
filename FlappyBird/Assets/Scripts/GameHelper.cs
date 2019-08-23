using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHelper : MonoBehaviour
{
    // private visual values 
    [SerializeField]
    private Text scoreText;

    // public values
    public GameObject pipe;
    public Button RestartButton;

    // public unvisual values
    [HideInInspector]
    public int score;

    /// <summary>
    /// Private Methods.
    /// </summary>
    private void Start()
    {
        StartCoroutine(GeneratePipes());
        RestartButton.gameObject.SetActive(false);
    }

    private void Update()
    {
        scoreText.text = "Score: " + score;
            RestartButton.onClick.AddListener(Restart);
    }

    private IEnumerator GeneratePipes()
    {
        Vector2 position;

        while (true)
        {
            position = transform.position;
            position.x += 6.0f;
            pipe = Instantiate(pipe, position, Quaternion.identity);
            yield return new WaitForSeconds(1.2f);
        }
    }

    /// <summary>
    /// Public Methods.
    /// </summary>
    public void Restart()
    {
        Application.LoadLevel(Application.loadedLevel);
        Time.timeScale = 1.0f;
    }
}
