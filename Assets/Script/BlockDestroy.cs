using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlockDestroy : MonoBehaviour
{
    public Text ScoreText; // UI Text�I�u�W�F�N�g���A�T�C��

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
            Score += 10; // �X�R�A��10���Z
            ScoreText.text = $"Score: {Score}"; // UI Text�ɃX�R�A��\��
        }
    }
}