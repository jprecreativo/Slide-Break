using UnityEngine;

public class DestruyeBloqueNaranja : MonoBehaviour
{
    private int golpes;
    public GameObject particleSys;
    public ModificarPuntos puntos;

    private void Awake()
    {
        golpes = 2;
    }

    private void OnCollisionEnter(Collision collision)
    {
        // this.transform.SetParent(null);   // Dejo de ser hijo de "Bloques".

        puntos.ganarPuntos();
        golpes--;

        if(golpes <= 0)
        {
            Destroy(gameObject);
            Instantiate(particleSys, this.transform.position, Quaternion.identity);
        }
    }
}
