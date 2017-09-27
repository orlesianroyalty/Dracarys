#pragma strict


var livesArray;


function Start () {
	livesArray = new Array(Resources.Load("Lives"), Resources.Load("Lives"), Resources.Load("Lives"));
	var xPosition = -31.3;
	for (var i = 0; i < 2; i++) {
		Instantiate(livesArray[0], Vector2(xPosition, -22.7), Quaternion.identity);
		xPosition += 3;
	}
}

function Update () {
	
}
