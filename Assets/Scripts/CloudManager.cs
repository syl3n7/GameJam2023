using UnityEngine;
using System.Collections;
using UnityEngine.Experimental.Rendering;

public class CloudManagerScript : MonoBehaviour {
    //Set this variable to your Cloud Prefab through the Inspector
    public GameObject cloudPrefab;
 
    //Set this variable to how often you want the Cloud Manager to make clouds in seconds.
    //For Example, I have this set to 2
    public float delay;

    public Transform parentOfPrefab;
 
    //If you ever need the clouds to stop spawning, set this variable to false, by doing: CloudManagerScript.spawnClouds = false;
    public static bool spawnClouds = true;
 
    // Use this for initialization
    void Start () {
        //Begin SpawnClouds Coroutine
        StartCoroutine(SpawnClouds());
    }
 
    IEnumerator SpawnClouds() {
        //This will always run
        while(true) {
            //Only spawn clouds if the boolean spawnClouds is true
            while(spawnClouds) {
                //Instantiate Cloud Prefab and then wait for specified delay, and then repeat
                //Instantiate(cloudPrefab); // colocar o parent correto @serra
                Instantiate(cloudPrefab, parentOfPrefab);
                yield return new WaitForSeconds(delay);
            }
        }
    }
}