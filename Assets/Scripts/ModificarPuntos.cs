using UnityEngine;
using UnityEngine.UI;

public class ModificarPuntos : MonoBehaviour
{
    public static int puntos;
    public Text textoPuntos;

    private void actualizarTextoPuntos()
    {
        textoPuntos.text = "Puntos: " + ModificarPuntos.puntos;
    }

    private void Start ()
    {
        puntos = 0;
        this.actualizarTextoPuntos();
	}

    public void ganarPuntos()
    {
        ModificarPuntos.puntos++;

        this.actualizarTextoPuntos();
    }
}
