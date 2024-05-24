using UnityEngine;
#if ENABLE_INPUT_SYSTEM
using UnityEngine.InputSystem;
#endif

namespace StarterAssets
{
	public class StarterAssetsInputs : MonoBehaviour
	{
		[Header("Character Input Values")]
		public Vector2 move;
		public Vector2 look;
		public bool jump;
		public bool sprint;

		[Header("Movement Settings")]
		public bool analogMovement;

		[Header("Mouse Cursor Settings")]
		public bool cursorLocked = true;
		public bool cursorInputForLook = true;

#if ENABLE_INPUT_SYSTEM

		
		


	private void Start(){
				audioSourceJump = PersonnageJump.GetComponent<AudioSource>();
				audioSourceRun = PersonnageRun.GetComponent<AudioSource>();
				audioSourceWalk = PersonnageWalk.GetComponent<AudioSource>();
			}


		
		[SerializeField] private GameObject PersonnageWalk;

		private AudioSource audioSourceWalk;

		public void OnMove(InputValue value)
		{
			MoveInput(value.Get<Vector2>());
			audioSourceWalk.Play(0);
		}

		public void OnLook(InputValue value)
		{
			if(cursorInputForLook)
			{
				LookInput(value.Get<Vector2>());
			}
		}
		
		[SerializeField] private GameObject PersonnageJump;

		private AudioSource audioSourceJump;
		
		public void OnJump(InputValue value)
		{
			JumpInput(value.isPressed);
			audioSourceJump.Play(0);
		}








		[SerializeField] private GameObject PersonnageRun;

		private AudioSource audioSourceRun;


		public void OnSprint(InputValue value)
		{
			SprintInput(value.isPressed);
			audioSourceRun.Play(0);
		}
#endif


		public void MoveInput(Vector2 newMoveDirection)
		{
			move = newMoveDirection;
		} 

		public void LookInput(Vector2 newLookDirection)
		{
			look = newLookDirection;
		}

		public void JumpInput(bool newJumpState)
		{
			jump = newJumpState;
		}

		public void SprintInput(bool newSprintState)
		{
			sprint = newSprintState;
		}
		
		private void OnApplicationFocus(bool hasFocus)
		{
			SetCursorState(cursorLocked);
		}

		private void SetCursorState(bool newState)
		{
			Cursor.lockState = newState ? CursorLockMode.Locked : CursorLockMode.None;
		}
	}
	
}