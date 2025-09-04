using UnityEngine;

public class VirtualScene : MonoBehaviour
{
    [SerializeField] Mesh[] virtualMeshes;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DrawScene();
    }

    public void DrawScene()
    {
        foreach (Mesh mesh in virtualMeshes)
        {
            mesh.DrawElements();
        }
    }
}
