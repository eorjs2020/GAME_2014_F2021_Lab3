using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnStartButtonPressed()
    {
        SceneManager.LoadScene("Main");
    }
}
