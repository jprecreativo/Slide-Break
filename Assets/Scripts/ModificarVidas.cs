using UnityEngine;
using UnityEngine.UI;

public class ModificarVidas : MonoBehaviour
{ 
    public static int vidas;
    public Text textoVidas;
    public MovimientoPelota pelota;
    public MovimientoBarra barra;

    private void Start ()
    {
        vidas = 3;
        this.actualizarTextoVidas();
	}

    private void actualizarTextoVidas()
    {
        textoVidas.text = "Vidas: " + ModificarVidas.vidas;
    }

    public void quitarVida()
    {
        ModificarVidas.vidas--;

        this.actualizarTextoVidas();
        
        barra.resetearPos();
        pelota.resetearPelota();
    }
}
