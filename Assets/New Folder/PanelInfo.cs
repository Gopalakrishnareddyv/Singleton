using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelInfo : MonoBehaviour
{
    public GameObject panel;
    public Text nameText;
    public Text healthText;
    public Text powerText;

    public void PanelActive()
    {
        panel.SetActive(true);
    }
}
