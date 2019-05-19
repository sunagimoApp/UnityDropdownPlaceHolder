using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Toggle))]
public class DropdownPlaceHolderItem : MonoBehaviour
{
    void Start()
    {
        var dropdownPlaceHolderComponent = GetComponentInParent<DropdownPlaceHolder>();
        var toggleComponent = GetComponent<Toggle>();

        toggleComponent.onValueChanged.AddListener(delegate(bool isOn)
        {
            if(isOn)
            {
                if(dropdownPlaceHolderComponent != null)
                {
                    dropdownPlaceHolderComponent.OnClickDropdownItem();
                }
            }
        });
    }
}
