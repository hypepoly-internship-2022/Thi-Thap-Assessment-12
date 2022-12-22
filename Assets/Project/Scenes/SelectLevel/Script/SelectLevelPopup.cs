using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SelectLevelPopup : MonoBehaviour
{

    [SerializeField] private GameObject levelBtnPrefab;
    [SerializeField] private GameObject selectlevelBtnPrefab;

    [SerializeField] private Transform inventory;
    [SerializeField] private int levelBlockUWant;

    // Start is called before the first frame update
    private void Start()
    {
        spawnLevelBtn();
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

     private void spawnLevelBtn()
     {
        for (int i = 1; i < levelBlockUWant; i++)
        {
            if (i==1)
            {
                btnPrefab(i, true);
            }
            else
            {
                btnPrefab(i, false);
            }
        }
        void btnPrefab( int index, bool isActive)
        {
            GameObject levelButton;
            TextMeshProUGUI levelIndex;
            if (isActive)
            {
                levelButton = Instantiate(levelBtnPrefab, inventory).gameObject;
            }
            else
            {               
                levelButton = Instantiate(selectlevelBtnPrefab, inventory).gameObject;

            }
            levelIndex = levelButton.GetComponentInChildren<TextMeshProUGUI>();
            levelIndex.text = index.ToString();
        }

    
    }
}
