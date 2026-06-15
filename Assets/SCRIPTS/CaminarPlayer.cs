using UnityEngine;
using UnityEngine.InputSystem;
public class CaminarPlayer : MonoBehaviour
{
    public float velocidad = 5f;

    void Update()
    {
        Vector2 movimiento = Vector2.zero;

        if (Keyboard.current.wKey.isPressed) movimiento.y += 1;
        if (Keyboard.current.sKey.isPressed) movimiento.y -= 1;
        if (Keyboard.current.aKey.isPressed) movimiento.x -= 1;
        if (Keyboard.current.dKey.isPressed) movimiento.x += 1;

        transform.position += (Vector3)movimiento.normalized * velocidad * Time.deltaTime;
    }
}
