using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class itemcollected : MonoBehaviour
{
	private void OnMouseDown()
	{
		pickup();
	}
	private void pickup()
	{
		click.instance.addItem(gameObject);
		gameObject.active = false;
	}
	//private void OnTriggerEnter2D(Collider2D collision)
	//{
	//	if (collision.gameObject.name.Equals("Player"))
	//	{
	//		gameObject.active = false;
	//	}
	//}
}
