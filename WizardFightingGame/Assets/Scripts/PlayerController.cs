using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region Public Definitions
    public const string xaxis = "Horizontal";
    public const string zaxis = "Vertical";
    #endregion

    #region Variables
    CharacterController characterController;

    Vector3 movement = Vector3.zero;

    float x = 0f;
    float y = 0f;
    float z = 0f;
    #endregion

    #region Serialized Variables
    [SerializeField]
    float movementSpeed = 1f;
    float gravityStr = 1f;
    float runSpeed = 1f;
    #endregion


    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis(xaxis);
        z = Input.GetAxis(zaxis);

        movement = new Vector3(x, 0, z);
    }

    void jumpMechanics()
    {

    }
}
