using UnityEngine;

public class TocaSuelo : MonoBehaviour
{
    public ModificarVidas vidas;
    public AudioSource error;

    private void OnCollisionEnter(Collision collision)
    {
        error.Play();
        vidas.quitarVida();
    }
}
