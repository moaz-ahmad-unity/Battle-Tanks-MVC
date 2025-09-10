using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [System.Serializable]
    public class Tank
    {
        public float MovementSpeed;
        public float RotationSpeed;
        public TankTypes tankType;
        public Material tankColor;
    }
    public TankView TankPrefab;
    public List<Tank> tanks;

    public void CreateTank(TankTypes tankType)
    {
        TankModel tankModel = new TankModel(tanks[0].MovementSpeed, tanks[0].RotationSpeed, tanks[0].tankType, tanks[0].tankColor);
        TankView tankView = GameObject.Instantiate<TankView>(TankPrefab);
        switch (tankType)
        {
            case TankTypes.GreenTank:
                tankModel = new TankModel(tanks[0].MovementSpeed, tanks[0].RotationSpeed, tanks[0].tankType, tanks[0].tankColor);
                break;
            case TankTypes.BlueTank:
                tankModel = new TankModel(tanks[1].MovementSpeed, tanks[1].RotationSpeed, tanks[1].tankType, tanks[1].tankColor);
                break;
            case TankTypes.RedTank:
                tankModel = new TankModel(tanks[2].MovementSpeed, tanks[2].RotationSpeed, tanks[2].tankType, tanks[2].tankColor);
                break;
        }
        TankController tankController = new TankController(tankView, tankModel);
    }

}
