using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class playerDead : MonoBehaviour
{
    public GameObject WrongWayPanel;

    private void Start() {
        WrongWayPanel.SetActive(false);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag=="playerDead")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (other.gameObject.tag=="WrongWay")
        {
            StartCoroutine(Wait_for_level_change());
            WrongWayPanel.SetActive(true);
            IEnumerator Wait_for_level_change()
            {
                yield return new WaitForSeconds(1);
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
