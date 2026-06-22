using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public Transform jugador;
    public float velocidad = 3f;
    public float distanciaDeteccion = 5f;


    void Update()
    {
        float distancia = Vector2.Distance(transform.position, jugador.position);

        if (distancia <= distanciaDeteccion)
        {
            Vector3 direccion = (jugador.position - transform.position).normalized;
            transform.position += direccion * velocidad * Time.deltaTime;

        }
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, distanciaDeteccion);
    }
}