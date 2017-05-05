using UnityEngine;
using UnityEngine.SceneManagement;

public class SiguienteNivel : MonoBehaviour
{
    public string nivel;
    public float delay;

    private void cargaNivel()
    {
        SceneManager.LoadScene(nivel);
    }

    public void activarCarga()
    {
        Invoke("cargaNivel", delay);   // 'Invoke' llamará al método "cargaNivel" tras un 'delay'.
    }

    public bool esNivelFinal()
    {
        return (nivel == "Portada");
    }
}
