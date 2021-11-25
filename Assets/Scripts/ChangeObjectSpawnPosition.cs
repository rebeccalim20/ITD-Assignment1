using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.UI;

public class ChangeObjectSpawnPosition : MonoBehaviour
{
    [SerializeField] private List<GameObject> _stageList;
    [SerializeField] private Transform _stageTransform;
    [SerializeField] private ContentPositioningBehaviour _planeGameobject;
    [SerializeField] private GameObject _planeFinder;

    public Text inventoryNameChange;
    public int inventoryNumberTracker;

    private int _currIndex = 0;

    private void Awake()
    {
        _planeGameobject.GetComponent<ContentPositioningBehaviour>();
    }

    private void Start()
    {
        inventoryNumberTracker = 0;
        int child = _stageTransform.childCount;

        for (int i = 0; i < child; i++)
        {
            _stageList.Add(_stageTransform.GetChild(i).gameObject);
        }
        
    }

    public void OnButtonPressed()
    {
        ChangeIndex();

        

        if (inventoryNumberTracker == 0)
        {
            inventoryNameChange.text = "Syringe";
            inventoryNumberTracker = 1;
        }
        else if(inventoryNumberTracker == 1)
        {
            inventoryNameChange.text = "Hand Sanitiser";
            inventoryNumberTracker = 2;
        }
        else if (inventoryNumberTracker == 2)
        {
            inventoryNameChange.text = "Mask";
            inventoryNumberTracker = 3;
        }
        else if (inventoryNumberTracker == 3)
        {
            inventoryNameChange.text = "Virus";
            inventoryNumberTracker = 0;
        } 
        

        if (_planeFinder != null && !_planeFinder.activeSelf)
        {
            _planeFinder.SetActive(true);
        }
    }

    private void ChangeIndex()
    {
        int objectAmount = _stageList.Count;

        if (_currIndex == objectAmount - 1)
        {
            _currIndex = 0; 
        }
        else
        {
            _currIndex++; 
        }

        for (int i = 0; i < objectAmount; i++)
        {
            if (i == _currIndex)
            {
                
                _planeGameobject.AnchorStage = _stageList[i].GetComponent<AnchorBehaviour>();
            }
        }
    }
}