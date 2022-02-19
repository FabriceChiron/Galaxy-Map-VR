using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using SpaceGraphicsToolkit;

public enum PlayMode
{
    FREELOOK,
    STARSHIP
}
public class GameManager : MonoBehaviour
{

    public bool IsPaused;

    [SerializeField]
    private PlayMode _playMode;

    [SerializeField]
    private Scales _freeLookScales, _starshipScales;

    [SerializeField]
    private StellarSystemData _currentSystemData;


    // Start is called before the first frame update
    void Start()
    {
        if (XRSettings.isDeviceActive)
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
