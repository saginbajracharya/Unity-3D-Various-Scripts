//Script made by StrupsGames

var text : GameObject;

function Start () {

text.SetActive(false); 
}

function OnTriggerEnter () { 
text.SetActive (true); 
}

function OnTriggerExit () { 
text.SetActive(false);
}

function Update () 
{
	if(Input.GetKeyDown(KeyCode.E)) // You can choose any button, im using the button E, rename it if you want a diffrent button to use.
	Application.LoadLevel("TUTORIAL 2"); // Type the name of your scene.
}		