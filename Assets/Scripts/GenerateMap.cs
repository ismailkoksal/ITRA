using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateMap : MonoBehaviour
{
    [SerializeField] GameObject mapParent;
    [SerializeField] GameObject tilePrefab;
    [SerializeField] GameObject playerPrefab;

    private GameObject[,] tileList = new GameObject[10, 10];

    void Start()
    {
        InstantiateTiles();
    }

    void InstantiateTiles()
    {
        for (int x = 0; x < 10; x++)
        {
            for (int z = 0; z < 10; z++)
            {
                tileList[x, z] = Instantiate(tilePrefab, new Vector3(x, 0f, z), new Quaternion(), mapParent.transform);
            }
        }
        Instantiate(playerPrefab, new Vector3(0f, 1.3f, 5f), new Quaternion());
    }
}
