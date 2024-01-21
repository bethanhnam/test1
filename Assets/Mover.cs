using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Mover : MonoBehaviour
{
	public Vector3[] positions;
	int currentPosition;
	private void Start()
	{
		transform.position = positions[0];
		currentPosition = 0;
	}
	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			if (currentPosition >= positions.Length)
			{
				currentPosition = 0;
			}
			else
			{
				move(currentPosition);
				currentPosition++;
			}
			
			Debug.Log(currentPosition);
		}
	}
	public void move(int i)
	{
		transform.position = positions[i];
	}
	//   float speed =3f;
	//   public Vector3 playerPosition;
	//   public List<GameObject> collectItems = new List<GameObject>();
	//   Rigidbody2D rigidbody2D;
	//   void Start()
	//   {
	//       rigidbody2D = GetComponent<Rigidbody2D>();
	//       playerPosition = transform.position;
	//   }

	//   // Update is called once per frame
	//   void Update()
	//   {
	//       if (Input.GetKeyDown(KeyCode.I))
	//       {
	//           printfItems();
	//       }
	//}
	//void FixedUpdate()
	//{
	//	float x = Input.GetAxisRaw("Horizontal");
	//	float y = Input.GetAxisRaw("Vertical");

	//	transform.position += new Vector3(x, y, 0) * Time.deltaTime *speed;
	//}

	//private void OnTriggerEnter2D(Collider2D collision)
	//{
	//	if(collision.gameObject.tag == "item")
	//       {
	//           collectItems.Add(collision.gameObject);

	//       }
	//}
	//   public void printfItems()
	//   {
	//	foreach (GameObject gameObject in collectItems)
	//	{
	//		Debug.Log(gameObject.name);
	//	}
	//}
}
