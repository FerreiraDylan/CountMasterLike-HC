using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject GroundGroup;
    public GameObject Group;
    public GameObject[] groundTile;
    public Vector3 nextSpawnerPoint;
    public int value;

    public List<int> LgroundTiles;

    // Start is called before the first frame update
    void Start()
    {
        LgroundTiles.Add(1);
        for (int i = 0; i != value - 1; i++)
        {
            LgroundTiles.Add(Random.Range(1, 6));
        }
        LgroundTiles.Add(0);
        for (int i = 0; i != LgroundTiles.Count; i++)
        {
            if (LgroundTiles[i] == 2)
                SpawnTileUnits(groundTile[LgroundTiles[i]]);
            else
                SpawnTile(groundTile[LgroundTiles[i]]);
        }
    }

    // Generate GroundTile
    public void SpawnTile(GameObject obj)
    {
        GameObject tmp = Instantiate(obj, nextSpawnerPoint, Quaternion.identity);
        tmp.transform.SetParent(GroundGroup.transform);
        nextSpawnerPoint = tmp.transform.GetChild(1).transform.position;
    }

    // Generate GroundTile with Units
    public void SpawnTileUnits(GameObject obj)
    {
        GameObject tmp = Instantiate(obj, nextSpawnerPoint, Quaternion.identity);
        tmp.GetComponent<Add_Variables>().ParentSpawnUnit = Group;
        tmp.transform.SetParent(GroundGroup.transform);
        nextSpawnerPoint = tmp.transform.GetChild(1).transform.position;
    }
}
