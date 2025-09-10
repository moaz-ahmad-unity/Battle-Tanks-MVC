using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    private TankController tankController;

    [SerializeField] Rigidbody rigidbody;
    [SerializeField] MeshRenderer[] meshRenderers;
    float movement;
    float rotation;
    private void Start()
    {
        GameObject cam = GameObject.Find("Main Camera");
        cam.transform.SetParent(transform);
        cam.transform.position = new Vector3(0, 3f, -7f);
    }
    public void SetController(TankController _tankController)
    {
        tankController = _tankController;
    }
    public Rigidbody GetRigidbody()
    {
        return rigidbody;
    }
    private void Update()
    {
        if (tankController == null) return;
        ReadInput();

        if (movement > 0 || movement < 0)
        {
            tankController.Move(movement);
        }
        if (rotation > 0 || rotation < 0)
        {
            tankController.Rotate(rotation);
        }
    }
    public void ReadInput()
    {
        movement = Input.GetAxis("Vertical");
        rotation = Input.GetAxis("Horizontal");
    }
    public void ChangeColor(Material tankColor)
    {
        for (int i = 0; i < meshRenderers.Length; i++)
        {
            meshRenderers[i].material = tankColor;
        }
    }
}
