using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamesManager : MonoBehaviour {
	public struct index{
		int x;
		int y;
	};

	Queue<index> path = new Queue<index>();
	BoardManager boardManager;
	private void Awake() {
		boardManager = GetComponent<BoardManager>();
		boardManager.startGame();
	}
}
