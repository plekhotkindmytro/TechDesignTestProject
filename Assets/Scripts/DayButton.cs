using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayButton : MonoBehaviour
{
    public void Day()
    {
        SceneController.Instance.LoadDayScene();
    }
}
