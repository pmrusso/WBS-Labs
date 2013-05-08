#pragma strict

// Asteroid Script

// Inspector variable
var asteroidSpeed	:float = 6.0;
var initialHeight	:float = 8.0;
var resetHeight		:float = -8.0;
var horizontalRange	:float = 7.0;
var explosion		:Transform;
var sceneManager	:GameObject;

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
		
	    //(other.GetComponent("script_player") as script_Player).lives -= 1;
		
		if (explosion) {
			clone = Instantiate(explosion,transform.position, transform.rotation);
			Destroy(clone.gameObject,2.0);
		}
		
		ResetPosition();
		
		(sceneManager.GetComponent("scriptSceneManager") as scriptSceneManager).DecreaseLives();
		
	}
	
	if (other.tag == "shield")
	{
		//(other.transform.parent.GetComponent("script_Player") as script_Player).shieldOn = false;
	
		if (explosion) {
			clone = Instantiate(explosion,transform.position, transform.rotation);
			Destroy(clone.gameObject,2.0);
		}
		
		ResetPosition();
	}
}

