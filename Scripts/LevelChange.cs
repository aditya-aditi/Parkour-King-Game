using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelChange : MonoBehaviour
{
    public GameObject won;

    // void Start()
    // {
        
    // }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "playerWon")
        {
            StartCoroutine(Wait_for_level_change());
            won.SetActive(true);
            IEnumerator Wait_for_level_change()
            {
                yield return new WaitForSeconds(2);
                Cursor.lockState = CursorLockMode.None;
                SceneManager.LoadScene("Start");
            }
        }
    }
}
