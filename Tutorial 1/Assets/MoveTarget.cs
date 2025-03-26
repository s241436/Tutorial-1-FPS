using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class VectorLerp : MonoBehaviour
{
    [SerializeField] int speed;
    [SerializeField] GameObject point1;
    [SerializeField] GameObject point2;

    int posIndex = 0;
    int length;

    GameObject targetPoint;
    [SerializeField] GameObject transformObject;

    private void Start()
    {
        targetPoint = point1;
    }

    private void Update()
    {

        
        transformObject.transform.position = Vector3.Lerp(transformObject.transform.position, targetPoint.transform.position, speed * Time.deltaTime);

        if ((transformObject.transform.position - targetPoint.transform.position).magnitude <= 0.01f)
        {
            if (targetPoint == point1)
            {
                targetPoint = point2;
            }
            else
            {
                targetPoint = point1;
            }
        }
    }



}
