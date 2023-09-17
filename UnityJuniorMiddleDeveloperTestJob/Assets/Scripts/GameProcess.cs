using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class GameProcess : MonoBehaviour
{
    // ���� ������ ��� ��� �������� �����, ���� �������� � ���� ��� ��� ����
    // �� ����� ������� ����� +2 ����
    // ����� ����� �������� 100 ����� ���� �������������

    [SerializeField]
    private TMP_Text _title;

    public GameObject cannon;
    public GameObject crystal;
    public GameObject monster;

    void Start()
    {
        _title.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        if (cannon != null || crystal != null || monster != null)
            return;

        
    }
}
