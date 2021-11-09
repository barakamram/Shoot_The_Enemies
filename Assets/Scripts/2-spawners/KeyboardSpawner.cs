using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * This component spawns the given object whenever the player clicks a given key.
 */
public class KeyboardSpawner : MonoBehaviour {
    public GameObject text;
    public GameObject cannon;

    [SerializeField] protected KeyCode keyToPress;
   // [SerializeField] protected KeyCode pressToPower;

    [SerializeField] protected GameObject prefabToSpawn;
    [SerializeField] protected Vector3 velocityOfSpawnedObject; 
    [Tooltip("for how long will you get the power")] [SerializeField] float powerTime;
    [Tooltip("For how long you will not be able to shoot")] [SerializeField] float minTimeBetShots;
    [Tooltip("How much longer can you shoot")] [SerializeField] float stopWatch;
    [Tooltip("How much longer will you have the power")] [SerializeField] float powerClock;
    float time;
    void Start()
    {
        text.SetActive(false);
        cannon.SetActive(false);
        stopWatch = 0f;
        time = 0f;
        minTimeBetShots = 2f;
        powerTime = 3f;
        powerClock = powerTime;
    }

    void Update()
    {
       
        //Update the time 

        time += Time.deltaTime;
        stopWatch -= Time.deltaTime;

        if (Input.GetKeyDown(keyToPress) && stopWatch <= 0f)
        {
            spawnObject();
            stopWatch = minTimeBetShots;
        }
        else if (time >= 10)
        {
            text.SetActive(true);
            cannon.SetActive(true);


            if (Input.GetKey(keyToPress))
            {
                text.SetActive(false);
                powerClock -= Time.deltaTime;
                if (powerClock >= 0f)
                {
                    spawnObject();
                }
                else
                {
                    time = 0f;
                    powerClock = powerTime;
                    cannon.SetActive(false);

                }
            }
        }



    }

    protected virtual GameObject spawnObject()
    {
        // Step 1: spawn the new object.
        Vector3 positionOfSpawnedObject = transform.position;  // span at the containing object position.
        Quaternion rotationOfSpawnedObject = Quaternion.identity;  // no rotation.
        GameObject newObject = Instantiate(prefabToSpawn, positionOfSpawnedObject, rotationOfSpawnedObject);

        // Step 2: modify the velocity of the new object.
        Mover newObjectMover = newObject.GetComponent<Mover>();
        if (newObjectMover)
        {
            newObjectMover.SetVelocity(velocityOfSpawnedObject);
        }

        return newObject;
    }
}
