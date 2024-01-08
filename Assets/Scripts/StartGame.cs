using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public Canvas menu;
    public GameObject bucket;
    // Start is called before the first frame update
    void Start()
    {
        bucket.SetActive(false);
    }

    public void onPlayButtonPress() {
        menu.enabled = false;
        bucket.SetActive(true);

    }
}
