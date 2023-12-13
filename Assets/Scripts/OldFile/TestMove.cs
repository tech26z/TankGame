using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMove : MonoBehaviour {

    //先找到对象（也可以通过组件找到对象），再找对象下的组件，再找组件里的属性和方法
    //还有很多回调函数，这里没有列出
    private void Awake()
    {
        //不管脚本可用不可用，都会调用
    }

    // Use this for initialization
    void Start () {

        //启动时运行一次
        //找到当前游戏对象,注意小写，gameObject的type 是GameObject
        Debug.Log(this.gameObject);
        //创建一个组件
        //GameObject myObject = new GameObject("myObeject");
        //通过名字找对象
        GameObject RedBox = GameObject.Find("Cube");
        RedBox.GetComponent<MeshRenderer>().material.color = Color.yellow;
        //通过Tag找对象
        GameObject redTag = GameObject.FindWithTag("redCubeTag");
        //如果找到了，改变颜色
        redTag.GetComponent<MeshRenderer>().material.color = Color.green;
        //找多个对象
        //GameObject[] monsters = GameObject.FindGameObjectsWithTag("...");
        //Debug.Log(monsters[0]);
	}
	
	// Update is called once per frame
	void Update () {

        //物体在世界坐标移动
        transform.position += new Vector3(1 * 0.01f, 0, 0);
	}

    private void LateUpdate()
    {
        //用于摄像机跟随，比Update延迟一会
    }

    private void OnEnable()
    {
        //整个游戏运行期间只运行一次
    }

    private void OnDisable()
    {
        //脚本不可用时执行一次
    }

    private void FixedUpdate()
    {
        //默认每0.02秒更新一次，可更改
    }

    private void OnGUI()
    {
        //旧版GUI，不可视化的界面开发,每帧大约执行两次，比Update快一倍
    }

    private void OnDestroy()
    {
        //对象销毁时执行一次
    }
}
