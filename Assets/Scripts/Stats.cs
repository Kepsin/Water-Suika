using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{

    public int UserScore;
    // Start is called before the first frame update
    void Start()
    {
        UserScore = 0;
    }


    public int getUserScore() {
        return UserScore;
    }

    public void changeUserScore(int change) {
        UserScore += change;
    }
}
