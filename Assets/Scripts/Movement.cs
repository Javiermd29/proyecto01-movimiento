using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private GameObject camera;

    [SerializeField] private float speed = 10f;
    [SerializeField] private float verticalSpeed = 5f;
    [SerializeField] private float lateralSpeed = 5f;

    [SerializeField] private Vector3 offset = new Vector3(0, 20, -10);

    private float verticalInput;
    private float horizontalInput;
    


    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        // Moviemiento hacia delante
        transform.Translate(Vector3.forward * verticalSpeed * Time.deltaTime * verticalInput);

        // Movimiento lateral afectado por el input
        transform.Translate(Vector3.right * lateralSpeed * Time.deltaTime * horizontalInput);

        // Posicionar la cámara en el objeto
        camera.transform.position = transform.position + offset;

        //ROTATE EN Y

    }
}
