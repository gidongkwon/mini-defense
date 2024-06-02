using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum GameState {
    Ready,
    Playing,
    Finished
}

public class GameManager : MonoBehaviour
{
    private GameState _state;

    void Start()
    {
        _state = GameState.Ready;
    }

    void Update()
    {
        
    }

    public void StartGame() {
        
    }
}
