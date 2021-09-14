using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GlassesMov : MonoBehaviour
{
	public bool millora = false;
	public float visionRangeMovement = 45;
	private float rotZ = 0;
	public Transform player;
	private Inputs input;
	private GameObject inputsAndButtons;
	private Vector2 moveJoystick, moveMouse;
	private bool savedImprovement = false;
	private Quaternion lastMove = Quaternion.Euler(0f, 0f, 0f);
	private float reverseAngle = 0, reverseAngleNegative = 0;

	private void Awake()
	{
		inputsAndButtons = GameObject.Find("InputsAndButtons");
		input = inputsAndButtons.GetComponent<Inputs>();
	}

	void Update()
	{
		if (ButtonsManager.paused) return;
		if (input.isMouseKeyboard())
		{
			mouseMove();
		}
		else
		{
			joystickMove();
		}


	}

	/* ****************** MOV GLASSES WITH JOYSTICK****************** */
	public void  joystickMove()
	{
		moveJoystick = input.getMoveJoystick();

		if (moveJoystick == Vector2.zero)                                              //No mueve Joystick
		{
			transform.rotation = lastMove;
			return;
		}

		//Angle
		rotZ = Mathf.Atan2(moveJoystick.y, moveJoystick.x) * Mathf.Rad2Deg;
		if (!millora)
		{
			reverseAngle = 180 - visionRangeMovement;
			reverseAngleNegative = -180 + visionRangeMovement;
			//Joystick control
			if (rotZ > visionRangeMovement && rotZ < visionRangeMovement * 2) rotZ = visionRangeMovement;             //Joystick arriba derecha
			else if (rotZ < -visionRangeMovement && rotZ > -visionRangeMovement * 2) rotZ = -visionRangeMovement;     //Joystick abajo derecha
			else if (rotZ < reverseAngle && rotZ > visionRangeMovement * 2) rotZ = reverseAngle;                      //Joystick arriba izquierda
			else if (rotZ > reverseAngleNegative && rotZ < -visionRangeMovement * 2) rotZ = reverseAngleNegative;     //Joystick arriba izquierda
		}

		if (!millora)
		{
			//Flip glasses
			if (player.transform.rotation.y == 0)
			{
				transform.rotation = Quaternion.Euler(0f, 0f, rotZ);
				
			}
			else
			{
				
				transform.rotation = Quaternion.Euler(0f, 180f, rotZ);
			}
		}
		else
		{
			transform.rotation = Quaternion.Euler(0f, 0f, rotZ);
		}

		lastMove = transform.rotation;												//Si no mueve el Joystick
	}
	/* ****************** MOV GLASSES WITH MOUSE ****************** */
	public void mouseMove()
	{
		moveMouse = input.getMoveMouse();

		if(moveMouse == Vector2.zero)												//No mueve raton
		{
			transform.rotation = lastMove;
			return;
		}

		var projectedMousePosition = Camera.main.ScreenToWorldPoint(moveMouse);

		//Mouse position - Player's perspective
		Vector3 difference = projectedMousePosition - transform.position;
		
		//Angle
		rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;

		if (!millora)
		{
			reverseAngle = 180 - visionRangeMovement;
			reverseAngleNegative = -180 + visionRangeMovement;
			//Mouse control
			if (rotZ > visionRangeMovement && rotZ < visionRangeMovement * 2) rotZ = visionRangeMovement;			  //Mouse arriba derecha
			else if (rotZ < -visionRangeMovement && rotZ > -visionRangeMovement * 2) rotZ = -visionRangeMovement;	  //Mouse abajo derecha
			else if (rotZ < reverseAngle && rotZ > visionRangeMovement * 2) rotZ = reverseAngle;                      //Mouse arriba izquierda
			else if (rotZ > reverseAngleNegative && rotZ < -visionRangeMovement * 2) rotZ = reverseAngleNegative;     //Mouse arriba izquierda
		}

		if (!millora)
		{
			//Flip glasses
			if (player.transform.rotation.y == 0)
			{
				transform.rotation = Quaternion.Euler(0f, 0f, rotZ);
				
			}
			else 
			{
				transform.rotation = Quaternion.Euler(0f, 180f, rotZ);
				
			} 
			
		}
		else
		{
			transform.rotation = Quaternion.Euler(0f, 0f, rotZ);

			
		}
		lastMove = transform.rotation;												//Si no mueve el raton
	}
	public float getRotz()
	{
		return rotZ;
	}
	public void setMillora()
	{
		millora = true;
	}
	public void loseImprovement()
	{
		millora = false;
	}
	public bool isImproved()
	{
		return millora;
	}
	public void saveImprovement()
	{
		savedImprovement = true;
	}
	public bool isSavedImprove()
	{
		return savedImprovement;
	}

	public void SetActiveGlasses()
    {
		gameObject.SetActive(true);
    }

}


