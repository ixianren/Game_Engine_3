using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawline : MonoBehaviour
{
    [SerializeField]
    private Transform[] spheres;
    private LineRenderer Line;
    // Start is called before the first frame update
    void Start()
    {
        Line = GetComponent<LineRenderer>();
        Line.material = new Material(Shader.Find("Sprites/Default"));
        Line.startWidth = 0.3f;
        Line.endWidth = 0.3f;
        //Line.material.color = Color.green;
        Line.startColor = Color.green;
        Line.endColor = Color.green;
        Line.positionCount = spheres.Length;
    }

    // Update is called once per frame
    void Update()
    {
        Line.SetPosition(0, spheres[0].position);
        Line.SetPosition(1, spheres[1].position);
        Line.SetPosition(2, spheres[2].position);
        Line.SetPosition(3, spheres[3].position);
    }
}
