using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultButton : MonoBehaviour
{
    // Start is called before the first frame update
    private Button button;
    private GameManager gameManager;
    public int level;
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficult);
        gameManager = GameObject.Find("Game Manager"). GetComponent<GameManager>();
    }

    void SetDifficult(){
        Debug.Log(gameObject.name + "Was clicked");
        gameManager.StartGame(level);
    }

    // Update is called once per frame
    // void Update()
    // {
        
    // }
}
