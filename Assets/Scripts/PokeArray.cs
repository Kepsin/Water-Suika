using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokeArray : MonoBehaviour
{

    public GameObject[] Monsters;

    public GameObject[] getMonsterList() {
        return Monsters;
    }
}
