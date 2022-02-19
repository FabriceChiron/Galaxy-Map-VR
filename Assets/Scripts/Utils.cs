using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utils : MonoBehaviour
{
    // Start is called before the first frame update
    public float dimRet(float val, float scale, bool rationalizeValues)
    {
        if (val < 0)
        {
            return -dimRet(-val, scale, rationalizeValues);
        }

        float mult = val / scale;
        float trinum = (Mathf.Sqrt(4.0f * mult + 1.0f) - 1.0f) / 2.0f;

        if (!rationalizeValues)
        {
            return val;
        }
        else
        {
            return trinum * scale;
        }
    }
}
