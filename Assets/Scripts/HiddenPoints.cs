using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenPoints : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyPrefab;
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
           
            Instantiate(enemyPrefab,enemyPrefab.transform.position+new Vector3(Random.Range(-1.6f,2.1f),0,0),Quaternion.identity);
            
        }
        
    }


}
