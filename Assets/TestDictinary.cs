using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDictinary : MonoBehaviour
{
	private Dictionary<string, int> collectedItems = new Dictionary<string, int>();

	private void CollectItem(string itemName)
	{
		if (collectedItems.ContainsKey(itemName))
		{
			collectedItems[itemName] += 1;
		}
		else
		{
			collectedItems[itemName] = 1;
		}

		Debug.Log("Collected " + itemName + " (Total: " + collectedItems[itemName] + ")");
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			CollectItem("Key");
		}
		else if (Input.GetKeyDown(KeyCode.L))
		{
			CollectItem("Lamp");
		}
		else if (Input.GetKeyDown(KeyCode.C))
		{
			CollectItem("Coin");
		}
		else if (Input.GetKeyDown(KeyCode.R))
		{
			CollectItem("Ring");
		}
		else if (Input.GetKeyDown(KeyCode.K))
		{
			printItem();
		}
	}
	private void printItem()
	{
		foreach (KeyValuePair<string, int> item in collectedItems)
		{
			Debug.Log(item.Key);
			Debug.Log(item.Value);
		}
	}
}
