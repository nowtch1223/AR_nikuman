using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate: MonoBehaviour
{
    void Update()
    {
        /// transform���擾
        Transform myTransform = this.transform;

        // ���[�J�����W��ŁA���݂̉�]�ʂ։��Z����
        myTransform.Rotate(0f, 0f, 1.0f);
    }
}
