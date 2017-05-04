using UnityEngine;

public class TocaSuelo : MonoBehaviour
{
    public ModificarVidas vidas;

    private void OnCollisionEnter(Collision collision)
    {
        vidas.quitarVida();
    }
}
