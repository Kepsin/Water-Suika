using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Combine : MonoBehaviour
{

    private int setInArray; //The number of the monster in the monsters list

    GameObject[] monsterList;
    Stats stats;
    GameObject temp;
    TMP_Text text;

    void Start()
    { 
        this.name = name.Replace("(Clone)","").Trim(); 
        monsterList = GetComponentInParent<PokeArray>().getMonsterList();
        stats = GameObject.Find("PokemonList").GetComponent<Stats>();
        text = GameObject.Find("Score").GetComponent<TMP_Text>();
        for(int x = 0; x < monsterList.Length; x++) {
            if (monsterList[x].name.Equals(this.gameObject.name)) {
                setInArray = x;
            }
        }
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
                temp = Instantiate(monsterList[setInArray+1], (this.transform.position + col.transform.position)/2, transform.rotation, transform.parent);
                temp.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                stats.changeUserScore(setInArray);
                text.text = "Score: " + (stats.getUserScore() + 1);

            }
        }
    }
}
