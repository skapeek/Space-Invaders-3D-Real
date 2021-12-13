using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShipSelectScreen : MonoBehaviour
{
    public TextMeshProUGUI shipName;
    public TextMeshProUGUI shipName2;
    public TextMeshProUGUI shipName3;
    public Slider speedSlider;
    public Slider shieldSlider;
    public Slider rofSlider;
    public int chosenShip;
    public ShipData[] shipArray;
    public Button left;
    public Button right;
    public GameObject[] shipModels;

    private float speed = 0.01f;
    private float speedSliderValue;

    private void OnEnable()
    {
        left.Select();
        chosenShip = 0;
        speedSlider.value = 0;
        shieldSlider.value = 0;
        rofSlider.value = 0;
    }

    void Update()
    {
        shipName.text = shipArray[chosenShip].spaceshipName;
        shipName2.text = shipArray[chosenShip].spaceshipName;
        shipName3.text = shipArray[chosenShip].spaceshipName;

        speedSlider.value = speedSliderValue;
        if (Input.GetKeyDown(KeyCode.F))
        {
            StartCoroutine(changeSlider());
        }


        if (shieldSlider.value < shipArray[chosenShip].shield)
        {
            shieldSlider.value += Time.deltaTime * speed;
        }
        if (rofSlider.value < shipArray[chosenShip].rof)
        {
            rofSlider.value += Time.deltaTime * speed;
        }
        if (shieldSlider.value > shipArray[chosenShip].shield)
        {
            shieldSlider.value -= Time.deltaTime * speed;
        }
        if (rofSlider.value > shipArray[chosenShip].rof)
        {
            rofSlider.value -= Time.deltaTime * speed;
        }

    }
    IEnumerator changeSlider()
    {
        if (speedSliderValue < shipArray[chosenShip].speed)
        {
            while (speedSliderValue < shipArray[chosenShip].speed)
            {
                speedSliderValue += Mathf.Lerp(speedSliderValue, shipArray[chosenShip].speed, speed);
                yield return null;
            }
        } else if (speedSliderValue > shipArray[chosenShip].speed)
            {
                while (speedSliderValue > shipArray[chosenShip].speed)
                {
                    speedSliderValue += Mathf.Lerp(shipArray[chosenShip].speed, speedSliderValue, speed);
                    yield return null;
                }
            }
    }


    public void changeUP()
    {
        chosenShip++;
        if (chosenShip > 2)
        {
            chosenShip = 0;
        }
    }

    public void changeDOWN()
    {
        chosenShip--;
        if (chosenShip < 0)
        {
            chosenShip = 2;
        }
    }
}
