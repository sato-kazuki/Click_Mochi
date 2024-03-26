using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class IndicateButon : MonoBehaviour
{
    public Button Button;
    public GameObject targetGameObject;
    
    public bool isIndicate = false;

    private void SwitchIndicate()
    {
        if (isIndicate)
        {
            targetGameObject.SetActive(false);
            isIndicate = false;
        }
        else
        {
            targetGameObject.SetActive(true);
            isIndicate = true;
        }
    }
    /// <summary>
    /// �ʂ̃{�^������I���I�t�؂�ւ�����ꍇ
    /// </summary>
    public void SwitchFlag()
    {
        if (isIndicate)
        {
            isIndicate = false;
        }else
        {
            isIndicate =true;
        }
    }
}
