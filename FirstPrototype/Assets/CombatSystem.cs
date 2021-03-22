using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CombatState { START, PLAYERROLL, PLAYERCOMBAT, ENEMYTURN, WON, LOST }
public class CombatSystem : MonoBehaviour
{
    public bool CanRoll = false; 
    public CombatState state;
    void Start()
    {
        state = CombatState.PLAYERROLL;
        PlayerRollDice();
    }

    void PlayerRollDice()
    {
        CanRoll = true;
    }
}
