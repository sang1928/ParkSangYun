using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIStartPage : MonoBehaviour
{
    private Canvas _canvas;

    public void SetCanvas(Canvas canvas)
    {
        _canvas = canvas;
    }

    private Button _startButton;

    void Start()
    {
        Button startButton = GetComponentInChildren<Button>();

        startButton.onClick.AddListener(GameStart);

        /*Text buttonText = GetComponentInChildren<Text>();
        buttonText.text = "�ٲ� �ؽ�Ʈ";*/

    }

    private void Update()
    {
        float alpha = GetComponent<Image>().color.a;

        GetComponent<Image>().color = new Color(0,0,0, alpha + Time.deltaTime );
    }

    public void GameStart()
    {
        Debug.Log("���� ����");

        // �̷����� �ִ��� �ҷ��ͺ���.
        GameObject uiPage = Resources.Load<GameObject>("Prefab/UIIngamePage");

        Debug.Log(uiPage); // Null

        GameObject ui = Instantiate(uiPage); // Scene �� ���������  ���Դ�.

        UIIngamePage comp = ui.GetComponent<UIIngamePage>();
        comp.SetCanvas(_canvas);

        ui.transform.SetParent(_canvas.transform);

        (ui.transform as RectTransform).offsetMin = Vector3.zero;
        (ui.transform as RectTransform).offsetMax = Vector3.zero;

    }

}
