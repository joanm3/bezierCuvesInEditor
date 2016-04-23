using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class SnapToGrid : MonoBehaviour {

	public Vector3 gridUnit = Vector3.one; 

	void Update() {

		Vector3 position = transform.position; 
		position.x = Mathf.Round (position.x / gridUnit.x) * gridUnit.x; 
		position.y = Mathf.Round (position.y/ gridUnit.y) * gridUnit.y; 
		position.z = Mathf.Round (position.z/ gridUnit.z) * gridUnit.z; 
		transform.position = position; 
	}
}
