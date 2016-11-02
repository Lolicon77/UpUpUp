﻿using UnityEngine;
using System.Collections;

namespace L7 {

	public class EnableGameObjectDelay : MonoBehaviour {

		public float time;

		public GameObject[] gameObjects;

		// Use this for initialization
		IEnumerator Start() {
			yield return new WaitForSeconds(time);
			foreach (var go in gameObjects) {
				go.SetActive(true);
			}
		}
	}

}
