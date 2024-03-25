using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Resolution : MonoBehaviour
{
    //private void Awake()
    //{
    //    Camera camera = GetComponent<Camera>();
    //    Rect rect = camera.rect;
    //    float scaleheight = ((float)Screen.width / Screen.height) / ((float)16 / 9);
    //    float scalewidth = 1f / scaleheight;
    //    if (scaleheight<1)
    //    {
    //        rect.height = scaleheight;
    //        rect.y = (1f - scaleheight) / 2f;
    //    }
    //    else
    //    {
    //        rect.width = scalewidth;
    //        rect.x = (1f - scalewidth) / 2f;
    //    }
    //    camera.rect = rect;
    //}


    private void Start()
    {
        float targetAspect = 1920.0f / 1080.0f;
        float windowAspect = (float)Screen.width / (float)Screen.height;
        float scaleHeight = windowAspect / targetAspect;
        Rect rect = Camera.main.rect;

        if (scaleHeight < 1.0f)
        {
            rect.width = 1.0f;
            rect.height = scaleHeight;
            rect.x = 0;
            rect.y = (1.0f - scaleHeight) / 2.0f;
        }
        else
        {
            float scalewidth = 1.0f / scaleHeight;
            rect.width = scalewidth;
            rect.height = 1.0f;
            rect.x = (1.0f - scalewidth) / 2.0f;
            rect.y = 0;
        }

        Camera.main.rect = rect;
    }
    //private void Awake()
    //{
    //    SetResolution(1920, 1080);
    //}

    //void SetCanvasScaler(int _width, int _height)
    //{
    //    CanvasScaler canvasScaler = FindObjectOfType<CanvasScaler>();
    //    // CanvasScaler ������Ʈ�� ���� ������Ʈ�� ã�Ƽ� ����
    //    canvasScaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
    //    canvasScaler.referenceResolution = new Vector2(_width, _height);
    //    canvasScaler.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand; // Ȯ��
    //}
    //void SetResolution(int width = 1920, int height = 1080)
    //{
    //    SetCanvasScaler(width, height);

    //    int deviceWidth = Screen.width; // ����� �ػ� �ʺ�
    //    int deviceHeight = Screen.height; // ����� �ػ� ����

    //    Screen.SetResolution(width, (int)(((float)deviceHeight / deviceWidth) * width), true);
    //    // �ػ� ����

    //    if ((float)width / height < (float)deviceWidth / deviceHeight)
    //    {// ���� ����� �ػ󵵺� �� ũ�ٸ�
    //        float newWidth = ((float)width / height) / ((float)deviceWidth / deviceHeight);
    //        Camera.main.rect = new Rect((1f - newWidth) / 2f, 0f, newWidth, 1f);
    //        // ����ī�޶��� ViewPortRect�� ����
    //        // Rect : X, Y, W, H ��
    //    }
    //    else
    //    {// ����ȭ���� �ػ󵵺� �� ũ�ٸ�
    //        float newHeight = ((float)deviceWidth / deviceHeight) / ((float)width / height);
    //        Camera.main.rect = new Rect(0f, (1f - newHeight) / 2f, 1f, newHeight);

    //    }
    //}
}
