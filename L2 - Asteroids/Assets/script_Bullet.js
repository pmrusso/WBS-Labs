#pragma strict
// Bullet Script

// Inspector variables
var bulletSpeed		:float = 15.0;
var heightLimit		:float = 10;
var explosion		:Transform;

// Private variables
private var clone	: Transform;

function Start () {

}

function Update () {
	transform.Translate(0,bulletSpeed*Time.deltaTime,0);
	
	if (transform.position.y >= heightLimit)
	{
		Destroy(gameObject);
	}
}

function OnTriggerEnter(other: Collider)
{
	
	// Check for the asteroid
	if (other.gameObject.tag == "asteroid")
	{
		// "Destroys" the asteroid and resets it's position
		var script : script_Asteroid;
		script = other.gameObject.GetComponent("script_Asteroid");
		script.ResetPosition();
		
		// Create the explosion on impact;
		if (explosion)
		{
			clone = Instantiate(explosion,transform.position, transform.rotation);
			Destroy(clone.gameObject,2);
		}
		
		// Destroys the bullet
		Destroy(gameObject);
		
	}
}