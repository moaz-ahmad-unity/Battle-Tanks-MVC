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
    public void Start()
    {
        CreateTank();
    }

    public void CreateTank()
    {
        TankModel tankModel = new TankModel(tanks[0].MovementSpeed, tanks[0].RotationSpeed, tanks[0].tankType, tanks[0].tankColor);
        TankView tankView = GameObject.Instantiate<TankView>(TankPrefab);
        TankController tankController = new TankController(tankView, tankModel);
    }
}
