using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarConstroller : MonoBehaviour
{
    // 回転速度
    private float rotSpeed = 0.1f;

    // Start is called before the first frame update
    // Use this for initialization
    void Start()
    {
        //回転を開始する角度を設定
        this.transform.Rotate(0, Random.Range(0, 360), 0);
    }

    // Update is called once per frame
    void Update()
    {
        //回転
        this.transform.Rotate(0, this.rotSpeed, 0);
    }
}
