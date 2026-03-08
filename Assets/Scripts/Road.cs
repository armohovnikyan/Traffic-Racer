using UnityEngine;

public class Road : MonoBehaviour
{
    private Transform rect;
    private float speed = 2f;

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
}
