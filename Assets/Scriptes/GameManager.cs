using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject Heart0, Heart1, Heart2, Heart3, HipFireReticle;
    public static int health;

    // Start is called before the first frame update
    void Start()
    {
        health = 4;
        Heart0.gameObject.SetActive(true);
        Heart1.gameObject.SetActive(true);
        Heart2.gameObject.SetActive(true);
        Heart3.gameObject.SetActive(true);
        HipFireReticle.gameObject.SetActive(true); 
    }

    // Update is called once per frame
    void Update()
    {
        switch (health)
        {
            case 4:
                 Heart0.gameObject.SetActive(true);
                 Heart1.gameObject.SetActive(true);
                 Heart2.gameObject.SetActive(true);
                 Heart3.gameObject.SetActive(true);
                 HipFireReticle.gameObject.SetActive(true);
                 break;
            case 3:
                 Heart0.gameObject.SetActive(true);
                 Heart1.gameObject.SetActive(true);
                 Heart2.gameObject.SetActive(true);
                 Heart3.gameObject.SetActive(false);
                 HipFireReticle.gameObject.SetActive(true);
                 break;
             case 2:
                 Heart0.gameObject.SetActive(true);
                 Heart1.gameObject.SetActive(true);
                 Heart2.gameObject.SetActive(false);
                 Heart3.gameObject.SetActive(false);
                 HipFireReticle.gameObject.SetActive(true);
                 break;
            case 1:
                 Heart0.gameObject.SetActive(true);
                 Heart1.gameObject.SetActive(false);
                 Heart2.gameObject.SetActive(false);
                 Heart3.gameObject.SetActive(false);
                 HipFireReticle.gameObject.SetActive(true);
                 break;
            
            default:
                 Heart0.gameObject.SetActive(false);
                 Heart1.gameObject.SetActive(false);
                 Heart2.gameObject.SetActive(false);
                 Heart3.gameObject.SetActive(false);
                 HipFireReticle.gameObject.SetActive(false);
                 Cursor.lockState = CursorLockMode.Confined;
                 SceneManager.LoadScene("GameOverScene");
                 break;   


            
        }
    }
}
