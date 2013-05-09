#pragma strict

// Bullet Script

// Inspector variables
var bulletSpeed		:float = 15.0;
var heightLimit		:float = 10;
var explosion		:Transform;
var sceneManager	:GameObject;
var fxSound			:AudioClip;

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
		(other.gameObject.GetComponent("script_Asteroid") as script_Asteroid).ResetPosition();
		
		// Create the explosion on impact;
		if (explosion)
		{
			clone = Instantiate(explosion,transform.position, transform.rotation);
			audio.PlayClipAtPoint(fxSound,transform.position);
			Destroy(clone.gameObject,2);
		}


		
		// Inform Scene_Manager an Asteroid was destroyed and update the score		
		(sceneManager.GetComponent("scriptSceneManager") as scriptSceneManager).AddScore();	
		
		// Destroys the bullet
		Destroy(gameObject);
		
	}
}