using System.Collections;
using UnityEngine;

/**
 * This component spawns the given object at fixed time-intervals at its object position.
 */
public class TimedSpawner: MonoBehaviour {
    [SerializeField] Mover prefabToSpawn;
    [SerializeField] Vector3 velocityOfSpawnedObject;
    [SerializeField] float timeBetweenSpawns = 1f;

    void Start() {
        this.StartCoroutine(SpawnRoutine());
        Debug.Log("Start finished");
    }

    private IEnumerator SpawnRoutine() {
        while (true) {
            GameObject newObject = Instantiate(prefabToSpawn.gameObject, transform.position, Quaternion.identity);
            newObject.GetComponent<Mover>().SetVelocity(velocityOfSpawnedObject);
            yield return new WaitForSeconds(timeBetweenSpawns);
        }
    }
}
