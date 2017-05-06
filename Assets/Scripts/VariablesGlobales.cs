
public class VariablesGlobales
{
    public static float VELOCIDAD_PELOTA = 500f;   // Velocidad con la que la pelota inicia un nivel.
    public static float VELOCIDAD_REBOTE_BARRA = 5f;   // Velocidad que la barra le dará a la pelota cuando ésta rebote.
    public static float DESFASE = 10;   // Desfase con el que la pelota inicia un nivel.

    public static void aumentarDificultad()
    {
        VariablesGlobales.VELOCIDAD_PELOTA *= 1.25f;
        VariablesGlobales.VELOCIDAD_REBOTE_BARRA *= 1.25f;
        VariablesGlobales.DESFASE *= 2.5f;
    }
}
