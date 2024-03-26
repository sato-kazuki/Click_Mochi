using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.PackageManager;
using UnityEngine;

public class SCScreenChange : MonoBehaviour
{
    private static int sceneStatus;

    public SCScreenImage scScreenImage;

    /// <summary>
    /// �X�N���[���؂�ւ����i���o�[�ő��M
    /// </summary>
    /// <param name="IsRight">�E���ŏ���</param>
    public void OnButtonClick(bool IsRight)
    {
        int listMaxLength = scScreenImage.sceneNames.Count;
        if (IsRight)
        {
            //�E���Ŕ͈͊O�ɍs�����͍ŏ��Ԗڂɖ߂�
            sceneStatus = sceneStatus + 1 > listMaxLength ? 1 : sceneStatus++;
            scScreenImage.ChangeScreenNum(sceneStatus);
        }
        else
        {
            //�����Ŕ͈͊O�ɍs�����͍ő�Ԗڂɖ߂�
            sceneStatus = sceneStatus - 1 < 1 ? listMaxLength : sceneStatus--;
            scScreenImage.ChangeScreenNum(sceneStatus);
        }

    }
}