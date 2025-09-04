using UnityEditor;
using UnityEngine;

[DefaultExecutionOrder(5)]
public class Mesh : MonoBehaviour
{
	[SerializeField] Vertex[] vertices;
	[SerializeField] Face[] faces;
	Matrix4x4 MVP;
	Matrix4x4 TRS;



	void UpdateTRS()
	{
		//	Translation

		Matrix4x4 x = new Matrix4x4();
		Matrix4x4 y = new Matrix4x4();
		Matrix4x4 z = new Matrix4x4();

		//	Rotation

		//	Scale


	}


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

	private void Update()
	{
		
	}

	private void OnDrawGizmos()
	{
		DrawElements();
	}

	public void DrawElements()
	{
		if (vertices == null || vertices.Length == 0) return;
		if (faces == null || faces.Length == 0) return;

		for (int i = 0; i < faces.Length; i++)
		{
			Vector3 a = vertices[faces[i].index[0]].position;
			Vector3 b = vertices[faces[i].index[1]].position;
			Vector3 c = vertices[faces[i].index[2]].position;

			Vector3 offset = (Vector3.up + Vector3.right) * 0.025f;

			Handles.Label(a + offset, faces[i].index[0].ToString());
			Handles.Label(b + offset, faces[i].index[1].ToString());
			Handles.Label(c + offset, faces[i].index[2].ToString());


			Debug.DrawLine(a, b);
			Debug.DrawLine(b, c);
			Debug.DrawLine(c, a);
		}
	}
}
