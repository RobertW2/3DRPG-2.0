using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InventorySystem
{
    [System.Serializable]
    public class EquipmentItem : Item
    {
        public PlayerInventory.EquipmentSlot slot = PlayerInventory.EquipmentSlot.Booties;

        public bool isEquipped = false;

        public override void OnClicked()
        {
            base.OnClicked();

            PlayerInventory player = GameObject.FindObjectOfType<PlayerInventory>();
            EquipmentItem oldItem = player.EquipItem(this);
            Inventory inventory = GameObject.FindObjectOfType<Inventory>();

            if(oldItem != null)
            {
                inventory.AddItem(oldItem);
            }

            inventory.RemoveItem(this);
        }
    }
}
