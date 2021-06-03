using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menucontroller : MonoBehaviour
{
    public void Perehod()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
