using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Transform cam;

    private Vector3 nowMousePos;
    private Vector3 lastMousePos;

    void Start()
    {

        lastMousePos = Input.mousePosition;

    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {

            lastMousePos = Input.mousePosition;

        }

        if (Input.GetMouseButton(0))
        {

            nowMousePos = Input.mousePosition;

            cam.position += cam.right * (lastMousePos.x - nowMousePos.x) * Time.deltaTime;
            cam.position += cam.up * (lastMousePos.y - nowMousePos.y) * Time.deltaTime;

            lastMousePos = Input.mousePosition;

        }

    }
}
