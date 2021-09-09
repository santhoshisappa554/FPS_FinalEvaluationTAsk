using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;
    [SerializeField]
    private CharacterController character;
    Vector3 moveinput;
    [SerializeField]
    private Transform cameraTransform;
    [SerializeField]
    private float mouseSenstivity;
    [SerializeField]
    private bool invertX, invertY;
    Vector2 mouseInput;
    private float gravity=9.81f;
    public LayerMask groundMask;
    [SerializeField]
    private GameObject Weapon;
    bool weaponActive = false;

    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      

        Vector3 horiMove = transform.right * Input.GetAxis("Horizontal");
        Vector3 verMove = transform.forward * Input.GetAxis("Vertical");
        moveinput = horiMove + verMove;
        moveinput *= moveSpeed;
      
        moveinput.y += Physics.gravity.y * gravity * Time.deltaTime;

        character.Move(moveinput * Time.deltaTime);
        //camera rotation using mouseinput
        mouseInput = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y")) * mouseSenstivity;
        if (invertX)
        {
            mouseInput.x = -mouseInput.x;
        }
        if (invertY)
        {
            mouseInput.y = -mouseInput.y;
        }
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y + mouseInput.x, transform.rotation.eulerAngles.z);


        //camera rotation
        cameraTransform.rotation = Quaternion.Euler(cameraTransform.rotation.eulerAngles + new Vector3(mouseInput.y, 0, 0));

        if (Input.GetKeyDown(KeyCode.G))
        {
            Weapon.SetActive(true);
            weaponActive = true;
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject.name);
    }


}
