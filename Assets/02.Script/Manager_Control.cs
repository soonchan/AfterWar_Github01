using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager_Control : MonoBehaviour {

    public bool game = false;

	void Update () {
		
        if(game)
        {
            Vector3 tpos = Input.GetTouch(0).position;
            if(tpos.x <= Screen.width / 2) //왼쪽
            {
                // 공격
                // 드래그 확인
                if(true)
                {

                }
            }
            else if(tpos.x >= Screen.width / 2) //오른쪽
            {
                // 공격
                // 드래그 확인
                if (true)
                {

                }
            }
        }
	}
}
