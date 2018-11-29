using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingController : MonoBehaviour {

    public bool isRightCollider = false;
    public bool isLeftCollider = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D target)
    {
        if ((target.gameObject.tag == "Boundarie")&&(isLeftCollider||isRightCollider))
        {
            GameObject parent = GameObject.Find("AliensController");

            Vector3 newPos = new Vector3(parent.transform.position.x, parent.transform.position.y - 1, 0);
            parent.transform.position = newPos;
            parent.GetComponent<AllienControllerMovement>().changeMovement();
        }

    }

    public void Die()
    {
        int index = int.Parse(gameObject.name);
        if (isRightCollider || isLeftCollider)
        {
            
            GameObject newEnemy = getNextIndex(index);

            if (newEnemy != null)
            {
                newEnemy.GetComponent<MovingController>().isLeftCollider = isLeftCollider;
                newEnemy.GetComponent<MovingController>().isRightCollider = isRightCollider;
            }
        }

        if (!gameObject.GetComponent<EnemyShooting>().lastEnemyInColumn)
        {
            GameObject newFireEnemy = nextEnemyInColumn(index);
            if(newFireEnemy != null)
            newFireEnemy.GetComponent<EnemyShooting>().enableFire();
        }

        Destroy(gameObject);
    }

    public GameObject nextEnemyInColumn(int index)
    {
        int newIndex = index;
        if (gameObject.GetComponent<EnemyShooting>().isOnRightSide)
        {
            newIndex++;
        }
        else{
            newIndex--;
        }

        GameObject newEnemyCollider = GameObject.Find("" + newIndex);

        return newEnemyCollider;



    }

    GameObject getNextIndex(int index)
    {
        int newIndex = index;

        if (isRightCollider)
        {
            newIndex++;
        }
        else if (isLeftCollider)
        {    
            newIndex--;
        }
        

        GameObject newEnemyCollider = GameObject.Find("" + newIndex);

        if((newEnemyCollider == null) && ((newIndex < 55) && newIndex > 0))
        {
            return getNextIndex(newIndex);
        }

        return newEnemyCollider;
    }

}
