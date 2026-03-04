using UnityEngine;

namespace Gameplay
{
    public class Car : MonoBehaviour
    {
        public float speed = 30f;

        private void Update()
        {
            transform.Translate(Vector3.back *  speed * Time.deltaTime);
        }

        private void OnBecameInvisible()
        {
            Destroy(gameObject);
        }
    }

}

