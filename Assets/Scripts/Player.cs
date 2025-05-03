using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomizedwalking : MonoBehaviour

{
    public static Randomizedwalking instance;

    Rigidbody2D rb2;
    SpriteRenderer spr;
    Animator _animator;

    public float random;
    public float speed = 1;

    private void Awake()
{
    instance = this;
}

    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
        spr = GetComponent<SpriteRenderer>();

        StartCoroutine(ChangeDirection());

        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        float movementSpeed = rb2.velocity.sqrMagnitude;
        _animator.SetFloat("speed", movementSpeed);
    }
    IEnumerator ChangeDirection()
    {
        yield return new WaitForSeconds(4f);
        random = Random.Range(0, 9);
        if (random == 0)
        {
            spr.flipX = true;
            rb2.velocity = new Vector2(1, 0) * speed;
        }
        if (random == 1)
        {
            spr.flipX = false;
            rb2.velocity = new Vector2(-1, 0) * speed;
        }
        if (random == 2)
        {
            rb2.velocity = new Vector2(0, 1) * speed;
        }
        if (random == 3)
        {
            rb2.velocity = new Vector2(0, -1) * speed;
        }
        if (random == 4)
        {
            spr.flipX = true;
            rb2.velocity = new Vector2(1, 1) * speed;
        }
        if (random == 5)
        {
            spr.flipX = false;
            rb2.velocity = new Vector2(-1, -1) * speed;
        }
        if (random == 6)
        {
            spr.flipX = true;
            rb2.velocity = new Vector2(1, -1) * speed;
        }
        if (random == 7)
        {
            spr.flipX = false;
            rb2.velocity = new Vector2(-1, -1) * speed;
        }
        if (random == 8)
        {
            spr.flipX = true;
            rb2.velocity = new Vector2(0, 0) * speed;
        }
        yield return StartCoroutine(ChangeDirection());
    }
    public void OnEnable()
    {
    StartCoroutine(ChangeDirection());
    }
    public void OnDisable()
    {
    StopAllCoroutines();
    }
}