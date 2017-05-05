using UnityEngine;
using UnityEngine.UI;

public class ModificarPuntos : MonoBehaviour
{
    public static int puntos;
    public Text textoPuntos;
    public GameObject nivelSuperado;
    public GameObject juegoSuperado;
    public SiguienteNivel siguienteNivel;
    public MovimientoPelota pelota;
    public MovimientoBarra barra;
    public Transform transformBloques;
    public SonidosFinPartida reproducir;

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

        /*
         * Compruebo en el siguiente 'if' si bloques menor o igual que '1' porque el último bloque no se destruirá hasta que
         * se haya terminado el método 'OnCollisionEnter()' de la clase 'DestruyeBloque.cs'. Otra opción, es ir haciendo que
         * los bloques dejen de ser hijos del contenedor de bloques, descomentando la línea del método 'OnCollisionEnter()' 
         * de la clase 'DestruyeBloque.cs'.
         */

        if (transformBloques.childCount <= 1)   // Si se han destruido todos los bloques.
        {
            pelota.pararPelota();
            barra.enabled = false;

            if(siguienteNivel.esNivelFinal())
                juegoSuperado.SetActive(true);

            else
                nivelSuperado.SetActive(true);

            reproducir.sonidoNivelCompletado();
            siguienteNivel.activarCarga();
        }
    }
}
