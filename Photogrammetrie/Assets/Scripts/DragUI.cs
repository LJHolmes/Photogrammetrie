using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragUI : MonoBehaviour
{
    public float rotationSpeed = 2f;

    [SerializeField] private GameObject Fishermans;

    [SerializeField] private bool rotateRight;
    [SerializeField] private bool rotateLeft;

    void Start()
    {
        Fishermans = GameObject.Find("Fishermans");
    }

    private void Update()
    {
        if (rotateRight)
        {
            Fishermans.transform.Rotate(Vector3.right, rotationSpeed, Space.World);
        }

        if (rotateLeft)
        {
            Fishermans.transform.Rotate(Vector3.left, rotationSpeed, Space.World);
        }
    }

    public void RotateOnButtonDownRight()
    {
        rotateRight = true;
    }

    public void RotateOnButtonDownLeft()
    {
        rotateLeft = true;
    }

    public void RotateOnButtonUp()
    {
        rotateLeft =  false;
        rotateRight = false;
    }
}
