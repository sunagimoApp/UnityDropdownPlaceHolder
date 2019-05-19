using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample : MonoBehaviour
{
    #region Inspector
    /// <summary>
    /// ドロップダウンプレースホルダー。
    /// </summary>
    [Header("ドロップダウンプレースホルダー")]
    [SerializeField]
    DropdownPlaceHolder dropdownPlaceHolder;
    #endregion

    void Start()
    {
        dropdownPlaceHolder.SetPlaceHolderLbl("Please select");
    }
}
