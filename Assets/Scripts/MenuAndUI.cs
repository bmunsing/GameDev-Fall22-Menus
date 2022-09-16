using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuAndUI : MonoBehaviour
{
    public GameObject menubutton;
    public GameObject newgamebutton;
    public GameObject quitbutton;
    public GameObject playernametext;
    public GameObject menupanel;
    public GameObject playermessagetext;
    bool menuactive;

    // Start is called before the first frame update
    void Start()
    {
        menuactive = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void menubuttononclick()
    {
        menupanel.SetActive(!menuactive);
        menuactive = !menuactive;
    }

    public void playernametextadded()
    {
        playermessagetext.GetComponent<TextMeshProUGUI>().text = "You win, " + playernametext.GetComponentInChildren<TMP_InputField>().text + "!";
    }

    public void newgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
    }

    public void quitgame()
    {
        Application.Quit();
    }
}
