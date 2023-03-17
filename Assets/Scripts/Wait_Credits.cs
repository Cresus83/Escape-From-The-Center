using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wait_Credits : MonoBehaviour
{

    public float wait_time = 17;

    void Start()
    {
        StartCoroutine(Wait_for_outro());
    }

    IEnumerator Wait_for_outro()
    {
        yield return new WaitForSeconds(wait_time);
        SceneManager.LoadScene(1);
    }
}
