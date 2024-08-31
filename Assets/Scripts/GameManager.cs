using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;

    public static GameManager GetInstance()
    {
        if(_instance == null)
        {
            _instance = FindObjectOfType<GameManager>();
        }

        return _instance;
    }


    public Canvas canva;


 
    void Start()
    {
        

        Debug.Log(" ���� �ϴ°� Ȯ��");
        CreateStartPage();
    }

    private void Update()
    {
        /*if(Input.GetKeyDown(KeyCode.A))
        {
            // �̷����� �ִ��� �ҷ��ͺ���.
            GameObject uiPage = Resources.Load<GameObject>("Prefab/UIResultPage");

            Debug.Log(uiPage); // Null

            GameObject ui = Instantiate(uiPage);

            ui.transform.SetParent(canva.transform);
            (ui.transform as RectTransform).offsetMin = Vector3.zero;
            (ui.transform as RectTransform).offsetMax = Vector3.zero;
        }*/

    }


    private void CreateStartPage()
    {
        // �̷����� �ִ��� �ҷ��ͺ���.
        GameObject uiPage = Resources.Load<GameObject>("Prefab/UIStartPage");

        Debug.Log(uiPage); // Null

        GameObject ui = Instantiate(uiPage);

        ui.transform.SetParent(canva.transform);

        // ������Ʈ���� ����ó��, ��Ŀó�����ϱ� ����
        (ui.transform as RectTransform).offsetMin = Vector3.zero;
        (ui.transform as RectTransform).offsetMax = Vector3.zero;

        UIStartPage comp = ui.GetComponent<UIStartPage>();
        comp.SetCanvas(canva);
    }

    
}
