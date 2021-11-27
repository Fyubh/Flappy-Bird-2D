using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb_;
    [SerializeField] private float jumpForce;
    [SerializeField] private AudioSource source;
    [SerializeField] private AudioClip tap;
    [SerializeField] public bool isGameOver;
    // Start is called before the first frame update
    void Start()
    {
        rb_ = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rb_.gameObject.transform.position.y < 6 && !isGameOver)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb_.AddForce(new Vector2(0, jumpForce));
                source.PlayOneShot(tap);
            }
        }
        transform.eulerAngles = new Vector3(0, 0, rb_.velocity.y * 2f);
    }
}
