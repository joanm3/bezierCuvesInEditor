using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class BezierFollower : MonoBehaviour {


	public BezierCourve curve; 
	[Range (0,1)]
	public float t; 


	void Update() {

		transform.position = curve.GetPoint (t); 

	}


}
