using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyShoot : MonoBehaviour
{
    //[SerializeField]
    //private GameObject player;
    [SerializeField]
    private float enemymoveSpeed;
    Animator anim;
    NavMeshAgent agent;
    [SerializeField]
    private GameObject FirePoint;

    void Start()
    {
        anim = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        //transform.LookAt(player.transform.position);
        FireGun();

    }
    public void FireGun()
    {
        Debug.DrawRay(FirePoint.transform.position, FirePoint.transform.right * 10.0f, Color.red, 1.0f);
        Ray ray = new Ray(FirePoint.transform.position, FirePoint.transform.right);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 10))
        {
            print(hit.collider.gameObject.name);
        }
    }

}
