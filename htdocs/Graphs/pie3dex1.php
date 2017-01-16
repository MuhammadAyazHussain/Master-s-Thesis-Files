<?php // content="text/plain; charset=utf-8"
require_once ('lib/jpgraph/jpgraph.php');
require_once ('lib/jpgraph/jpgraph_pie.php');
require_once ('lib/jpgraph/jpgraph_pie3d.php');

$con = mysql_connect("localhost","root","");

if(!$con){
	
	die("Cannot connect: " . mysql_error());
}

	mysql_select_db("elections");
	$sql = "SELECT * FROM participants4";
	$res = mysql_query($sql);
	
	while($row = mysql_fetch_array($res))
	{
		$data[] = $row['votes3'];
		
	}
	

// Some data
//$data = array(20,27,45,75,90);

// Create the Pie Graph.
$graph = new PieGraph(350,200);
$graph->SetShadow();

// Set A title for the plot
$graph->title->Set("Example 1 3D Pie plot");
$graph->title->SetFont(FF_VERDANA,FS_BOLD,18); 
$graph->title->SetColor("darkblue");
$graph->legend->Pos(0.1,0.2);

// Create pie plot
$p1 = new PiePlot3d($data);
$p1->SetTheme("sand");
$p1->SetCenter(0.4);
$p1->SetAngle(30);
$p1->value->SetFont(FF_ARIAL,FS_NORMAL,12);
$p1->SetLegends(array("Jan","Feb","Mar","Apr","May","Jun","Jul","Aug","Sep","Oct"));

$graph->Add($p1);
$graph->Stroke();

?>


