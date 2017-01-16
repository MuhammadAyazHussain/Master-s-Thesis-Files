<?php // content="text/plain; charset=utf-8"

require_once ('lib/jpgraph/jpgraph.php');
require_once ('lib/jpgraph/jpgraph_bar.php');

$con = mysql_connect("localhost","root","");

if(!$con){
	
	die("Cannot connect: " . mysql_error());
}

	mysql_select_db("elections");
	$sql = "SELECT * FROM participants3";
	$res = mysql_query($sql);
	
	while($row = mysql_fetch_array($res))
	{
		$data1y[] = $row['votes1'];
		$data2y[] = $row['votes2'];
		
	}
	




//$data1y=array(-8,8,9,3,5,6);
//$data2y=array(18,2,1,7,5,4);

$data1y = json_encode($data1y);
$data2y = json_encode($data2y);

// Create the graph. These two calls are always required
$graph = new Graph(500,400); 
$graph->SetScale("textlin");

$graph->SetShadow();
$graph->img->SetMargin(40,30,20,40);

// Create the bar plots
$b1plot = new BarPlot($data1y);
$b1plot->SetFillColor("orange");
$b1plot->value->Show();
$b2plot = new BarPlot($data2y);
$b2plot->SetFillColor("blue");
$b2plot->value->Show();

// Create the grouped bar plot
$gbplot = new AccBarPlot(array($b1plot,$b2plot));

// ...and add it to the graPH
$graph->Add($gbplot);

$graph->title->Set("Accumulated bar plots");
$graph->xaxis->title->Set("X-title");
$graph->yaxis->title->Set("Y-title");

$graph->title->SetFont(FF_FONT1,FS_BOLD);
$graph->yaxis->title->SetFont(FF_FONT1,FS_BOLD);
$graph->xaxis->title->SetFont(FF_FONT1,FS_BOLD);

// Display the graph
$graph->Stroke();
?>
