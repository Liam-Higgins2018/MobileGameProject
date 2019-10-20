using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public float speed = 5f;
    public float rotateSpeed = 50f;
    public bool canShoot;
    public bool canRotate;
    public float bound_X = -11f;
    public Transform attack_Point;
    public GameObject bullet;


    private bool canMove = true;
    private Animator anim;
    private AudioSource explosionSound;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        explosionSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
