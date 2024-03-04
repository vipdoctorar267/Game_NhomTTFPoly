using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VIST;
using UnityEngine.UI;
using System.Linq;

public class InventoryManager : Singleton<InventoryManager>
{
    [SerializeField] Transform _gridLayout;
    [SerializeField] List<ItemInventoryBase> _items = new List<ItemInventoryBase>();

    List<Transform> _itemSlot = new List<Transform>();
    public List<ItemInventoryBase> items => _items;
    // Start is called before the first frame update
    void Start()
    {
        _itemSlot = _gridLayout.GetComponentsInChildren<Transform>().ToList();
        _itemSlot.RemoveAt(0);
        Init();
    }

    void Init ()
    {
        int i = 0;
        foreach(ItemInventoryBase item in _items)
        {
            Instantiate(item.gameObject, _itemSlot[i]);
            i++;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
