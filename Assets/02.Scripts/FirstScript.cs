using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    // �������� ������ Dictionary
    private Dictionary<string, int> items = new Dictionary<string, int>();
    void Start()
    {
        // ������ �߰�
        AddItem("����", 1);
        AddItem("����", 5);
        AddItem("������", 2);
        // ������ ���
        UseItem("����");
        // ������ ��� ���
        PrintInventory();
    }
    void AddItem(string itemName, int quantity)
    {
        if (items.ContainsKey(itemName))
        {
            items[itemName] += quantity;
        }
        //arr_ghtjfk[1] = 1;
        //arr_ghtjfk[1] += 5;
        else
        {
            items.Add(itemName, quantity);
        }
        Debug.Log("�߰� " + quantity + " " + itemName + "(��) �κ��丮��.");
    }
    void UseItem(string itemName)
    {
        if (items.ContainsKey(itemName))
        {
            items[itemName]--;
            if (items[itemName] <= 0)
            {
                items.Remove(itemName);
            }
            Debug.Log("����� ������ : " + itemName + ".");
        }
        else
        {
            Debug.Log("������ " + itemName + " �� �κ��丮���� ã�� �� ����.");
        }
    }
    void PrintInventory()
    {
        foreach (KeyValuePair<string, int> item in items)
        {
            Debug.Log("������ : " + item.Key + ", ���� : " + item.Value);
        }
    }
}