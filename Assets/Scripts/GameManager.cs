using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject[] trafficCars;
    [SerializeField] private Transform player;

    private float spawnDistance = 60f;
    private float spawnInterval = 1f;
    private float laneOffset = 3f;
    private bool isPlaying;

    private void Awake()
    {
        GameEvents.OnGameEnd += EndGame;
    }

    private void OnDestroy()
    {
        GameEvents.OnGameEnd -= EndGame;
    }

    public void PlayButton()
    {
        isPlaying = true;
        InvokeRepeating(nameof(SpawnCar), 2f, spawnInterval);
    }



    private void SpawnCar()
    {

        int lane = 0;

        switch (player.position.x)
        {
            case 7: lane = Random.Range(0, 3); break;
            case 10: lane = Random.Range(-1, 2); break;
            case 13: lane = Random.Range(-2, 1); break;
        }

        Vector3 pos = player.position + Vector3.forward * spawnDistance;
        pos.x += lane * laneOffset;

        int carIndex = Random.Range(0, trafficCars.Length);
        if(isPlaying) Instantiate(trafficCars[carIndex], pos, Quaternion.identity);
    }

    private void EndGame()
    {
        isPlaying = false;
        CancelInvoke(nameof(SpawnCar));
    }

    public void RestartButton()
    {
        GameEvents.RaiseOnRestart();
        PlayButton();
    }
}