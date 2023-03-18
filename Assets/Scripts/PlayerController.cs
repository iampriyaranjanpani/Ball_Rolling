using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 150f;
    private Rigidbody rb;
    private bool isForwardBtPressed;
    private bool isBackwardBtPressed;
    private bool isRightBtPressed;
    private bool isLeftBtPressed;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        if(isForwardBtPressed) rb.AddForce(Vector3.forward*speed,ForceMode.Force);

        if(isBackwardBtPressed) rb.AddForce(Vector3.back*speed, ForceMode.Force);

        if(isRightBtPressed) rb.AddForce(Vector3.right*speed, ForceMode.Force);

        if (isLeftBtPressed) rb.AddForce(Vector3.left*speed, ForceMode.Force);

        //WASD movement for convinence purpose

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // calculate the movement vector
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput);

        // apply the movement force to the object
        GetComponent<Rigidbody>().AddForce(movement * speed);


    }
    public void MoveForward()
    {
        isForwardBtPressed = true;
    }

    public void StopForward()
    {
        isForwardBtPressed = false; ;
    }
    public void MoveBack()
    {
        isBackwardBtPressed = true;
    }

    public void StopBack()
    {
        isBackwardBtPressed = false; ;
    }
    public void MoveRight()
    {
        isRightBtPressed = true;
    }

    public void StopRight()
    {
        isRightBtPressed = false; ;
    }

    public void MoveLeft()
    {
        isLeftBtPressed = true;
    }

    public void StopLeft()
    {
        isLeftBtPressed = false; ;
    }

}

