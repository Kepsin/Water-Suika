using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokeArray : MonoBehaviour
{

    public GameObject[] Monsters;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject[] getMonsterList() {
        return Monsters;
    }
}
