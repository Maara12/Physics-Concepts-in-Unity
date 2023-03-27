using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthGravityObject : MonoBehaviour
{

    [SerializeField]
    float gravAcceleration = 9.81f;

    [SerializeField]
    float GravForce;

    [SerializeField]
    ForceObject objectToAttract;

    [SerializeField]
    List<ForceObject> allObjectsToAttract;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftShift))
        {
            foreach (ForceObject forceObject in allObjectsToAttract)
            {
                Attract(forceObject);
            }
            
        }
    }

    public void Attract(ForceObject objToAttract)
    {
        GravForce = objToAttract.mass * gravAcceleration;
        objToAttract.ApplyGravitationalForce(GravForce);
        
    }
}
