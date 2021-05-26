using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InventorySystem
{
    [System.Serializable]
    public class Item
    {

        public enum ItemType
        {
            Food,
            Weapon,
            Apparel,
            Crafting,
            Ingredients,
            Potions,
            Scrolls,
            Quest,
            Money

        }


        #region Private variables
        [SerializeField] private string name;  // Item's ID
        [SerializeField] private string description; // Item's ID
        [SerializeField] private int value; // Item's ID
        [SerializeField] private int amount; // Item's ID
        [SerializeField] private Texture2D icon; // Item's ID
        [SerializeField] private GameObject mesh; // Item's ID
        [SerializeField] private ItemType type; // Item's ID
        [SerializeField] private int damage; // Item's ID
        [SerializeField] private int armour; // Item's ID
        [SerializeField] private int heal; // Item's ID
        #endregion

        #region Public properties

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public int Value
        {
            get { return value; }
            set { this.value = value; }
        }

        public int Amount
        {
            get { return amount; }
            set { Amount = value; }
        }

        public Texture2D Icon
        {
            get { return icon; }
            set { icon = value; }
        }

        public GameObject Mesh
        {
            get { return mesh; }
            set { mesh = value; }
        }

        public ItemType Type
        {
            get { return type; }
            set { type = value; }
        }
        
        public int Damage
        {
            get { return damage; }
            set { damage = Mathf.Min(999,value); }
        }
        
        public int Armour
        {
            get { return armour; }
            set { armour = value; }
        }

        public int Heal
        {
            get { return heal; }
            set { heal = value; }
        }
        #endregion

        public void thisIsSomeWhereElse()
        {
            Item myItem = new Item();

            Item anotherItem = new Item(myItem, 5);
        }

        public Item()
        {

        }

        public Item(Item copyItem, int copyAmount)
        {
            Name            = copyItem.Name;
            Description     = copyItem.Description;
            Value           = copyItem.Value;
            Amount          = copyItem.Amount;
            Icon            = copyItem.Icon;
            Mesh            = copyItem.Mesh;
            Type            = copyItem.Type;
            Damage          = copyItem.Damage;
            Armour          = copyItem.Armour;
            Heal            = copyItem.Heal;
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public virtual void OnClicked() => Debug.Log($"Item passed was : {name}!");
    }
}
