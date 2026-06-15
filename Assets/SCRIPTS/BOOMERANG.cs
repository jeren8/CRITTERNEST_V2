using UnityEngine;

public class BOOMERANG : MonoBehaviour
{
    public float velocidad = 5f;
    public Transform jugador;

    Vector3 inicio;
    bool regresar;

    void Start()
    {
        inicio = transform.position;
    }

    void Update()
    {
        if (!regresar)
        {
            transform.Translate(Vector3.right * velocidad * Time.deltaTime);

            if (Vector3.Distance(transform.position, inicio) > 3)
            {
                regresar = true;
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                jugador.position,
                velocidad * Time.deltaTime
            );

            if (Vector3.Distance(transform.position, jugador.position) < 0.5f)
            {
                Destroy(gameObject);
            }
        }
    }
}
    