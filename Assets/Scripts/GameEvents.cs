using System;
using UnityEngine;

public static class GameEvents
{
    public static event Action OnStart;      // Инициализация сцены
    public static event Action OnPlay;       // Начало игры (кнопка Play)
    public static event Action OnRestart;    // Перезапуск
    public static event Action OnGameEnd;    // Конец игры

    public static void RaiseOnStart() => OnStart?.Invoke();
    public static void RaiseOnPlay() => OnPlay?.Invoke();
    public static void RaiseOnRestart() => OnRestart?.Invoke();
    public static void RaiseOnGameEnd() => OnGameEnd?.Invoke();
}