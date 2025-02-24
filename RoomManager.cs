using UnityEngine;

public class RoomManager : MonoBehaviour
{
    public GameObject[] theDoors;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        theDoors[0].SetActive(Core.northDoor);
        theDoors[1].SetActive(Core.southDoor);
        theDoors[2].SetActive(Core.eastDoor);
        theDoors[3].SetActive(Core.westDoor);
    }
   
    // Update is called once per frame

    void Update( )

    { 


    }

}