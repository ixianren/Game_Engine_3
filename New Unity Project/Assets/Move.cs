using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float limit;
    public float speed;
    int intFlag = 1;
    // Update is called once per frame
    void Update()
    {
        //当Z轴位置大于limit的时候就向负方向移动
        if (transform.position.z >= limit)
        {
            intFlag = -1;
        }
        //当Z轴位置小于-limit的时候就向正方向移动
        if (transform.position.z < -limit)
        {
            intFlag = 1;
        }

        transform.Translate(new Vector3(0, 0, intFlag) * Time.deltaTime * speed);
    }
}
