<?php
	$servername = "localhost";
	$username = "root";
	$password = "";
	$dbName = "add_yt_rpg";
	
	//Make Connection
	$conn = new mysqli($servername, $username, $password, $dbName);
	//Check Connection
	if(!$conn){
		die("Connection Failed. ". mysqli_connect_error());
	}
	
	$sql = "SELECT ID, Name, Type, Cost FROM items";
	$result = mysqli_query($conn ,$sql);
	
	





//echo json_encode($jsonData);
while($row = mysqli_fetch_assoc($result)){
	$data[] = $row;	
}

foreach($data as $key => $row){
	$jsonData[] = array($row['Cost']/$row['ID']);// 'b' => $row['Cost'], 'c' => 3, 'd' => 4, 'e' => 5);
}
			
echo json_encode($jsonData);

?>