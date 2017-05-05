using UnityEngine;

public class SonidosPelota : MonoBehaviour
{
    public AudioSource rebote;
    public AudioSource ganarPunto;

    private void OnCollisionEnter(Collision objetoColisionado)
    {
        if (objetoColisionado.gameObject.CompareTag("Bloque"))
            ganarPunto.Play();

        else
            rebote.Play();
    }
}
