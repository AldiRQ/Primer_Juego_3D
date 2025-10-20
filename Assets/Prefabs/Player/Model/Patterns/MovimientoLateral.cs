using UnityEngine;

public class MovimientoLateral : IMovementStrategy
{
    public void move(Transform transform, float speed)
    {
        float direccion = Input.GetAxis("Horizontal");
        transform.Translate(direccion * speed * Time.deltaTime, 0, 0);
    }
}
