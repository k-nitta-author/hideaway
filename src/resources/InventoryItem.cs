using Godot;
using System;
using System.Runtime.CompilerServices;

namespace Hideaway.Resources
{
    public partial class InventoryItem: Resource{

        public string Name { get; set; }
        public string Description { get; set; }

        public Texture Icon {get; set;}
    }
}