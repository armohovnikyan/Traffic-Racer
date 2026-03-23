using UnityEngine;
using UnityEngine.UIElements;

namespace Gameplay
{
    public class Car : MonoBehaviour
    {
        private float speed = 10f;
        private Transform pos;


        private void Awake()
        {
            GameEvents.OnGameEnd += GameEnd;
            GameEvents.OnRestart += Restart;
        }

        private void OnDestroy()
        {
            GameEvents.OnGameEnd -= GameEnd;
            GameEvents.OnRestart -= Restart;
        }
        private void Start()
        {
            pos = GetComponent<Transform>();
        }
        private void Update()
        {
            Move();
        }
        
        void Move()
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
            CheckDestroy();
        }

        void CheckDestroy()
        {
            float z = pos.position.z;
            if (z < 20)
                Destroy(gameObject);
        }

        void GameEnd()
        {
            speed = 0f;
            Destroy(gameObject);
        }

        void Restart()
        {
            speed = 10f;
        }

    }

}

