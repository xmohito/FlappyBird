using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Score : MonoBehaviour
{
    public static Score instance;
    
    [SerializeField] private TextMeshProUGUI _currentScoreText;
    [SerializeField] private TextMeshProUGUI _highScoreText;

    private int _score;
    // Start is called before the first frame update
    void Start()
    {
        _currentScoreText.text = _score.ToString();

        _highScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        UpdateHighScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake() {

        if(instance == null)
        instance = this;
    }

    public void UpdateHighScore(){
        if(_score > PlayerPrefs.GetInt("HighScore", 0)){
            PlayerPrefs.SetInt("HighScore", _score);
            _highScoreText.text = _score.ToString();
        }
    }

    public void UpdateScore(){
        _score++;
        _currentScoreText.text = _score.ToString();
        UpdateHighScore();
    }
}
