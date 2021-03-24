using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum CombatState { START, PLAYERROLL, PLAYERCOMBAT, ENEMYTURN, WON, LOST }
public class CombatSystem : MonoBehaviour
{
    public bool CanRoll = false; 
    public CombatState state;

    public GameObject MeleeAttackButton;
    public GameObject FireballAttackButton;

    void Start()
    {
        state = CombatState.PLAYERROLL;
        PlayerRollDice();
    }

    void Update()
    {
        Player player = GameObject.FindWithTag("Player").GetComponent<Player>();
        Enemy enemy = GameObject.FindWithTag("Enemy").GetComponent<Enemy>();
        DiceScript diceScript = GameObject.FindWithTag("Dice").GetComponent<DiceScript>();

        if (state == CombatState.PLAYERCOMBAT)         
        {
            Debug.Log("I am in combat");
            MeleeAttackButton.SetActive(true);
            FireballAttackButton.SetActive(true);
        }
        else
        {
            MeleeAttackButton.SetActive(false);
            FireballAttackButton.SetActive(false);
        }
    }

    void PlayerRollDice()
    {
        CanRoll = true;
    }
}
