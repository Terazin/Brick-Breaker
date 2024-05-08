using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlockDestroy : MonoBehaviour
{
    public Text ScoreText; // UI Textオブジェクトをアサイン

    private int Score = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Destroy(gameObject);
            Score += 10; // スコアを10加算
            ScoreText.text = $"Score: {Score}"; // UI Textにスコアを表示
        }
    }
}