using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locomotion2D : MonoBehaviour, ILocomotion
{
    [SerializeField] float movementSpeed;

    float horizontal;
    float vertical;

    public float Horizontal
    {
        get
        {
            return horizontal;
        }
        set
        {
            horizontal = value;
        }
    }
    public float Vertical
    {
        get
        {
            return vertical;
        }
        set
        {
            vertical = value;
        }
    }

    void Update()
    {
        transform.Translate(horizontal * movementSpeed * Time.deltaTime, vertical * movementSpeed * Time.deltaTime, 0);
    }
}
