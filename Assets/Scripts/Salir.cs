using UnityEngine;
using UnityEngine.SceneManagement;

public class Salir : MonoBehaviour
{
    public bool salir;

	private void Update ()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(salir)
                Application.Quit();

            else
                SceneManager.LoadScene("Portada");
        }
	}
}
