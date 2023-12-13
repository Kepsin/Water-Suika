using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Combine : MonoBehaviour
{

    private int setInArray; //The number of the monster in the monsters list

    GameObject[] monsterList;

    void Start()
    {  
        monsterList = GetComponentInParent<PokeArray>().getMonsterList();
        for(int x = 0; x < monsterList.Length; x++) {
            if (monsterList[x].name.Equals(this.gameObject.name)) {
                setInArray = x;
            }
        }
        this.name = name.Replace("(Clone)","").Trim();
    }

    // Update is called once per frame
    void Update()
    {
    }

   void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.name.Equals(this.gameObject.name)) {
            if (gameObject.GetInstanceID() > col.gameObject.GetInstanceID()) {
                Destroy(col.gameObject);
                Destroy(this.gameObject);
                Instantiate(monsterList[setInArray+1], (this.transform.position + col.transform.position)/2, transform.rotation, transform.parent);
            }
        }
    }
}
