using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArabaKontrol : MonoBehaviour
{
    public WheelCollider onSolCol;
    public WheelCollider onSagCol;
    public WheelCollider arkaSolCol;
    public WheelCollider arkaSagCol;

    public GameObject onSol;
    public GameObject onSag;
    public GameObject arkaSol;
    public GameObject arkaSag;

    public float MotorGucu;
    public float DonusAcisi;
    public float motor;
    public float frenGucu;
    

    void Start()
    {
        
    }

   
    void Update()
    {
        motor = MotorGucu * Input.GetAxis("Vertical");
        float donus = DonusAcisi * Input.GetAxis("Horizontal");
        float fren = frenGucu * Mathf.Abs(Input.GetAxis("Jump"));

     

        onSolCol.steerAngle = onSagCol.steerAngle = donus;

        if (fren < 0.05)
        {
            arkaSagCol.motorTorque = motor;
            arkaSolCol.motorTorque = motor;
            arkaSagCol.brakeTorque = 0;
            arkaSolCol.brakeTorque = 0;
        }
        else
        {
            arkaSagCol.brakeTorque = fren;
            arkaSolCol.brakeTorque = fren;
        }
          

        SanalTeker();
    }

    void SanalTeker()
    {
        Quaternion rot;
        Vector3 pos;
        onSolCol.GetWorldPose(out pos, out rot);
        onSol.transform.position = pos;
        onSol.transform.rotation = rot;

        onSagCol.GetWorldPose(out pos, out rot);
        onSag.transform.position = pos;
        onSag.transform.rotation = rot;

        arkaSolCol.GetWorldPose(out pos, out rot);
        arkaSol.transform.position = pos;
        arkaSol.transform.rotation = rot;

        arkaSagCol.GetWorldPose(out pos, out rot);
        arkaSag.transform.position = pos;
        arkaSag.transform.rotation = rot;

    }
}
