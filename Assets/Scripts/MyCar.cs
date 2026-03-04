using UnityEngine;

public class MyCar : MonoBehaviour
{
    private Transform transform;

    public void Start()
    {
        transform = GetComponent<Transform>();
    }


    public void Update()
    {
        Move();
    }

    private void Move()
    {
        float x = transform.position.x;

        if (Input.GetKeyDown(KeyCode.LeftArrow) && x > 7)
            x -= 3;
        if(Input.GetKeyDown(KeyCode.RightArrow) && x < 13)
            x += 3;
     
        transform.position = new Vector3(x, transform.position.y, transform.position.z);
    }
}
