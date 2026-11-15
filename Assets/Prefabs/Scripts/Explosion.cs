
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public float velocidadCrecimiento = 3f;
    public float tamanoMaximo = 2f;

    void Update()
    {
        transform.localScale += Vector3.one * velocidadCrecimiento * Time.deltaTime;

        if (transform.localScale.x >= tamanoMaximo)
        {
            Destroy(gameObject);
        }
    }
}
