using UnityEngine;

public class MyCar : MonoBehaviour
{
    private Transform trans;

    public void Start()
    {
        trans = GetComponent<Transform>();
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

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Car"))
            Debug.Log("Alyooooooo");
    }
}
