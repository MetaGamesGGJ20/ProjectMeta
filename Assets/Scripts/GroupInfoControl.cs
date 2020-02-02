using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroupInfoControl : MonoBehaviour
{
    public void CloseButton()
    {
        gameObject.SetActive(false);
    }

    public void OpenPanel()
    {
        gameObject.SetActive(true);
    }
}
