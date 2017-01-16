<?php
	$servername = "localhost";
	$username = "root";
	$password = "";
	$dbName = "university_1_34";
	//$person = array(
		//'ID' => .$row['ID'],
		//'Name' => .$row['Name'],
		//'Type' => .$row['Type'],
		//'Number' => .$row['Number'],
	
	//);
	
	//Make Connection
	$conn = new mysqli($servername,$username,$password,$dbName);
	
	if(!$conn){
		die("Connection Failed. ". mysqli_connect_error());
	}
	
	$sql = "SELECT ID, Name, Type, Number FROM items";
	$result = mysqli_query($conn ,$sql);
	
	if(mysqli_num_rows($result) > 0){
		//show data for each row
		while($row = mysqli_fetch_assoc($result)){
			//echo '<pre>', print_r($person,true), '</pre>';
			echo "ID:".$row['ID'] . "|Name:".$row['Name']. "|Type:".$row['Type']. "|Number:".$row['Number'] . ";";
		}
	}
?>