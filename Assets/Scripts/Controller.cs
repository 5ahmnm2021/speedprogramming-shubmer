using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    public Button falsch1;
    public Button falsch2;
    public Button richtig;
    public GameObject falschtext;

    // Start is called before the first frame update
    void Start()
    {
        falschtext.SetActive(false);

        falsch1.GetComponent<Button>();
        falsch1.onClick.AddListener(OnClick);

        falsch2.GetComponent<Button>();
        falsch2.onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        Debug.Log("Falsche Antwort");
        falschtext.SetActive(true);

    }

    public void ChangeScene1()
    {
        SceneManager.LoadScene("Screen2");
    }
}
