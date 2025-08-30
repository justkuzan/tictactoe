using System;
using UnityEngine;
using UnityEngine.UI;

public class Cell : MonoBehaviour
{
    private State _cellState;
    [SerializeField] private Sprite imageCross;
    [SerializeField] private Sprite imageCircle;
    private void Awake()
    {
        _cellState = State.Empty;
    }

    private void Start()
    {
        Button button = GetComponent<Button>();
        if (_cellState == State.Empty)
        {
            button.onClick.AddListener(Cross);
        }
        else
        {
            // button.colors.normalColor = new Color(255, 255, 255, 1f);
        }
    }
    
    public enum State
    {
        Empty,
        Cross,
        Circle,
    }

    private void Cross()
    {
        _cellState = State.Cross;
        Button button = GetComponent<Button>();
        button.image.sprite = imageCross;
    }

    public void Circle()
    {
        _cellState = State.Circle;
        Button button = GetComponent<Button>();
        button.image.sprite = imageCircle;
    }
    
}
