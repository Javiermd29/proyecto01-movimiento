using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private GameObject camera;

    [SerializeField] private float speed = 10f;
    [SerializeField] private float verticalSpeed = 5f;
    [SerializeField] private float lateralSpeed = 5f;

    public int lifes = 5;

    [SerializeField] private Vector3 offset = new Vector3(0, 20, -10);

    private float verticalInput;
    private float horizontalInput;

    private GameManager gameManager;
    private UIManager uiManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        uiManager = FindObjectOfType<UIManager>();
    }


    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        // Moviemiento hacia delante
        transform.Translate(Vector3.forward * verticalSpeed * Time.deltaTime * verticalInput);

        // Movimiento lateral afectado por el input
        // transform.Translate(Vector3.right * lateralSpeed * Time.deltaTime * horizontalInput);

        transform.Rotate(Vector3.up, lateralSpeed * Time.deltaTime * horizontalInput);

        // Posicionar la cámara en el objeto
        // camera.transform.position = transform.position + offset;

        if (transform.position.y < -10)
        {
            transform.position = new Vector3(0, -0.03f, transform.position.z);
            transform.rotation = Quaternion.identity;
            lifes--;

            UpdateLifes(lifes);

        }

        if (transform.position.z > 241)
        {
            uiManager.ShowWinPanel(lifes);
        }

    }

    public void UpdateLifes(int newLifes)
    {

        uiManager.UpdateLifesText(lifes);

        if (newLifes == 0)
        {
            //isGameOver = true;
            uiManager.ShowGameOverPanel();

        }

    }

}
