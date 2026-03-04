using UnityEngine;

namespace Gameplay
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private GameObject[] trafficCars;
        [SerializeField] private Transform player;
        private float spawnDistance = 80f;
        private float spawnInterval = 2f;
        private float laneOffset = 3f;


        private void Start()
        {
            InvokeRepeating(nameof(SpawnCar),1f,spawnInterval);
        }


        void SpawnCar()
        {
            int lane = Random.Range(-1, 1);
            Vector3 pos = player.position + Vector3.forward * spawnDistance;
            pos.x += lane * laneOffset;

            int carIndex = Random.Range(0,trafficCars.Length);
            Instantiate(trafficCars[carIndex], pos, Quaternion.identity);
        }

    }   
}
