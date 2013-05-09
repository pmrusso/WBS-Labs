#pragma strict

// Player Script

// Inspector Variables
var lives					: int 	= 3;
var playerSpeedVertical		: float = 10.0;
var playerSpeedHorizontal	: float = 10.0;
var horizontalMin			: float = -6.0;
var horizontalMax			: float = 6.0;
var verticalMin				: float = -4.0;
var verticalMax				: float = 4.0;
var projectile				: Transform;
var socketProjetile			: Transform;
var numberOfShields			: int = 4;	
var shieldMesh				: Transform;
var shieldKeyInput			: KeyCode;
var shieldOn				: boolean = false;
var socketJet				: Transform;

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
	
	// Fire Bullet
	if (Input.GetKeyDown("space"))
	{
		Instantiate(projectile, socketProjetile.position, socketProjetile.rotation);
		audio.Play();
	}
	
	
	// Deploy Shield
	if (Input.GetKeyDown(shieldKeyInput) && !shieldOn)
	{
		var clone = Instantiate(shieldMesh, transform.position, transform.rotation);
		clone.transform.parent = gameObject.transform;
		shieldOn = true;
	}
	
	if ((this.transform.GetComponentInChildren(scriptShield) as scriptShield) == null){
		shieldOn = false;
	}
}