#pragma strict

// Player Script

// Inspector Variables
var playerSpeedVertical		: float = 10.0;
var playerSpeedHorizontal	: float = 10.0;
var horizontalMin			: float = -6.0;
var horizontalMax			: float = 6.0;
var verticalMin				: float = -4.0;
var verticalMax				: float = 4.0;
var projectile				: Transform;

// Private Variables


function Start () {

}

function Update () {
	// Move player based on input
	
	var transV: float = Input.GetAxis("Vertical")*playerSpeedVertical*Time.deltaTime;
	var transH: float = Input.GetAxis("Horizontal")*playerSpeedHorizontal*Time.deltaTime;
	
	transform.Translate(transH,transV,0);
	
	// Limit the range of movement
	
	transform.position.x = Mathf.Clamp(transform.position.x,horizontalMin,horizontalMax);
	transform.position.y = Mathf.Clamp(transform.position.y,verticalMin,verticalMax);
	
	if (Input.GetKeyDown("space"))
	{
		Instantiate(projectile,
	}
	
}