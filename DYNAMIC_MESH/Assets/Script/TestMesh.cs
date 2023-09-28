using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMesh : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private int width = 10;
    [SerializeField]
    private int height = 20;
    //chieu nganh 10 lan tilesize
    //chieu doc 20 lan tilesize
    [SerializeField]
    private int tilesize = 5;
    private void Start()
    {
        
        Mesh mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;
        //mesh.vertices
        Vector3[] vertices = new Vector3[4];
        vertices[0] = new Vector3 (0.0f, 0.0f, 0.0f);
        vertices[1] = new Vector3(0.0f, 10.0f, 0.0f);
        vertices[2] = new Vector3(10.0f, 10.0f, 0.0f);
        vertices[3] = new Vector3(10.0f, 0.0f, 0.0f);
        //--------------------------------------------
        //mesh.uv
        Vector2[] uv = new Vector2[4];
        uv[0] = new Vector2(0.0f, 0.0f);
        uv[1] = new Vector2(0.0f, 1.0f);
        uv[2] = new Vector2(1.0f, 1.0f);
        uv[3] = new Vector2(1.0f, 0.0f);
        //--------------------------------------------
        //mesh.triangles
        //move in clockwise direction
        //most case
        //number triangles is multiple of 3
        int[] triangles = new int[6];
        triangles[0] = 0;
        triangles[1] = 1;
        triangles[2] = 2;
        triangles[3] = 0;
        triangles[4] = 2;
        triangles[5] = 3;
        //--------------------------------------------
        mesh.vertices = vertices;
        mesh.uv = uv;
        mesh.triangles = triangles;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
