using UnityEngine;

public class UiManager : MonoBehaviour
{
    [SerializeField] private GameObject myCar;
    [SerializeField] private GameObject[] roads;
    [SerializeField] private GameObject canvas;

    private void OnEnable()
    {
        GameEvents.OnStart += InitGame;
    }

    private void OnDisable()
    {
        GameEvents.OnStart -= InitGame;
    }

    private void InitGame()
    {
        myCar.SetActive(false);
        for (int i = 0; i < roads.Length; i++)
            roads[i].SetActive(false);
        canvas.SetActive(true);
    }

    public void Play()
    {
        myCar.SetActive(true);
        for (int i = 0; i < roads.Length; i++)
            roads[i].SetActive(true);
        canvas.SetActive(false);
        GameEvents.RaiseOnPlay();
    }
}
