using UnityEngine;

namespace Gameplay
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private GameObject[] trafficCars;
        [SerializeField] private Transform player;
        private float spawnDistance = 60f;
        private float spawnInterval = 1f;
        private float laneOffset = 3f;


        private void Start()
        {
            InvokeRepeating(nameof(SpawnCar),1f,spawnInterval);
        }


        void SpawnCar()
        {
            int lane = 0;
            switch (player.position.x) 
            {
                case 7:
                    lane = Random.Range(0, 3);
                    break;
                case 10:
                    lane = Random.Range(-1, 2);
                    break;
                case 13:
                    lane = Random.Range(-2, 1);
                    break;
            }
            Vector3 pos = player.position + Vector3.forward * spawnDistance;
            pos.x += lane * laneOffset;
            int carIndex = Random.Range(0,trafficCars.Length);
            Instantiate(trafficCars[carIndex], pos, Quaternion.identity);
        }



    }   
}
