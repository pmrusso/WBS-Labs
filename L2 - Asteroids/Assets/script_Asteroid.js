#pragma strict

// Asteroid Script

// Inspector variable
var asteroidSpeed	:float = 6.0;
var initialHeight	:float = 8.0;
var resetHeight		:float = -8.0;
var horizontalRange	:float = 7.0;
var explosion		:Transform;

// Private variable
private var clone	:Transform;

function Start () {

}

function Update () {
	transform.Translate(Vector3.down*asteroidSpeed*Time.deltaTime);
	
	if (transform.position.y <= resetHeight)
	{
		ResetPosition();
	}
}

function ResetPosition()
{
	// Reset the position of the asteroid
	transform.position.y = initialHeight;
	transform.position.x = Random.Range(-horizontalRange,horizontalRange);
}

function OnTriggerEnter(other: Collider)
{	
	if (other.tag == "Player")
	{
		var script :script_Player;
		script = other.GetComponent("script_Player");
		script.lives -= 1;
		
	    // other.GetComponent("script_Player").lives += 5; Why, oh why doesn't it work. 
		
		if (explosion) {
			clone = Instantiate(explosion,transform.position, transform.rotation);
			Destroy(clone.gameObject,2.0);
		}
		
		ResetPosition();
		
	}
}

