using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(TMP_Dropdown))]
public class DropdownPlaceHolder : MonoBehaviour
{
    #region Inspector
    /// <summary>
    /// プレースホルダーラベルカラー。
    /// </summary>
    [SerializeField]
    [Header("プレースホルダーカラー")]
    Color32 placeHolderLblColor = new Color32(50, 50, 50, 255);

    /// <summary>
    /// 通常のラベルカラー。
    /// </summary>
    [Header("通常のラベルカラー")]
    [SerializeField]
    Color32 normalLblColor = new Color32(255, 255, 255, 255);
    #endregion

    #region Param

    /// <summary>
    /// 選択が終了しているか。
    /// </summary>
    public bool IsFinishSelected
    { 
        get { return IsEnabledPlaceHolder; }
    }

    /// <summary>
    /// ドロップダウン。
    /// </summary>
    TMP_Dropdown dropdown;

    /// <summary>
    /// プレースホルダーが有効か。
    /// </summary>
    public bool IsEnabledPlaceHolder { get; private set; } = false;

    /// <summary>
    /// プレースホルダーテキスト。
    /// </summary>
    string placeHolderText = string.Empty;
    #endregion

    /// <summary>
    /// ドロップダウンコンポーネントを取得。
    /// </summary>
    TMP_Dropdown GetDropdownComponent
    {
        get 
        { 
            if(dropdown == null)
            {
                return dropdown = GetComponent<TMP_Dropdown>();
            }
            return dropdown;
        }
    }

    /// <summary>
    /// プレースホルダのラベルを設定。
    /// </summary>
    /// <param name="placeHolderText">プレースホルダーテキスト。</param>
    public void SetPlaceHolderLbl(string placeHolderText)
    {
        this.placeHolderText = placeHolderText;
        IsEnabledPlaceHolder = true;
        GetDropdownComponent.captionText.text = placeHolderText;
        SetPlaceHolderLblStyle();
    }
    
    /// <summary>
    /// ドロップダウンアイテム押下処理。
    /// </summary>
    public void OnClickDropdownItem()
    {
        IsEnabledPlaceHolder = false;
        GetDropdownComponent.captionText.text = dropdown.options[dropdown.value].text;
        SetDefaultLblStyle();
    }

    /// <summary>
    /// プレースホルダーのラベルスタイルセット。
    /// </summary>
    void SetPlaceHolderLblStyle()
    {
        GetDropdownComponent.captionText.fontStyle = FontStyles.Italic;
        GetDropdownComponent.captionText.color = placeHolderLblColor;
    }

    /// <summary>
    /// 通常のラベルスタイルセット
    /// </summary>
    void SetDefaultLblStyle()
    {
        GetDropdownComponent.captionText.fontStyle = FontStyles.Normal;
        GetDropdownComponent.captionText.color = normalLblColor;
    }

    void Update()
    {
        // 画面をアクティブ・非アクティブ時に戻ってしまうためUpdateで更新する。
        if(IsEnabledPlaceHolder)
        {
            GetDropdownComponent.captionText.text = placeHolderText;
        }
    }
}

