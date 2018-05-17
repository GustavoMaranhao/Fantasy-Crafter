using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ItemRecipeMaterials
{
    [Tooltip("Required material for the recipe.")]
    public static ItemBase material;
    [Tooltip("Required material amount for the recipe.")]
    public static int requiredAmount;
}

public class ItemBase {
	[Tooltip("Identification for the item.")]
	public static string id { get; private set; }
	[Tooltip("The class of the current item.")]
	public static ItemClassesEnum itemClass;
	[Tooltip("3D model to be used in case it is needed.")]
	public static GameObject model { get; private set; }

	[Tooltip("How much damage an item can take before being destroyed.")]
	public static int durability { get; private set; }

	[Tooltip("The item's required materials.")]
	public static ItemRecipeMaterials[] recipeMaterials { get; private set; }
}
