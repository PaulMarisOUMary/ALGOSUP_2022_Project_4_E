using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ResetPos : MonoBehaviour
{

    public InputActionReference resetButtonReference;

    private Vector3 originalPosition;
    private Quaternion originalRotation;

    private void Awake()
    {
        originalPosition = transform.position;
        originalRotation = transform.rotation;
        resetButtonReference.action.started += ResetPosition;
    }

	private void OnDestroy() {
        resetButtonReference.action.started -= ResetPosition;
    }

	void ResetPosition(InputAction.CallbackContext context)
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            transform.position = originalPosition;
            transform.rotation = originalRotation;
        }
    }
}
