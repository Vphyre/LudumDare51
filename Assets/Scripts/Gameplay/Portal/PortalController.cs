using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalController : MonoBehaviour
{
    [SerializeField] private SpriteRenderer colorIndicatorSprite;
    [SerializeField] private List<Transform> portalPositions;
    [SerializeField] private bool canChangeColor = false;
    [SerializeField] private bool canTeleport = false;
    [SerializeField] private int healthPoints = 1;
    public int indexTranform = 1;
    private ColorController currentColor;
    private ColorEnum currentColorIn;
    private LightBeamController lightIn;
    private bool checkingColor;

    private void Awake()
    {
        currentColor = GetComponent<ColorController>();
        colorIndicatorSprite = GetComponent<SpriteRenderer>();
        colorIndicatorSprite.color = currentColor.GetColor();

        if (canChangeColor)
        {
            GameManager.onChangeTime += ChangeColor;
        }
        if (canTeleport)
        {
            GameManager.onChangeTime += ChangePosition;
        }
    }
    private void OnDisable()
    {
        if (canChangeColor)
        {
            GameManager.onChangeTime -= ChangeColor;
        }
        if (canTeleport)
        {
            GameManager.onChangeTime -= ChangePosition;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "LightPoint")
        {
            lightIn = other.gameObject.GetComponent<LightMove>().LightBeamController;
            checkingColor = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "LightPoint" )
        {
            checkingColor = false;
        }
    }

    void Update()
    {
        if (checkingColor)
        {
            CheckColor(lightIn.CurrentColor._Color);
        }
    }
    private void ChangeColor()
    {
        currentColor.ChangeColorNormal();
        colorIndicatorSprite.color = currentColor.GetColor();
    }
    private void ChangePosition()
    {
        this.transform.position = portalPositions[indexTranform].position;

        indexTranform++;

        if (indexTranform == portalPositions.Count)
        {
            indexTranform = 0;
        }
    }
    public void CheckColor(ColorEnum colorIn)
    {
        if (currentColor._Color == colorIn)
        {
            healthPoints--;
            ChangeColor();
            VerifyEndGame();
        }
    }
    public void VerifyEndGame()
    {
        if (healthPoints <= 0)
        {
            Debug.Log("Terminou a fase");
        }
    }
}
