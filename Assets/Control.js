#pragma strict

	var MoveLeft : KeyCode;
	var MoveRight : KeyCode;

	var speed : float = 10;
	
function Update () {

	if (Input.GetKey(MoveLeft))
	{
		rigidbody2D.velocity.x = speed * -1;
	}
	else if (Input.GetKey(MoveRight))
	{
		rigidbody2D.velocity.x = speed;
	}
	else
	{
		
		rigidbody2D.velocity.x = 0;
		rigidbody2D.velocity.y = 0;
	}
}