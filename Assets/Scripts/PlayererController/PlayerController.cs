using UnityEngine;
using DG.Tweening;
//using UnityEngine.InputSystem;



public class PlayerController : MonoBehaviour
{
    float forwardVelocity = 0f;
    float verticalVelocity = 0f;

    [SerializeField] float forwardAcceleration = 1f;
    [SerializeField] float maxForwardVelocity = 10f;
    [SerializeField] float minForwardVelocity = 10f;

    //[SerializeField] InputActionReferences punch;

    [SerializeField] HitCollider hitColliderPunch;

    float gravity = -9.8f;


    CharacterController characterController;
    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }
    //private void OnEnable()
    //{
    //    punch.action.Enable();
    //    punch.action.performed += OnPunch;
    //}
    void Update()
    {
        if(forwardVelocity < minForwardVelocity)
        {
            forwardVelocity += forwardAcceleration * Time.deltaTime;

        }

        verticalVelocity += gravity * Time.deltaTime;
        if(characterController.isGrounded)
        {
            verticalVelocity = 0f;
        }
    }
    //private void OnDisable()
    //{
    //    punch.action.Disable();
    //    punch.action.performed += OnPunch;
    //}
    //void OnPunch(InputAction.CallbackContext context)
    //{
    //    hitColliderPunch.gameObject.SetActive(true);
    //    DOVirtual.DelayedCall(0.5f, () => hitColliderPunch.gameObject.SetActive(false));
    //}
}
