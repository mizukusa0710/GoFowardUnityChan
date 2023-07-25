using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    //�L���[�u�̈ړ����x
    private float speed = -12;
    //���ňʒu
    private float deadLine = -10;

    //�萔�l���K�v�Ȃ���const����ꂽ�H
   
    private const string P = "ground";
    private const string Q = "Cube";


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //�L���[�u���ړ�������
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        //��ʊO�ɏo����j������
        if(transform.position.x < this.deadLine)
        {
            Destroy(this.gameObject);
        }
    }



    void OnCollisionEnter2D(Collision2D other)
    {
        switch (other.gameObject.tag)
        {
            case P:
            case Q:
                GetComponent<AudioSource>().Play();
                break;
        } 

        Debug.Log("OnCollisionEnter2D: " + other.gameObject.tag);
    }

}
