using UnityEngine;

public class DestruyeBloque : MonoBehaviour
{
    public GameObject particleSys;
    public ModificarPuntos puntos;

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        Instantiate(particleSys, this.transform.position, Quaternion.identity);
        puntos.ganarPuntos();
    }
}
