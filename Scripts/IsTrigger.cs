using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsTrigger : MonoBehaviour
{
    private PlayerController playerControllerScript;
    private GameManager _gm;

    [SerializeField] private AudioSource source;
    [SerializeField] private AudioClip dead;
    [SerializeField] private AudioClip score;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        _gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Pipe"))
        {
            playerControllerScript.isGameOver = true;
            source.PlayOneShot(dead);
            Debug.Log("Game Over");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("TriggerScore"))
        {
            _gm.score++;
            source.PlayOneShot(score);
            Debug.Log(_gm.score);
        }
    }
}
