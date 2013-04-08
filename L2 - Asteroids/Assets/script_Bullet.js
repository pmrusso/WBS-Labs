#pragma strict
// Bullet Script

// Inspector variables
var bulletSpeed		:float = 15.0;
var heightLimit	:float = 10;

// Private variables


function Start () {

}

function Update () {
	transform.Translate(0,bulletSpeed*Time.deltaTime,0);
	
	if (transform.position.y >= heightLimit)
	{
		Destroy(gameObject);
	}
}