using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StellarObject : MonoBehaviour
{
    [SerializeField]
    private float Orbit;

    [SerializeField]
    private float RevolutionPeriod;

    [SerializeField]
    private float RotationPeriod;

    [SerializeField]
    private Transform _stellarBody;

    [SerializeField]
    private GameManager _gameManager;

    // Start is called before the first frame update
    void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
        Debug.Log(_gameManager);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        
    }

    public void RotateObject(Transform objTransform, float RotationTime, bool inverted)
    {

        //RotationTime = Mathf.Max(RotationTime, 0.01f);
        float degreesPerSecond = 360f / RotationTime * (inverted ? 1f : -1f);
        objTransform.Rotate(new Vector3(0, degreesPerSecond * Time.deltaTime, 0));
    }
}
