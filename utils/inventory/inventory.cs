using Godot;
using Godot.Collections;
using System;
using Hideaway.Resources;
using System.Linq;

namespace Hideaway.Utils
{
    // this represents the player's inventory
    public partial class Inventory: Node
    {

        Dictionary<string, InventoryItem> items = new Dictionary<string, InventoryItem>();

        string[] itemNames = new string[]{};

        public override void _Ready()
        {
            base._Ready();
        }

        // add an item to the inventory
        public void AddItem(InventoryItem item)
        {
            items.Add(item.Name, item);
            itemNames.Append(item.Name);

        }

        // remove an item to the inventory
        public void RemoveItem(InventoryItem item)
        {

            items.Remove(item.Name);

            // iterate through the itemNames array and remove the item
            for (int i = 0; i < itemNames.Length; i++)
            {
                if (itemNames[i] == item.Name)
                {
                    itemNames = itemNames.Where((val, idx) => idx != i).ToArray();
                }
            }

        }

        // get all items in the inventory
        public string[] GetAllItemNames()
        {

            return itemNames;
        }

    }
}