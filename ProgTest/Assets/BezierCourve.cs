using UnityEngine;
using UnityEditor; 

public class BezierCourve : MonoBehaviour {

	//public Vector3[] controlPoints = new Vector3[4]; 

	public Vector3[] endPoints = new Vector3[2];
	public Vector3[] tangentPoints = new Vector3[2]; 

	public Vector3 GetPoint(float t) {

		return (1 - t) * (1 - t) * (1 - t) * endPoints [0] +
		3 * (1 - t) * (1 - t) * t * tangentPoints [0] +
		3 * (1 - t) * t * t * tangentPoints [1] +
		t * t * t * endPoints [1]; 
	}

}
