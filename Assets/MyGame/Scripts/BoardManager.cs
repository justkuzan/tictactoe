using UnityEngine;

public class BoardManager : MonoBehaviour
{
    [SerializeField] public GameObject cell;
    private GameObject[,] _cellPrefabs =  new GameObject[3,3];
    private int width = 3;
    private int height = 3;

    private void Start()
    {
        for (int i = 0; i < _cellPrefabs.GetLength(0); i++)
        {
            for (int j = 0; j < _cellPrefabs.GetLength(1); j++)
            {
                _cellPrefabs[i,j] = cell;
            }
        }
        
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                GameObject prefabToSpawn = _cellPrefabs[i,j];
                Instantiate(prefabToSpawn, transform);
            }
        }
    }  
    
    
    
    // private void Start()
    // {
    //     for (int i = 0; i < width; i++)
    //     {
    //         for (int j = 0; j < height; j++)
    //         {
    //             int random = Random.Range(0, crystalPrefabs.Length);
    //             GameObject prefabToSpawn = crystalPrefabs[random];
    //             Instantiate(prefabToSpawn, new Vector3(i, j, 0), Quaternion.identity, transform);
    //         }
    //     }
    // }  
}
