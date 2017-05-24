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

/**
* Di chuyen man hinh hinh menu sang man hinh home
*/
function backToHome(){
	if (pageSelected == 1){
		document.getElementById("main-content").style.display = "none";
		document.getElementById("right-menu").style.display = "block";
		document.getElementById("mob-toolbar").style.display = "block";
	} else {
		document.getElementById('right-menu').style.display = "none";
		document.getElementById("left-menu").style.display = "block";
		document.getElementById("mob-toolbar").style.display = "none";
	}
	pageSelected = 0;
}

/**
* Di chuyen man hinh hinh menu sang man hinh content
*/
function displayContent(){
	document.getElementById("mob-toolbar").style.display = "block";
	document.getElementById("right-menu").style.display = "none";
	document.getElementById("main-content").style.display = "block";
	pageSelected = 1;
}

/**
* Tu man hinh Hom hien thi man hinh Menu
*/
function displayMenuPage() {
	document.getElementById("mob-toolbar").style.display = "block";
	document.getElementById("left-menu").style.display = "none";
	document.getElementById("right-menu").style.display = "block";
	pageSelected = 0;
}