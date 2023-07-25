using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerControl : MonoBehaviour
{
    [SerializeField] InputAction Movement;
    // Start is called before the first frame update
    void Start()
    {
        
    }
      private void OnEnable()
       {
        Movement.Enable();

     }
      private void OnDisable() {
        Movement.Disable();
      }

    // Update is called once per frame
    void Update()
    {
        float HorizontalThrow = Movement.ReadValue<Vector2>().x;
        Debug.Log(HorizontalThrow);
        float Verticalthrow = Movement.ReadValue<Vector2>().y;
        Debug.Log(Verticalthrow);
    }
}
