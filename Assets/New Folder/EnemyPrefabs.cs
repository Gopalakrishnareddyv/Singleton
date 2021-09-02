using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPrefabs : MonoBehaviour
{
    [SerializeField]
    private EnemyData enemyInfo;
    private PanelInfo panelInfo;
    private void Start()
    {
        panelInfo = GameObject.FindGameObjectWithTag("Panel").GetComponent<PanelInfo>();
    }
    private void OnMouseDown()
    {
        panelInfo.PanelActive();
        panelInfo.nameText.text = enemyInfo.Name;
        panelInfo.healthText.text = enemyInfo.Health.ToString();
        panelInfo.powerText.text = enemyInfo.Power.ToString();
    }
}
