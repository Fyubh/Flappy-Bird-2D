using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    [SerializeField] private Sprite[] sprites;

    // Update is called once per frame
    void Start()
    {
        InvokeRepeating("Animate", 0.1f, 0.1f);
    }

    void Animate()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = sprites[0];
        gameObject.GetComponent<SpriteRenderer>().sprite = sprites[1];
        gameObject.GetComponent<SpriteRenderer>().sprite = sprites[2];
        gameObject.GetComponent<SpriteRenderer>().sprite = sprites[3];
    }
}
