using UnityEngine;

[DefaultExecutionOrder(0)]
public class VirtualCamera : MonoBehaviour
{
	public static VirtualCamera Instance;
    Camera _camera;
	[SerializeField] VirtualScreen projection;
	[SerializeField] Mesh[] sceneMeshes;



	private void Awake()
	{
		_camera = GetComponent<Camera>();
		Instance = this;
	}

	private void Update()
	{
		
	}

	public void Draw()
	{

	}
}
