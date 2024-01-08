//using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    GameObject[] monsterList;

    private Rigidbody2D player;

    private float horizontal;

    public GameObject top;
    public GameObject pokemon;
    public GameObject pokemonlist;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        monsterList = gameObject.GetComponent<PokeArray>().getMonsterList();
        pokemon = Instantiate(monsterList[Random.Range(0, 6)], top.transform.position, transform.rotation, top.transform);

    }

    void spawnNewPokemon() {
        pokemon = Instantiate(monsterList[Random.Range(0, 6)], top.transform.position, transform.rotation, top.transform);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonUp("Jump")) {
            
            pokemon.gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            pokemon.gameObject.transform.SetParent(pokemonlist.transform);
            Invoke("spawnNewPokemon", 1f);
        }

        horizontal = Input.GetAxis("Horizontal");

        player.transform.Translate(new Vector2(horizontal, 0) * 5 * Time.deltaTime);
        
    }
}
