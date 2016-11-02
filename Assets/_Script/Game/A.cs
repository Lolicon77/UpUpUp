using UnityEngine;
using System.Collections;

namespace Test
{
	public class A : MonoBehaviour
	{
		public void DebugA() {
			Debug.Log("DebugA");
		}

		void OnDestroy() {
			Debug.LogError("destroy");
		}
	}
}