using UnityEngine;

public class SonidosFinPartida : MonoBehaviour
{
    public AudioSource sonido;
    public AudioClip completado;
    public AudioClip gameOver;

    private void reproducirSonido(AudioClip clip)
    {
        sonido.loop = false;
        sonido.clip = clip;

        sonido.PlayDelayed(1);
    }

    public void sonidoGameOver()
    {
        this.reproducirSonido(gameOver);
    }

    public void sonidoNivelCompletado()
    {
        this.reproducirSonido(completado);
    }
}
