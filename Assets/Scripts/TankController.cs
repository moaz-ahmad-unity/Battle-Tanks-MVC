using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour
{
    TankView tankView;
    TankModel tankModel;

    public TankController(TankView _tankView, TankModel _tankModel)
    {
        tankModel = _tankModel;
        tankView = _tankView;

        GameObject.Instantiate(_tankView.gameObject);

        _tankView.SetController(this);
        _tankModel.SetController(this);
    }
}
