using UnityEngine;

public class Exit : MonoBehaviour
{
    public void button_exit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();

    }
}