using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private Monster prototype;

    [SerializeField]
    private float timerMax;

    private float timer;

    private void Start()
    {
        timer = 0f;
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer > timerMax)
        {
            timer = 0f;
            SpawnMonster();
        }
    }

    public Monster SpawnMonster() {
        var monster = prototype.Clone();
        return monster;
    }
}
