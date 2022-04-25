using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collections : MonoBehaviour
{
    private static int Item_Collected;

    private static bool is_Gold_Collected;

    [SerializeField] private GameObject Gold_Value;
    private TextMesh Gold_Value_Text;

    [SerializeField] private GameObject Golds;
    private int Gold_Count;

    public Collections()
    {
        Item_Collected = 0;
        is_Gold_Collected = false;
    }

    public int get_Item_Collected()
    {
        return Item_Collected;
    }

    public void set_Item_Collected(int value)
    {
        Item_Collected = value;
    }

    public bool get_Gold_Collected()
    {
        return is_Gold_Collected;
    }

    public void set_Gold_Collected(bool value)
    {
        is_Gold_Collected = value;
    }
    
    void Start()
    {
        
        Gold_Count = Golds.transform.childCount;
        // Debug.Log(Gold_Count);
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("gold"))
        {
            other.gameObject.SetActive(false);
            Collect_Item();
            set_Gold_Collected(true);   
        }
    }

    void Collect_Item()
    {
        Item_Collected += 1;
    }
}
