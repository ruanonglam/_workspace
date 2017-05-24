function displayMenu(id){
	hideMenu();
	if (id != null)
		document.getElementById(id).style.display = "block";
}

function hideMenu()
{
	for (var i = 1; i < 8; i++) {
		document.getElementById("item" + i).style.display = "none";
	}

}