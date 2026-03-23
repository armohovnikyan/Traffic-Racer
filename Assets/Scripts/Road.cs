using UnityEngine;

public class Road : MonoBehaviour
{
    private Transform rect;
    private float speed = 0.5f;


    private void Awake()
    {
        GameEvents.OnRestart += Restart;
        GameEvents.OnGameEnd += GameEnd;
    }

    private void OnDestroy()
    {
        GameEvents.OnRestart -= Restart;
        GameEvents.OnGameEnd -= GameEnd;
    }

    public void Start()
    {
        rect = GetComponent<Transform>();
    }
    public void Update()
    {
        Move();
    }
    private void Move()
    {

        float z = rect.position.z;
        z -= speed;
        if (z == -160)
            z = 160;
        rect.position = new Vector3(0, 0, z);
    }

    void GameEnd()
    {
        speed = 0f;
    }

    void Restart()
    {
        speed = 0.5f;
    }
}
