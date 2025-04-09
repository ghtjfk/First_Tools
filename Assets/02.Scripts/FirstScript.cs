using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    // 아이템을 관리할 Dictionary
    private Dictionary<string, int> items = new Dictionary<string, int>();
    void Start()
    {
        // 아이템 추가
        AddItem("포션", 1);
        AddItem("포션", 5);
        AddItem("엘릭서", 2);
        // 아이템 사용
        UseItem("포션");
        // 아이템 목록 출력
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
        Debug.Log("추가 " + quantity + " " + itemName + "(을) 인벤토리로.");
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
            Debug.Log("사용한 아이템 : " + itemName + ".");
        }
        else
        {
            Debug.Log("아이템 " + itemName + " 을 인벤토리에서 찾을 수 없음.");
        }
    }
    void PrintInventory()
    {
        foreach (KeyValuePair<string, int> item in items)
        {
            Debug.Log("아이템 : " + item.Key + ", 수량 : " + item.Value);
        }
    }
}