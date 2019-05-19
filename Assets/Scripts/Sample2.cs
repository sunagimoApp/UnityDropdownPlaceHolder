using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Sample2 : MonoBehaviour
{
    /// <summary>
    /// ドロップダウン。
    /// </summary>
    [Header("ドロップダウン")]
    [SerializeField]
    TMP_Dropdown dropdown = default;

    void Start()
    {
        dropdown.options.Insert(0, new TMP_Dropdown.OptionData("Please select"));
        dropdown.value = 0;
    }
}
