using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightButton : MonoBehaviour
{
    public void Night()
    {
        SceneController.Instance.LoadNightScene();
    }
}
