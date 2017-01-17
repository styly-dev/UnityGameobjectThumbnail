using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeThumbnailTest : MonoBehaviour {

    //サムネイルを作成するオブジェクト
    public GameObject TargetObject;

    // Use this for initialization
    void Start()
    {
        //サムネイル作成
        GameObject unit = Instantiate(TargetObject, Vector3.zero, Quaternion.identity) as GameObject;
        UnityGameobjectThumbnail.makeThumbnailPng_from_Gameobject(unit, "c:/temp/temp1.png", 2300, 2300);
    }

}
