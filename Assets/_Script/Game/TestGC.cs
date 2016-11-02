using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Test;

public class TestGC : MonoBehaviour {

	List<int> list = new List<int>();
	private int[] array = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
	private int a;

	public A testA;

	void Awake() {
		for (int i = 0; i < 10; i++) {
			list.Add(i);
		}
	}

	// Use this for initialization
	IEnumerator Start() {

		//		Debug.Log("Log");
		//		Debug.LogWarning("LogWarning");
		//		Debug.LogError("LogError");
		//		for (int i = 0; i < 10; i++) {
		//			a = list[i];
		//		}
		//		foreach (var i in list) {
		//			a = i;
		//		}

		for (int i = 0; i < 10; i++) {
			testA.DebugA();
			if (i == 2) {
				Destroy(testA.gameObject);
			}
			yield return null;
		}

		list.RemoveAll((x) => {
			if (x > 1) {
				return true;
			}
			return false;
		});
		Debug.Log(list.Count);
	}


	// Update is called once per frame
	void Update() {
		testA.DebugA();
	}

	void OnApplicationFocus(bool isFocus) {
		//		if (isFocus) {
		//			Debug.Log("返回到游戏 刷新用户数据");  //  返回游戏的时候触发     执行顺序 2             
		//		} else {
		//			Debug.Log("离开游戏 激活推送");  //  返回游戏的时候触发     执行顺序 1  
		//		}
	}

	void OnApplicationPause(bool isPause) {
		//		if (isPause) {
		//			Debug.Log("游戏暂停 一切停止");  // 缩到桌面的时候触发  
		//		} else {
		//			Debug.Log("游戏开始  万物生机");  //回到游戏的时候触发 最晚  
		//		}
	}

}

