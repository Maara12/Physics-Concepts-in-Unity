using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*Concepts
--> 1. Gravitational Acceleration (g = 9.81 ms^-2) is same for all objects, meaning
        any object that is falling in earth, will have the same acceleration (g) regardless of
        its mass.
--> 2. Newton's 2nd law, (F = ma), meaning, the net force on an object is equal
        to its mass times acceleration.
we are going to implement and experiment this concept in unity.
*/
public class ForceEqualsMA : MonoBehaviour
{
    [SerializeField]
    float force = 0;
    [SerializeField]
    float mass = 0;
    [SerializeField]
    float acceleration = 0;

    

    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CalculateForce(mass,acceleration);
        //CalculateMass(force,acceleration);
        //CalculateAcceleration(force,mass);
    }

    public void CalculateForce(float mass, float acceleration)
    {
        force = mass * acceleration;
        Debug.Log("force = " + force);
    }
    public void CalculateMass(float force, float acceleration)
    {
        mass = force / acceleration;
        Debug.Log(" mass = " + mass);
    }
    public void CalculateAcceleration(float force,float mass)
    {
        acceleration = force/mass;
        Debug.Log("acceleration = " + acceleration);
    }
}
