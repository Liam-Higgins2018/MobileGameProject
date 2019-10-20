using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;

    public float min_Y, max_Y;

    [SerializeField]
    private GameObject Player_Bullet;

    [SerializeField]
    private Transform attack_Point;

    public float attack_Timer = 1f;
    private float current_Attack_Timer;
    private bool attack_On;

    // Start is called before the first frame update
    void Start()
    {
        current_Attack_Timer = attack_Timer;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Shoot();
    }

    void Move()
    {
        if(Input.GetAxisRaw("Vertical") > 0f)
        {
            Vector3 temp = transform.position;
            temp.y += speed * Time.deltaTime;

            if(temp.y > max_Y)
                temp.y = max_Y;

            transform.position = temp;
        }
        else if(Input.GetAxisRaw("Vertical") < 0f)
        {
            Vector3 temp = transform.position;
            temp.y -= speed * Time.deltaTime;

            if(temp.y < min_Y)
                temp.y = min_Y;
            
            transform.position = temp;
        }
    }

    void Shoot()
    {
       attack_Timer += Time.deltaTime;

       if(attack_Timer > current_Attack_Timer)
       {
           attack_On = true;
       }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(attack_On)
            {
                attack_On = false;
                attack_Timer = 0f;
                Instantiate(Player_Bullet, attack_Point.position, Quaternion.identity);

                //play sound FX
            }
        }
    }
}
