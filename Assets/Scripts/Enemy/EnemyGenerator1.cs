using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator1 : MonoBehaviour
{
    public GameObject enemyfab;
    float EnemyCount = 0;
    public float span = 2.0f;
    float delta = 0;

    void Update()
    {
            this.delta += Time.deltaTime;
        if (EnemyCount <= 5)
        {
            if (this.delta > this.span)
            {
                this.delta = 0;
                GameObject enemy = Instantiate(enemyfab) as GameObject;
                float x = Random.Range(-100, 100); //랜덤 생성 범위 지정
                float y = Random.Range(-40, 100);
                float z = Random.Range(-100, 100);
                enemy.transform.position = new Vector3(x, y, z);

            }
        }
    }
}
