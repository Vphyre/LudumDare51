using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorController : MonoBehaviour
{
    [SerializeField] private List<Transform> mirrorPosition;
    // [SerializeField] private List<Transform> destinationPosition;
    [SerializeField] private Transform destination;
    [SerializeField] private LightBeamController lightBeamController;
    [SerializeField] private Collider2D skippableCollider;
    [Range(0, 2)]
    [SerializeField] private int StartPosition = 1;
    private int indexTranform;
    private LightBeamController lightIn;
    private ColorEnum currentColorIn;

    private void OnEnable()
    {

    }
    private void OnDisable()
    {
  
    }
    private void Awake()
    {
        indexTranform = 0;
        this.transform.position = mirrorPosition[StartPosition].position;
        this.transform.rotation = mirrorPosition[StartPosition].rotation;
        currentColorIn = ColorEnum.None;
        indexTranform++;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "LightPoint" && other != skippableCollider)
        {
            // other.gameObject.GetComponent<CircleCollider2D>().enabled = false;
            Debug.Log("Colidiu");
            currentColorIn = other.gameObject.GetComponent<LightMove>().LightBeamController.CurrentColor._Color;
            lightIn = other.gameObject.GetComponent<LightMove>().LightBeamController;
            LightBeamTurnOn();
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "LightPoint" && other != skippableCollider)
        {
            // other.gameObject.GetComponent<CircleCollider2D>().enabled = false;
            LightBeamTurnOff();
        }
    }
    private void OnMouseDown()
    {
        RotateMirror();
    }
    private void RotateMirror()
    {
        Debug.Log("Clicou");
        // transform.Rotate(0.0f, 0.0f, rotateAngle, Space.World);
        this.transform.position = mirrorPosition[indexTranform].position;
        this.transform.rotation = mirrorPosition[indexTranform].rotation;

        SetDestination();

        indexTranform++;

        if (indexTranform == mirrorPosition.Count)
        {
            indexTranform = 0;
        }
    }
    public void LightBeamTurnOn()
    {
        lightBeamController.gameObject.transform.parent.transform.gameObject.SetActive(true);
        SetDestination();
    }
    public void LightBeamTurnOff()
    {
        lightBeamController.gameObject.transform.parent.transform.gameObject.SetActive(false);
        currentColorIn = ColorEnum.None;
    }
    private void SetDestination()
    {
        // lightBeamController.LightMove.Destination = destinationPosition[indexTranform];
        lightBeamController.LightMove.Destination = destination;
    }
    private void Update()
    {
        if (lightBeamController.gameObject.activeInHierarchy)
        {
            lightBeamController.CurrentColor._Color = lightIn.CurrentColor._Color;
            lightBeamController.UpdateColor();
        }
    }
    // private void DisableBehaviour()
    // {
    //     this.enabled = false;
    // }
}

