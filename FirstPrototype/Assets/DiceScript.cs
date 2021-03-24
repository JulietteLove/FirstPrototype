using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceScript : MonoBehaviour
{
    public float NumberRolled;
    public bool ButtonPressed = false;
    public GameObject DiceText;
    public Text ConsoleText;

    public void ButtonClicked()
    {
        ButtonPressed = true;

        CombatSystem combatSystem = GameObject.FindWithTag("CombatSystem").GetComponent<CombatSystem>();

        if (ButtonPressed == true && combatSystem.CanRoll == true)
        {
            NumberRolled = Random.Range(1, 6);
            DiceText.GetComponent<UnityEngine.UI.Text>().text = NumberRolled.ToString("F0");
            ButtonPressed = false;
            
            

            Enemy enemy = GameObject.FindWithTag("Enemy").GetComponent<Enemy>();

            if (enemy.defenceNumber >= NumberRolled) //Enemy defends itself.
            {
                ConsoleText.text = "Miss";
                Invoke("EnemyTurn", 3.0f);
            }
            
            if (enemy.defenceNumber < NumberRolled)
            {
                combatSystem.state = CombatState.PLAYERCOMBAT;
                ConsoleText.text = "Your turn";
            }
            
            combatSystem.CanRoll = false;
        }
    }

    public void EnemyTurn()
    {
        CombatSystem combatSystem = GameObject.FindWithTag("CombatSystem").GetComponent<CombatSystem>();
        combatSystem.state = CombatState.ENEMYTURN;
        ConsoleText.text = "Enemy Turn";
    }
}
