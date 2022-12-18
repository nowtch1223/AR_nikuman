using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate: MonoBehaviour
{
    void Update()
    {
        /// transformを取得
        Transform myTransform = this.transform;

        // ローカル座標基準で、現在の回転量へ加算する
        myTransform.Rotate(0f, 0f, 1.0f);
    }
}
