using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPollingScript : MonoBehaviour
{   
    public GameObject enemyPrefab;
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void initializeEnemy()
    {
        enemy = Instantiate(enemyPrefab, new Vector3(this.transform.position.x, this.transform.position.y,1f), Quaternion.identity);

    }

    public void destroyEnemy()
    {
        Destroy(enemy, 0);

    }
}
