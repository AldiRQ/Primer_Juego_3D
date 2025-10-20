using UnityEngine;

public class MovimientoAcelerado : IMovementStrategy
{
    private float velocidadActual = 0f;
    private float aceleracion = 2f; // Aceleraci�n constante

    public void move(Transform transform, float speed)
    {
        velocidadActual += Input.GetAxis("Horizontal") * aceleracion * Time.deltaTime;
        velocidadActual = Mathf.Clamp(velocidadActual, -speed, speed);
        transform.Translate(velocidadActual * Time.deltaTime, 0, 0);
    }
}
