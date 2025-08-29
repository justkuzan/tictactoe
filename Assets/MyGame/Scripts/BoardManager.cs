using UnityEngine;

public class BoardManager : MonoBehaviour
{
    [SerializeField] public int width = 3;
    [SerializeField] public int height = 3;
    [Space]
    [SerializeField] private GameObject cellPrefab;

    private void Start()
    {
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                Instantiate(cellPrefab, transform);
            }
        }
    }  
}
