using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemName {Nail, Brick, Screwdriver}

public class Item : MonoBehaviour
{
    public Sprite sprite;
    public ItemName itemName;
}