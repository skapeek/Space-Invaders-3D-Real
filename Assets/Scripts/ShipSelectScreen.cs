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
    public GameObject[] selectedShip;

    private float speed = 0.03f;

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


        if (speedSlider.value < (shipArray[chosenShip].speed - 0.09))
        {
            speedSlider.value += Mathf.Lerp(0, shipArray[chosenShip].speed, speed); //primero: 0, 5, 0.1;  segundo: 0, 8, 0.1;
        }
        if (speedSlider.value > (shipArray[chosenShip].speed + 0.09))
        {
            //speedSlider.value -= Mathf.Lerp(shipArray[chosenShip].speed, speedSlider.value, speed); //tercero: 2, 8, 0.1
            speedSlider.value -= Time.deltaTime * 25;
        }

        if (shieldSlider.value < (shipArray[chosenShip].shield - 0.09))
        {
            shieldSlider.value += Mathf.Lerp(0, shipArray[chosenShip].shield, speed);
        }
        if (shieldSlider.value > (shipArray[chosenShip].shield + 0.09))
        {
            shieldSlider.value -= Time.deltaTime * 25;
        }

        if (rofSlider.value < (shipArray[chosenShip].rof - 0.09))
        {
            rofSlider.value += Mathf.Lerp(0, shipArray[chosenShip].rof, speed);
        }
        if (rofSlider.value > (shipArray[chosenShip].rof + 0.09))
        {
            rofSlider.value -= Time.deltaTime * 25;
        }

        if (chosenShip == 0)
        {
            selectedShip[0].SetActive(true);
            selectedShip[1].SetActive(false);
            selectedShip[2].SetActive(false);
        }
        if (chosenShip == 1)
        {
            selectedShip[0].SetActive(false);
            selectedShip[1].SetActive(true);
            selectedShip[2].SetActive(false);
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
