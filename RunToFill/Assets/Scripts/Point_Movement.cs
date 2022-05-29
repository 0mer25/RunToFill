using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point_Movement : MonoBehaviour
{
    [SerializeField] public static float speed = 0.03f;
    private void Awake() 
    {
        
    }

    
    void Update()
    {
        transform.position = new Vector3(transform.position.x - speed , transform.position.y , transform.position.z);
    }
}
