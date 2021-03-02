﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BoardManager : MonoBehaviour {
	public static BoardManager instance;
	public List<Sprite> characters = new List<Sprite>();
	public GameObject tile;
	public int xSize, ySize;

	public GameObject[,] tiles;

	private SpriteRenderer previousBelow;

	public bool IsShifting { get; set; }

	public AudioSource spectrumSource;
	public AudioClip clip;
	bool hasClipStarted = false;

	void Awake() {
		if (spectrumSource == null) spectrumSource = gameObject.AddComponent<AudioSource>();
	}

	void Start () {
		instance = GetComponent<BoardManager>();

		Vector2 offset = tile.GetComponent<SpriteRenderer>().bounds.size;
        CreateBoard(offset.x, offset.y); 
		previousBelow = GetComponent<SpriteRenderer>();
	}

	void Update() {
		spectrumSource.clip = clip;
		if (hasClipStarted == false) {
			spectrumSource.loop = true;
			spectrumSource.Play();
			hasClipStarted = true;
		}	
	}

    private void CreateBoard (float xOffset, float yOffset) {
        tiles = new GameObject[xSize, ySize];    

        float startX = transform.position.x;    
        float startY = transform.position.y;

		Sprite[] previousLeft = new Sprite[ySize];
		Sprite previousBelow = null;

        for (int x = 0; x < xSize; x++) {      
            for (int y = 0; y < ySize; y++) {
                GameObject newTile = Instantiate(tile, new Vector3(startX + (xOffset * x), startY + (yOffset * y), 0), tile.transform.rotation);
				tiles[x, y] = newTile;

				newTile.transform.parent = transform; 

				List<Sprite> possibleCharacters = new List<Sprite>();

				possibleCharacters.AddRange(characters);

				possibleCharacters.Remove(previousLeft[y]); 
				possibleCharacters.Remove(previousBelow);

				Sprite newSprite = possibleCharacters[Random.Range(0, possibleCharacters.Count)];
				newTile.GetComponent<SpriteRenderer>().sprite = newSprite; 

				previousLeft[y] = newSprite;
				previousBelow = newSprite;
            }
        }
	}	

	public IEnumerator FindNullTiles() {
		for (int x = 0; x < xSize; x++) {
			for (int y = 0; y < ySize; y++) {
				if (tiles[x, y].GetComponent<SpriteRenderer>().sprite == null) {
					yield return StartCoroutine(ShiftTilesDown(x, y));
					break;
				}
			}
		}

		for (int x = 0; x < xSize; x++) {
			for (int y = 0; y < ySize; y++) {
				tiles[x, y].GetComponent<Tile>().ClearAllMatches();
			}
		}		
	}	

	private IEnumerator ShiftTilesDown(int x, int yStart, float shiftDelay = .03f) {
		IsShifting = true;
		List<SpriteRenderer>  renders = new List<SpriteRenderer>();
		int nullCount = 0;

		for (int y = yStart; y < ySize; y++) {  // 1
			SpriteRenderer render = tiles[x, y].GetComponent<SpriteRenderer>();
			if (render.sprite == null) { // 2
				nullCount++;
			}
			renders.Add(render);
		}

		for (int i = 0; i < nullCount; i++) { // 3
			yield return new WaitForSeconds(shiftDelay);// 4
			for (int k = 0; k < renders.Count - 1; k++) { // 5
				renders[k].sprite = renders[k + 1].sprite;
				renders[k + 1].sprite = GetNewSprite(x, ySize - 1);
			}
		}
		IsShifting = false;
	}	

	private Sprite GetNewSprite(int x, int y) {
		List<Sprite> possibleCharacters = new List<Sprite>();
		possibleCharacters.AddRange(characters);

		if (x > 0) {
			possibleCharacters.Remove(tiles[x - 1, y].GetComponent<SpriteRenderer>().sprite);
		}
		if (x < xSize - 1) {
			possibleCharacters.Remove(tiles[x + 1, y].GetComponent<SpriteRenderer>().sprite);
		}
		if (y > 0) {
			possibleCharacters.Remove(tiles[x, y - 1].GetComponent<SpriteRenderer>().sprite);
		}

		return possibleCharacters[Random.Range(0, possibleCharacters.Count)];
	}	
}
