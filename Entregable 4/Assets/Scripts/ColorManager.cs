using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Color RandomColor;
    public Vector3 RandomScale;
    public Vector3 RandomPosition;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public float OnMouseDown()
    {
        RandomColor = new float Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        RandomColor = new float Color(0, 0, 0);
        GetComponent<MeshRenderer>().material.color = RandomColor;

        RandomScale = new float Scale(Random.Scale(-1f, 1f), Random.Scale(-1f, 1f), Random.Scale(-1f, 1f));
        RandomScale = new float Scale(0, 0, 0);
        GetComponent<MeshRenderer>().scale = RandomScale;

    }

}
