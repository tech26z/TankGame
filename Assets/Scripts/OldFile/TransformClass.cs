using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformClass : MonoBehaviour {

    private void Awake()
    {
        //当前对象的世界坐标
        Debug.Log(transform.position);
        //当前对象的本地坐标（相对于父物体）
        Debug.Log(transform.localPosition);
        //当前对象的世界旋转(欧拉角）
        Debug.Log(transform.eulerAngles);
        //当前游戏对象的本地旋转（欧拉角）
        Debug.Log(transform.localEulerAngles);
        //当前对象的世界旋转（四元数）,面板显示的仍然是欧拉角度
        Debug.Log(transform.rotation);
        //当前对象的本地旋转（四元数），面板显示的仍然是欧拉角
        Debug.Log(transform.localRotation);
        //位置移动。V3是一个起始与原点的向量，但是向量只是为物体之时一个方向，
        //和在哪里无关，所以物体就从它目前的位置沿向量方向移动。
        //如果放在updae，就持续移动
        transform.Translate(new Vector3(0,1,0));
        //还可以
        transform.position += new Vector3(0, 1, 0);
        //每帧旋转2°，V3的本质是三个数，可代表任何物理意义
        //下面两种表达方法效果一样
        transform.eulerAngles += new Vector3(2, 0, 0);
        transform.Rotate(new Vector3(2, 0, 0));
        //绕转三个参数，点，轴，角度/每帧
        transform.RotateAround(new Vector3(3, 0, 0), 
            new Vector3(0, 1, 0), 2);

    }
    // Use this for initialization
    void Start () {
        GameObject player = GameObject.FindWithTag("Player");
        MeshRenderer playerMeshrender = player.GetComponent<MeshRenderer>();
        playerMeshrender.material.color = Color.yellow;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
