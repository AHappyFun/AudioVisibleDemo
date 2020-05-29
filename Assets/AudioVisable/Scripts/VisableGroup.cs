using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisableGroup : MonoBehaviour
{
    public Transform link1;
    public Transform link2;
    public int groupIndex;
    public float mult = 500;

    private void LateUpdate()
    {
        int index = 300 / groupIndex;
        Vector3 link1pos = link1.localPosition;
        Vector3 link2pos = link2.localPosition;

        link1.localPosition = Vector3.Lerp(link1pos, new Vector3(AudioVisable.Instance.samples[index] * mult, AudioVisable.Instance.samples[index] * mult, 0), 0.1f);
        link2.localPosition = Vector3.Lerp(link2pos, new Vector3(-(AudioVisable.Instance.samples[index] * mult), -(AudioVisable.Instance.samples[index] * mult), 0), 0.1f);

    }
}
