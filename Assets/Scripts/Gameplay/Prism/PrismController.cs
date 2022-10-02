using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrismController : MonoBehaviour
{
    [SerializeField] private SpriteRenderer colorIndicatorSprite;
    [SerializeField] private List<Transform> prismPosition;
    [SerializeField] private LightBeamController lightBeamController;
    [SerializeField] private Collider2D skippableColliders;
    private int indexTranform;
    private ColorController currentColor;
    private ColorEnum currentColorIn;
    private LightBeamController lightIn;
    private void Awake()
    {
        indexTranform = 0;
        currentColor = GetComponent<ColorController>();
        colorIndicatorSprite = GetComponent<SpriteRenderer>();
        colorIndicatorSprite.color = currentColor.GetColor();
        this.transform.position = prismPosition[indexTranform].position;
        this.transform.rotation = prismPosition[indexTranform].rotation;
        currentColorIn = ColorEnum.None;
        indexTranform++;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "LightPoint" && other != skippableColliders)
        {
            // other.gameObject.GetComponent<CircleCollider2D>().enabled = false;
            currentColorIn = other.gameObject.GetComponent<LightMove>().LightBeamController.CurrentColor._Color;
            lightIn = other.gameObject.GetComponent<LightMove>().LightBeamController;
            LightBeamTurnOn();
            CheckColor(currentColorIn);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "LightPoint" && other != skippableColliders)
        {
            LightBeamTurnOff();
        }
    }
    private void OnMouseDown()
    {
        currentColor.ChangeColorOnPrism();
        colorIndicatorSprite.color = currentColor.GetColor();
        RotatePrism();
    }
    private void RotatePrism()
    {
        Debug.Log("Clicou");

        this.transform.position = prismPosition[indexTranform].position;
        this.transform.rotation = prismPosition[indexTranform].rotation;

        if (currentColorIn != ColorEnum.None)
        {
            CheckColor(currentColorIn);
        }

        indexTranform++;
        
        if (indexTranform == prismPosition.Count)
        {
            indexTranform = 0;
        }
    }
    public void LightBeamTurnOn()
    {
        lightBeamController.gameObject.transform.parent.transform.gameObject.SetActive(true);
    }
    public void CheckColor(ColorEnum colorIn)
    {
        lightBeamController.CurrentColor.MixColors(currentColor._Color, colorIn);
        lightBeamController.UpdateColor();
        Debug.Log("Checou Cor");
    }
    public void LightBeamTurnOff()
    {
        lightBeamController.gameObject.transform.parent.transform.gameObject.SetActive(false);
        currentColorIn = ColorEnum.None;
    }
    private void Update()
    {
        if (lightBeamController.gameObject.activeInHierarchy)
        {
            CheckColor(lightIn.CurrentColor._Color);
        }
    }

}
