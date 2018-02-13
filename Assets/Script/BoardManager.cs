using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BoardManager : MonoBehaviour {

    public struct Cords{
		int x;
		int y;

        public Cords(int p1, int p2){
            x = p1;
            y = p2;
        }
	}
	public int colum;
	public int row;

	List<Cords> gridPosition = new List<Cords>();

    public GameObject cam;
    public GameObject[] enemys;
    public GameObject wall;

    public Transform walls;

	void gridGenneration(){
        gridPosition.Clear();
		for(int x = 1; x < colum+1; x++){
            for (int y = 1; y < row + 1; y++)
            {
                gridPosition.Add(new Cords(x,y));
            }
		}
	}
    void genWall()
    {
        for(int x = -1; x <= colum+1; x++)
        {
            for(int y = -1; y <= row+1; y++)
            {   
                if(y == -1 || y == row + 1 || x == -1 || x == colum+1)
                {
                    GameObject wallI = Instantiate(wall,new Vector3(x,y,0),Quaternion.identity,walls) as GameObject;
                }
                    
            }
        }
    }

    public void startGame()
    {
        Vector3 camPos = cam.transform.position;
        cam.transform.position = new Vector3(colum / 2f, row / 2f,camPos.z);
        genWall();
    }

    public void swanedUnit(){
        
    }
}
