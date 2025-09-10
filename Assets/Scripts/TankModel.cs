using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankModel 
{
    private TankController tankController;
    public float RotationSpeed;
    public float MovementSpeed;
    public TankTypes TankType;
    public Material Color;
    public void SetController(TankController _tankController)
    {
        tankController = _tankController;
    }
    public TankModel(float movementSpeed, float rotationSpeed, TankTypes tankType, Material color) 
    { 
        MovementSpeed = movementSpeed;
        RotationSpeed = rotationSpeed;
        TankType = tankType;
        Color = color;
    }
}
