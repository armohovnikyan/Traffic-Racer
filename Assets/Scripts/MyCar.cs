using UnityEngine;

public class MyCar : MonoBehaviour
{
    private bool isPlaying;

    private void Awake()
    {
        GameEvents.OnRestart += Restart;
    }

    private void OnDestroy()
    {
        GameEvents.OnRestart -= Restart;
    }
    private void Start()
    {
        isPlaying = true;
    }

    public void Update()
    {
        Move();
    }

    private void Move()
    {
        if (isPlaying)
        {
            float x = transform.position.x;

            if (Input.GetKeyDown(KeyCode.LeftArrow) && x > 7)
                x -= 3;
            if (Input.GetKeyDown(KeyCode.RightArrow) && x < 13)
                x += 3;

            transform.position = new Vector3(x, transform.position.y, transform.position.z);
        }
        else
        {
            return;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Car"))
        {
            GameEvents.RaiseOnGameEnd();
            isPlaying = false;
        }
    }

    void Restart()
    {
        isPlaying = true;
    }
}
