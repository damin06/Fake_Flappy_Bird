using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class PlayEnd : MonoBehaviour
{
    [SerializeField] private GameObject _canvas;
    [SerializeField] private TextMeshProUGUI GameOverTXT;
    [SerializeField] private Image _panel;
    [SerializeField] private TextMeshProUGUI _scoreTXT;
    [SerializeField] private Button _button;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnableUI()
    {
        _canvas.gameObject.SetActive(true);
        StartCoroutine(EnableRoutine());
    }

    IEnumerator EnableRoutine()
    {
        GameOverTXT.rectTransform.DOAnchorPosY(0, 1).SetEase(Ease.OutElastic);
        yield return new WaitForSeconds(0.5f);
        _panel.rectTransform.DOAnchorPosY(0, 1).SetEase(Ease.OutExpo);
        int socre = PlayerPrefs.GetInt("Score");
        yield return new WaitForSeconds(1); 
        for(int i = 0; i < socre; i++)
        {
            _scoreTXT.text = i.ToString();
            yield return new WaitForSeconds(0.1f);
        }
        _button.gameObject.SetActive(true);
    }

    public void ChangeScene(int index) => SceneManager.LoadScene(index);
}
