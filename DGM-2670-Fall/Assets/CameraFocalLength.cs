using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraFocalLength : MonoBehaviour
{
    [SerializeField]
    float horizObl = 1f;
    [SerializeField]
    float vertObl = 1f;

    void SetObliqueness(float horizObl, float vertObl)
    {
        Matrix4x4 mat = Camera.main.projectionMatrix;
        mat[0, 2] = horizObl;
        mat[1, 2] = vertObl;
        Camera.main.projectionMatrix = mat;
    }
    public void Update()
    {
        SetObliqueness(1f, 1f);
    }
}