using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TankController
{
    TankView tankView;
    TankModel tankModel;


    Rigidbody rb;
    public TankController(TankView _tankView, TankModel _tankModel)
    {
        tankModel = _tankModel;
        tankView = _tankView;
        rb = tankView.GetRigidbody();

        tankView.SetController(this);
        tankView.ChangeColor(tankModel.Color);
        tankModel.SetController(this);
    }

    public void Move(float movement)
    {
        rb.velocity = tankView.transform.forward * movement * tankModel.MovementSpeed;
    }
    public void Rotate(float rotation)
    {
        Vector3 vector = new Vector3(0, rotation * tankModel.RotationSpeed * Time.deltaTime, 0);
        Quaternion delataRotation = Quaternion.Euler(vector);
        rb.MoveRotation(rb.rotation * delataRotation);
    }
    public TankModel GetTankModel()
    {
        return tankModel;
    }
}
