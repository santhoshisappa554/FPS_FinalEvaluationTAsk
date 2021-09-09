using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGunController : MonoBehaviour
{
    PlayerController player;
    [SerializeField]
    private GameObject FirePoint;
   
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            
                if (Input.GetMouseButtonDown(0))
                {
                    FireGun();
                }
           
        }
    }

    public void FireGun()
    {
        Debug.DrawRay(FirePoint.transform.position, FirePoint.transform.forward * 30.0f, Color.blue, 1.0f);
        Ray ray = new Ray(FirePoint.transform.position, FirePoint.transform.forward);
        RaycastHit hit;
        if(Physics.Raycast(ray,out hit, 100))
        {
            print(hit.collider.gameObject.name);
        }
    }
}
