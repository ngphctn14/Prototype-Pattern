using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : Monster
{
    [SerializeField]
    private int health;

    [SerializeField]
    private int speed;

    public Slime(int health, int speed) 
    {
        this.health = health;
        this.speed = speed;
    }
    private void Update()
    {
        FollowPlayer();
    }

    public void FollowPlayer()
    {
        Vector3 playerPosition = Player.Instance.transform.position;
        playerPosition.y = transform.position.y;
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, speed * Time.deltaTime);
    }

    public override Monster Clone()
    {
        Monster monster = null;

        monster = Instantiate(this, transform.localPosition, transform.localRotation);

        monster.transform.localScale = transform.localScale;

        monster.gameObject.SetActive(true);

        return monster.GetComponent<Slime>();
    }
}
