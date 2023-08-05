/*
Paso 2: Asegúrate de que el objeto al que adjuntaste el script "GameManager" esté presente en todas las escenas donde necesites guardar o cargar la partida.
Paso 3: En otros scripts de tu juego donde quieras guardar o cargar la partida, puedes acceder a las funciones del GameManager usando "GameManager.Instance".
Ejemplo de cómo guardar y cargar la posición del jugador desde otro script:
 */

using UnityEngine;

public class CargarPartida : MonoBehaviour
{
    private Transform playerTransform;

    private void Start()
    {
        playerTransform = transform;
    }

    private void Update()
    {
        // Código de control del jugador y movimiento...

        // Guardar la partida al presionar una tecla específica (por ejemplo, "Guardar con G").
        if (Input.GetKeyDown(KeyCode.G))
        {
            GameManager.Instance.SaveGame(playerTransform.position);
            Debug.Log("Partida guardada.");
        }

        // Cargar la partida al presionar otra tecla específica (por ejemplo, "Cargar con L").
        if (Input.GetKeyDown(KeyCode.L))
        {
            Vector2 loadedPosition = GameManager.Instance.LoadGame();
            playerTransform.position = loadedPosition;
            Debug.Log("Partida cargada.");
        }
    }
}
