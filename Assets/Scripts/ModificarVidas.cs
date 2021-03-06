﻿using UnityEngine;
using UnityEngine.UI;

public class ModificarVidas : MonoBehaviour
{
    public static int vidas;
    public Text textoVidas;
    public MovimientoPelota pelota;
    public MovimientoBarra barra;
    public GameObject gameOver;
    public SiguienteNivel portada;
    public SonidosFinPartida reproducir;

    private void Start()
    {
        //Aquí no se inicializan la variable 'vidas' ya que el script 'EmpezarPartida.cs' lo hace.

        this.actualizarTextoVidas();
    }

    private void actualizarTextoVidas()
    {
        textoVidas.text = "Vidas: " + ModificarVidas.vidas;
    }

    public void quitarVida()
    {
        if (ModificarVidas.vidas > 0)
        {
            ModificarVidas.vidas--;

            this.actualizarTextoVidas();

            if (ModificarVidas.vidas <= 0)
            {
                pelota.pararPelota();
                barra.enabled = false;
                gameOver.SetActive(true);

                reproducir.sonidoGameOver();

                portada.nivel = "Portada";
                portada.activarCarga();
            }

            else
            {
                barra.resetearPos();
                pelota.resetearPelota();
            }
        }
    }
}
