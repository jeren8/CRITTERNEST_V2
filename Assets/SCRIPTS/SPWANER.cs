using UnityEngine;

public class SPWANER : MonoBehaviour
{
    public GameObject enemigo;
    void Start()
    {
        InvokeRepeating("Generar", 1f, 3f);
    }
    void Generar()
    {
        Vector3 posicionSpawn = transform.position + new Vector3(
            Random.Range(-2f, 2f),
            Random.Range(-2f, 2f),
            0
        );

        Instantiate(
            enemigo,
            posicionSpawn,
            Quaternion.identity
        );
    }
}
