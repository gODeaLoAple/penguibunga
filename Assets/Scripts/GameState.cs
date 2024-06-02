using System.Collections.Generic;
using UnityEngine;

public static class GameState
{
    public static bool IsOverGameWires;
    public static bool IsOverGameKeyboard = true;
    public static bool HaveCrowbar = true;
    public static bool IsNowTextDisplayed;
    public static bool IsOpenKeyboardGame;
    public static bool CanOpenToiletDoor;
    public static Player ActivePlayer;

    public static Vector3 PlatformerSpawn = new(0 , 0, 0);
    public static HashSet<DialogFlagEnum> ChecksBool = new()
    {
        DialogFlagEnum.Ventilation,
        DialogFlagEnum.None
    };

    public static AudioClip CurrentMusic;
}