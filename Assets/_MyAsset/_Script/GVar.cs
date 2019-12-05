using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GVar : MonoBehaviour {
    public static bool isWin = false;
    public static int Lives = 3;
    // Use this for initialization
    void Start () {
        isWin = false;
        Lives = 3;
    }
}
