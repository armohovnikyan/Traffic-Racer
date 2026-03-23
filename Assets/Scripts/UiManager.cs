using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    [SerializeField] private GameObject myCar;
    [SerializeField] private GameObject[] roads;
    [SerializeField] private GameObject canvas;
    [SerializeField] private GameObject GameEndCanvas;

    private void OnEnable()
    {
        GameEvents.OnRestart += Restart;
        GameEvents.OnGameEnd += GameEnd;
    }

    private void OnDisable()
    {
        GameEvents.OnRestart -= Restart;
        GameEvents.OnGameEnd -= GameEnd;
    }

    private void Start()
    {
        canvas.SetActive(true);
        myCar.SetActive(false);
        GameEndCanvas.SetActive(false);
        for (int i = 0; i < roads.Length; i++)
            roads[i].SetActive(false);
    }

    private void Restart()
    {
        Play();
        GameEndCanvas.SetActive(false);
    }

    public void Play()
    {
        myCar.SetActive(true);
        for (int i = 0;i < roads.Length;i++) roads[i].SetActive(true);
        canvas.SetActive(false);
    }

    public void GameEnd()
    {
        GameEndCanvas.SetActive(true);
        myCar.SetActive(false);
        for (int i = 0; i < roads.Length; i++) roads[i].SetActive(false);


    }
}
