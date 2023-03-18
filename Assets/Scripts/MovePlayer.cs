using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MovePlayer : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public PlayerController playerController; // Reference to the player controller script

    public enum Direction { Forward, Back, Left, Right };
    public Direction direction;

    //private bool isPressed = false;

    public void OnPointerDown(PointerEventData eventData)
    {
        //isPressed = true;

        switch (direction)
        {
            case Direction.Forward:
                playerController.MoveForward();
                break;
            case Direction.Back:
                playerController.MoveBack();
                break;
            case Direction.Left:
                playerController.MoveLeft();
                break;
            case Direction.Right:
                playerController.MoveRight();
                break;
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        //isPressed = false;

        switch (direction)
        {
            case Direction.Forward:
                playerController.StopForward();
                break;
            case Direction.Back:
                playerController.StopBack();
                break;
            case Direction.Left:
                playerController.StopLeft();
                break;
            case Direction.Right:
                playerController.StopRight();
                break;
        }
    }

    /*private void Update()
    {
        // If the button is still pressed, continue moving the player
        if (isPressed)
        {
            switch (direction)
            {
                case Direction.Forward:
                    playerController.MoveForward();
                    break;
                case Direction.Back:
                    playerController.MoveBack();
                    break;
                case Direction.Left:
                    playerController.MoveLeft();
                    break;
                case Direction.Right:
                    playerController.MoveRight();
                    break;
            }
        }
    }*/

}
