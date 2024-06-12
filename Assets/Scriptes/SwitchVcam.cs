using UnityEngine;
using UnityEngine.InputSystem;
using Cinemachine;

public class SwitchVcam : MonoBehaviour
{
   [SerializeField]
   private PlayerInput playerInput;
   [SerializeField]
   private int priorityBoostAmount = 10;
   [SerializeField]
   private Canvas ThirdPersonCanvas;
   [SerializeField]
   private Canvas AimCanvas;

   private CinemachineVirtualCamera virtualCamera;
   private InputAction aimAction;

   private void Awake() {
        virtualCamera = GetComponent<CinemachineVirtualCamera>();
        aimAction = playerInput.actions["Aim"];
   }

   private void OnEnable() {
        aimAction.performed +=_=> StartAim();
        aimAction.canceled +=_=> CancelAim();
   }

   private void OnDisable() {
        aimAction.performed -=_=> StartAim();
        aimAction.canceled -=_=> CancelAim();
   }

   private void StartAim() {
        virtualCamera.Priority += priorityBoostAmount;
        AimCanvas.enabled = true;
        ThirdPersonCanvas.enabled = false;
   }

    private void CancelAim() {
        virtualCamera.Priority -= priorityBoostAmount;
        AimCanvas.enabled = false;
        ThirdPersonCanvas.enabled = true;
   }
}
