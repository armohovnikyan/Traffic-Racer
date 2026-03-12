using System;
using UnityEngine;

public class GameEvents : MonoBehaviour 
{
    public static event Action OnStart;
    public static event Action OnPlay;
    public static event Action OnGameEnd;


    public static void RaiseOnStart()
    {
        OnStart?.Invoke();
    }

    public static void RaiseOnPlay()
    {
        OnPlay?.Invoke();
    }

    public static void RaiseOnGameEnd()
    {
        OnGameEnd?.Invoke();
    }
}
