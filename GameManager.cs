using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    private int score;
    private float spawnRate = 1.0f;
    public TextMeshProUGUI scoreText;
    public List<GameObject> targets; 
    public TextMeshProUGUI gameOverText;
    public bool isGameActive;
    public Button restartButton;
    public GameObject titleScreen;
    
    void Start()
    {
        StartCoroutine(SpawnTarget());
        score = 0;
        isGameActive =true;
        // gameOverText.gameObject.SetActive(true);
        // scoreText.text = "Score:" + score;
    }

    public void StartGame( int difficulty){
        isGameActive =true;
        score = 0;
        StartCoroutine(SpawnTarget());
        UpdateScore(0);
        titleScreen.gameObject.SetActive(false);
        spawnRate/= difficulty;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnTarget() {
        while (isGameActive)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
            // UpdateScore(5);
        }
    }

    public void UpdateScore(int scoreToAdd){
        score += scoreToAdd;
        scoreText.text ="Score :" + score;
    }

    public void GameOver (){
         gameOverText.gameObject.SetActive(true);
         isGameActive = false;
         restartButton.gameObject.SetActive(true);
    }
    public void RestartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    


}
