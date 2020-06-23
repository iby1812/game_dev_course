using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{

    [SerializeField] Text itemTextF;
    [SerializeField] PickedItem pickedItemList;
    [SerializeField] string itemName;

    public bool shouldBeDestroyed;

    private bool pickedItem = false;
    private bool nearTheItem = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && nearTheItem && shouldBeDestroyed)
        {
            itemTextF.gameObject.SetActive(false);
            pickedItemList.pickedItemsList.Add(itemName, true);
            pickedItem = true;

            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            nearTheItem = true;
            itemTextF.text = "F";
            itemTextF.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            nearTheItem = false;
            itemTextF.gameObject.SetActive(false);
        }

    }

    public bool ItemPicked()
    {
        return pickedItem;
    }

    public bool IsPlayerNearItem()
    {
        return nearTheItem;
    }

    public void SetTextActive(bool active)
    {
        itemTextF.gameObject.SetActive(active);
    }

    public void SetText(string text)
    {
        itemTextF.text = text;
    }

    public void SetTextSize(int size)
    {
        itemTextF.fontSize = size;
    }
}
