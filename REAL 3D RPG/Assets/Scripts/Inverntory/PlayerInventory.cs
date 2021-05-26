using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InventorySystem
{
    public class PlayerInventory : MonoBehaviour
    {
        public enum EquipmentSlot
        {
            Helmet,
            Chestplate,
            Pantaloons,
            Booties,
            Weapon,
            Shield

        }

        private Dictionary<EquipmentSlot, EquipmentItem> slots = new Dictionary<EquipmentSlot, EquipmentItem>();

        // Start is called before the first frame update
        void Start()
        {
            foreach(EquipmentSlot slot in System.Enum.GetValues(typeof(EquipmentSlot)))
            {
                slots.Add(slot, null);
            }
        }

        public EquipmentItem EquipItem(EquipmentItem _toEquip)
        {
            // Attempt to get ANYTHING out of the slot, be it null or not
            if (slots.TryGetValue(_toEquip.slot, out EquipmentItem item))
            {
                // Create a copy of the original, set the slot item to the passed value
                EquipmentItem original = item;
                slots[_toEquip.slot] = _toEquip;

                // Return what was iriginally in the slot to prevent loosing items when equipping
                return original;
            }

            // Somehow the slot didn't exist, so lets create it and return null as no item 
            // would be in the slot anyway

            slots.Add(_toEquip.slot, _toEquip);
            return null;
           
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
