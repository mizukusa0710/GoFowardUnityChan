using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    //キューブの移動速度
    private float speed = -12;
    //消滅位置
    private float deadLine = -10;

    //定数値が必要なためconstを入れた？
   
    private const string P = "ground";
    private const string Q = "Cube";


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //キューブを移動させる
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        //画面外に出たら破棄する
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
