using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarConstroller : MonoBehaviour
{
    // ��]���x
    private float rotSpeed = 0.1f;

    // Start is called before the first frame update
    // Use this for initialization
    void Start()
    {
        //��]���J�n����p�x��ݒ�
        this.transform.Rotate(0, Random.Range(0, 360), 0);
    }

    // Update is called once per frame
    void Update()
    {
        //��]
        this.transform.Rotate(0, this.rotSpeed, 0);
    }
}