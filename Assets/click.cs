using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click : MonoBehaviour
{
	public static click instance;
	[SerializeField]private List<GameObject> collectedItems = new List<GameObject>();

	private void Start()
	{
		if(instance == null)
		{
			instance = this;
		}
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.K))
		{
			printItem();
		}
	}

	
	public void addItem(GameObject item)
	{
		collectedItems.Add(item);
	}
	public void removeItem(GameObject item)
	{
		collectedItems.Remove(item);
	}
	private void printItem()
	{
		foreach(GameObject item in collectedItems)
		{
			Debug.Log(item.name);
		}
	}
}
