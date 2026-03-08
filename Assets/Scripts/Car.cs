using UnityEngine;
using UnityEngine.UIElements;

namespace Gameplay
{
    public class Car : MonoBehaviour
    {
        private float speed = 10f;
        private Transform pos;

        private void Start()
        {
            pos = GetComponent<Transform>();
        }
        private void Update()
        {
            transform.Translate(Vector3.back *  speed * Time.deltaTime);
            Destroy();
        }
        
        void Destroy()
        {
            float z = pos.position.z;
            if (z < 20)
                Destroy(gameObject);
        }
    }

}

