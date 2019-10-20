using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = 5f;
    public float deactivate_Time = 3f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DeactiveateGameObject", deactivate_Time);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        Vector3 temp = transform.position;
        temp.x += speed * Time.deltaTime;
        transform.position = temp;
    }

    void DeactiveateGameObject()
    {
        gameObject.SetActive(false);
    }
}
