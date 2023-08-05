using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private string keyPlayerPositionX = "PlayerPositionX";
    private string keyPlayerPositionY = "PlayerPositionY";
    // Agrega aquí cualquier otro dato que desees guardar (puntos, vidas, etc.).

    private Vector2 defaultPlayerPosition = new Vector2(0f, 0f); // Posición predeterminada del jugador al comenzar.

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SaveGame(Vector2 playerPosition)
    {
        PlayerPrefs.SetFloat(keyPlayerPositionX, playerPosition.x);
        PlayerPrefs.SetFloat(keyPlayerPositionY, playerPosition.y);
        // Agrega aquí cualquier otro dato que desees guardar.
        PlayerPrefs.Save();
    }

    public Vector2 LoadGame()
    {
        float posX = PlayerPrefs.GetFloat(keyPlayerPositionX, defaultPlayerPosition.x);
        float posY = PlayerPrefs.GetFloat(keyPlayerPositionY, defaultPlayerPosition.y);
        // Agrega aquí cualquier otro dato que desees cargar.

        return new Vector2(posX, posY);
    }

    public void ResetGame()
    {
        PlayerPrefs.DeleteAll();
    }
}
