using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceScript : MonoBehaviour
{
    private float NumberRolled;
    public bool ButtonPressed = false;
    public GameObject DiceText;

    public void ButtonClicked()
    {
        ButtonPressed = true;

        if (ButtonPressed == true)
        {
            NumberRolled = Random.Range(1f, 6f);
            DiceText.GetComponent<UnityEngine.UI.Text>().text = NumberRolled.ToString("F0");
            ButtonPressed = false;
        }
    }
}
