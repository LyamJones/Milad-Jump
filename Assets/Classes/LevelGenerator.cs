using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {

	public GameObject platformPrefab;

	public int numberOfPlatforms = 200;
	public float levelWidth = 3f;
	public float minY = .2f;
	public float maxY = 1.5f;

	// Use this for initialization
	void Start () {

		Vector3 spawnPosition = new Vector3();

		//betweet 0 and 200 platforms
		for (int i = 0; i < numberOfPlatforms; i++)
		{
			spawnPosition.y += Random.Range(minY, maxY);
			spawnPosition.x = Random.Range(-levelWidth, levelWidth);
			//Makes sure object don't rotate
			Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
		}
	}
}
