using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    public GameObject enemigo;

    void Start()
    {
        InvokeRepeating("Generar", 1f, 3f);
    }

    void Generar()
    {
        Vector3 direccion = new Vector3(
            Random.Range(-1f, 1f),
            Random.Range(-1f, 1f),
            0
        );

        Vector3 posicionSpawn = transform.position + direccion * 3f;

        Instantiate(enemigo, posicionSpawn, Quaternion.identity);
    }
}
