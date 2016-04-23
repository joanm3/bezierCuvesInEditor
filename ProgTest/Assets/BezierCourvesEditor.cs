using UnityEngine;
using UnityEditor; 
using System.Collections;

[CustomEditor(typeof(BezierCourve))]
public class BezierCourvesEditor : Editor {


	void OnSceneGUI() {

		BezierCourve curve = target as BezierCourve;

		if (curve && curve.endPoints.Length == 2 && curve.tangentPoints.Length == 2) {

			for (int i = 0; i < 2; ++i) {
				curve.tangentPoints[i] = Handles.PositionHandle(curve.tangentPoints[i], Quaternion.identity);

				Vector3 offset = curve.tangentPoints [i] - curve.endPoints [i]; 

				curve.endPoints [i] = Handles.PositionHandle (curve.endPoints [i], Quaternion.identity); 

				curve.tangentPoints [i] = curve.endPoints [i] + offset; 
					

			}



		}
	
		Handles.DrawLine (curve.endPoints [0], curve.tangentPoints [0]); 
		Handles.DrawLine (curve.endPoints [1], curve.tangentPoints [1]); 

		Handles.DrawBezier(curve.endPoints[0], curve.endPoints[1], curve.tangentPoints[0], curve.tangentPoints[1], Color.red, null, 5.0f );
	//	for (int i = 0; i < curve.controlPoints.Length; i++)
	//		curve.controlPoints [i] = Handles.PositionHandle (curve.controlPoints [i], Quaternion.identity); 

	//	Handles.DrawLine (curve.controlPoints [0], curve.controlPoints [1]); 
	//	Handles.DrawLine (curve.controlPoints [2], curve.controlPoints [3]); 

//Handles.DrawBezier (curve.controlPoints [0], curve.controlPoints [3], curve.controlPoints [1], curve.controlPoints [2], Color.red, null, 5.0f);

	}
}
