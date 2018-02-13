using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlayerA : MonoBehaviour {

	int HP;
	int ATK;
	int DEF;
	private void Start() {
		HP = Random.Range(1,10);
		ATK = Random.Range(1,4);
		DEF = Random.Range(1,4);
	}
}
