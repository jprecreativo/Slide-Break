using UnityEngine;
using UnityEngine.SceneManagement;

public class EmpezarPartida : MonoBehaviour
{
	private void Update ()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            ModificarPuntos.puntos = 0;
            ModificarVidas.vidas = 3;

            SceneManager.LoadScene("Nivel_01");
        }
	}
}
