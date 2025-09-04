using UnityEngine;

public class VirtualScreen : MonoBehaviour
{
    [SerializeField] int width = 512, height = 512;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

	private void OnValidate()
	{
		float aspect = (float)width / height;
		transform.localScale = new Vector3(aspect, 1, 1);
	}
}
