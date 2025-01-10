using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int life = 3;

    public void AddLife(int amount)
    {
        life += amount;
        Debug.Log("Vida: " + life);
    }
}
