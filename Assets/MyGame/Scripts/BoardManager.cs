using UnityEngine;

public class BoardManager : MonoBehaviour
{
    [SerializeField] public GameObject cell;
    private GameObject[,] _cells =  new GameObject[3,3];

    private void Start()
    {
        for (int i = 0; i < _cells.GetLength(0); i++)
        {
            for (int j = 0; j < _cells.GetLength(1); j++)
            {
                _cells[i,j] = Instantiate(cell, transform);
                Debug.Log(_cells[i,j]);
            }
        }
    }
}