using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject enemyfab;
    public float span = 2.0f;
    float delta = 0;


    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject enemy = Instantiate(enemyfab) as GameObject;
            float x = Random.Range(-100, 100); //랜덤 생성 범위 지정
            float y = Random.Range(-100, 100);
            float z = Random.Range(-100, 100);
            enemy.transform.position = new Vector3(x, y, z);

        }
    }
}
