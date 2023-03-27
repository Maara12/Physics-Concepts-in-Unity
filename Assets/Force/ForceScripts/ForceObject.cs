using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceObject : MonoBehaviour
{
    [SerializeField]
    public float mass = 1f;

    [SerializeField]
    public float force = 5f;

    [SerializeField]
    public float acceleration;

    [SerializeField]
    float gravAcceleration = 9.81f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ApplyForce();
        }
        else
        {
            acceleration -= acceleration;
        }
        
    }

    public void ApplyForce()
    {
        acceleration = force / mass;
        Debug.Log("acceleration = " + acceleration);

        Accelerate(acceleration);
    }

    private void Accelerate(float acceleration)
    {
       
        Vector3 currentPos = gameObject.transform.position;
        gameObject.transform.position = currentPos + new Vector3(x:acceleration * Time.deltaTime ,
            y: 0f, z: 0f);

        Debug.Log($"Displacement = {gameObject.transform.position - currentPos }");

    }

    public void ApplyGravitationalForce(float gravForce)
    {
        acceleration = gravForce / mass;

        Vector3 currentPos = gameObject.transform.position;
        gameObject.transform.position = currentPos + new Vector3(x:0f,
            y:  -acceleration * Time.deltaTime, z: 0f);

        Debug.Log($" G-Displacement = {gameObject.transform.position - currentPos }");

       
    }

}
