using UnityEngine;
/// <summary>
/// permite el comportamiento del movimiento del jugador
/// </summary>
public class PlayerMovement : MonoBehaviour
{
    #region Atributos
    /// <summary>
    /// fuerza utilizada para aplicar movimiento al jugador
    /// </summary>
    private Vector3 fuerzaPorAplicar;
    /// <summary>
    /// representa el tiempo que a transcurrido
    /// desde la ultima aplicacion de fuerza
    /// </summary>  
    private float tiempoDesdeUltimaFuerza;
    /// <summary>
    /// indica cada cuanto tiempo debe aplicarse
    /// la fuerza
    /// </summary>
    private float intervaloTiempo;
    /// <summary>
    /// indica la velocidad aplicada en el movimiento lateral
    /// </summary>
    private float velocidadLateral;
    /// <summary>
    /// Representa la estrategia del Movimiento
    /// </summary>
    private IMovementStrategy strategy;


    #endregion

    #region Ciclo de vida del Script

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       fuerzaPorAplicar = new Vector3(0, 0, 300f);
       tiempoDesdeUltimaFuerza = 0f;
       intervaloTiempo = 2f;
       velocidadLateral = 5f;
       setStrategy(new MovimientoAcelerado());
    }

    private void Update()
    {
        strategy.move(transform, velocidadLateral);
    }

    private void FixedUpdate()
    {
        tiempoDesdeUltimaFuerza += Time.fixedDeltaTime;
        if (tiempoDesdeUltimaFuerza >= intervaloTiempo)
        {
            GetComponent<Rigidbody>().AddForce(fuerzaPorAplicar, ForceMode.Impulse);
            tiempoDesdeUltimaFuerza = 0f;
        }
    }

    #endregion

    #region Logica del Script

    public void setStrategy(IMovementStrategy strategy)
    {
        this.strategy = strategy;
    }

    #endregion


}
