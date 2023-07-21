using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level_transition : MonoBehaviour
{
    public void change_scene(int scene)
    {
        SceneManager.LoadScene(scene);
    }
}
