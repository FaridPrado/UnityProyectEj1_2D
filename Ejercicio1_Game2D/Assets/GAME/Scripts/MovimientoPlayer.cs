using UnityEngine;
using UnityEngine.InputSystem;

public class MovimientoPlayer : MonoBehaviour
{
    public float velocidad = 2f;

    private Rigidbody2D cuerpo;
    private float movimientoX;

    void Start()
    {
        cuerpo = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movimientoX = 0f;

        if (Keyboard.current == null)
        {
            return;
        }

        if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed)
        {
            movimientoX = -1f;
        }

        if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed)
        {
            movimientoX = 1f;
        }
    }

    void FixedUpdate()
    {
        cuerpo.linearVelocity = new Vector2(movimientoX * velocidad, cuerpo.linearVelocity.y);
    }
}
