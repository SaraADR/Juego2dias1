using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class ShotMovement : MonoBehaviour {

    public float speed = 15f;
    public double limit;
    public bool onColission;

    void Start()
    {
        if (gameObject.tag == "EnemyShot")
        {
            speed = -15f;
        }
    }

	void Update () {
        transform.position += Vector3.up * speed * Time.deltaTime;

        if ((transform.position.y >= limit + transform.localScale.y) || (transform.position.y <= -limit - transform.localScale.y))
        {
            Destroy(gameObject);
        }
	}

    void OnCollisionEnter2D(Collision2D target)
    {
        if (target.collider.gameObject.tag == "Wall")
        {
            this.CollisionWithWall(target);
        }
        else if ((target.collider.gameObject.tag == "Player") && (gameObject.tag == "EnemyShot"))
        {
            this.CollisionBetweenPlayerAndEnemyShot(target,gameObject);
        }
        else if ((target.collider.gameObject.tag == "Enemy") && (gameObject.tag == "PlayerShot"))
        {
            this.CollisionBetweenEnemyAndPlayerShot(target,gameObject);
        }
        else if (target.collider.gameObject.tag == "Ufo")
        {
            this.CollisionWithUfo(target);
        }
    }

    private void GetScore(Collision2D target)
    {
        ScoreTextScript scoreTextScript = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreTextScript>();
        switch (target.gameObject.transform.parent.name)
        {
            case "Row1":
                scoreTextScript.SetScoreValue(10);
                break;
            case "Row2":
                scoreTextScript.SetScoreValue(10);
                break;
            case "Row3":
                scoreTextScript.SetScoreValue(20);
                break;
            case "Row4":
                scoreTextScript.SetScoreValue(20);
                break;
            case "Row5":
                scoreTextScript.SetScoreValue(50);
                break;
        }
    }

    private void CollisionWithWall(Collision2D target)
    {
        target.gameObject.GetComponent<wallPieceController>().recieveDamage();
        Destroy(gameObject);
    }

    private void CollisionBetweenPlayerAndEnemyShot(Collision2D target, GameObject gameObject)
    {
        target.gameObject.GetComponent<PlayerLifes>().recieveDamage();
        AudioSource audio = GameObject.Find("EnemySound").GetComponent<AudioSource>();
        audio.Play();
        Destroy(gameObject);
    }

    private void CollisionBetweenEnemyAndPlayerShot(Collision2D target, GameObject gameObject)
    {
        AudioSource audio = GameObject.Find("EnemySound").GetComponent<AudioSource>();
        audio.Play();
        target.gameObject.GetComponent<MovingController>().Die();
        GetScore(target);
        Destroy(gameObject);
    }

    private void CollisionWithUfo(Collision2D target)
    {
        Random rnd = new Random();
        GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreTextScript>().SetScoreValue(rnd.Next(50, 200));
        Destroy(gameObject);
        target.gameObject.GetComponent<UfoMovement>().resetPosition();
    }
}
