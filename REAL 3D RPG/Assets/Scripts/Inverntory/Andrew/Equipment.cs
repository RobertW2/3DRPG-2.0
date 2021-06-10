using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InventorySystem
{
    [System.Serializable]
    public struct EquipmentSlot
    {
        [SerializeField] private Item item;
        
        
        public Item EquipedItem
        {
            get
            {
                return item;
            }
            set
            {
                item = value;
                itemEquiped.Invoke(this);
            }
        }
        public Transform visualLocation;
        public Vector3 offset;

        public delegate void ItemsEquiped(EquipmentSlot item); // change to equpment slot
        public event ItemsEquiped itemEquiped;
    }
/*
    void EquipItem ()
    {
        equipment.primary.EquipedItem = selectedItem;
    }
*/
    //Equipment equipment = GetComponent<Equipment>();
   // equipment.primary.EquipedItem = itemIWantToEquip;



    public class Equipment : MonoBehaviour
    {
        public EquipmentSlot primary;
        public EquipmentSlot secondary;
        public EquipmentSlot defensive;

        private void Awake()
        {
            primary.itemEquiped += EquipItem;
            secondary.itemEquiped += EquipItem;
            defensive.itemEquiped += EquipItem;
        }

        private void Start()
        {
            EquipItem(primary);
            EquipItem(secondary);
            EquipItem(defensive);
        }

        public void EquipItem(EquipmentSlot item)
        {
            if(item.visualLocation == null)
            {
                return;
            }
            foreach (Transform child in item.visualLocation)
            {
                GameObject.Destroy(child.gameObject);
            }
            if(item.EquipedItem.Mesh == null)
            {
                return;
            }
            GameObject meshInstance = Instantiate(item.EquipedItem.Mesh, item.visualLocation);
            meshInstance.transform.localPosition = item.offset;
            OffsetLocation offset = meshInstance.GetComponent<OffsetLocation>();
            if(offset != null)
            {
                meshInstance.transform.localPosition += offset.positionOffset;
                meshInstance.transform.localRotation = Quaternion.Euler(offset.rotationOffset);
                meshInstance.transform.localScale = offset.scaleOffset;
            }
        }
    }
}
