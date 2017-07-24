<?php
$data = json_decode(file_get_contents("php://input"));

$firstname = mysql_real_escape_string($data->$firstname);
$lastname = mysql_real_escape_string($data->$lastname);
$ccnumber = mysql_real_escape_string($data->$ccnumber);
$billaddr = mysql_real_escape_string($data->$billaddr);
$city = mysql_real_escape_string($data->$city);
$state = mysql_real_escape_string($data->$state);
$zipcode = mysql_real_escape_string($data->$zipcode);
$cvv = mysql_real_escape_string($data->$cvv);
$expmonth = mysql_real_escape_string($data->$expmonth);
$expyear = mysql_real_escape_string($data->$expyear);

mysql_connect("localhost", "root", ""); 
mysql_select_db("CreditCard");

mysqli_query("INSERT INTO CreditCard (FirstName, LastName, CCNumber, BillAddr, City, State, ZipCode, CVV, ExpMonth, ExpYear) VALUES ('"$firstname"','"$lastname"','"$ccnumber"','"$billaddr"', '"$city"','"$state"','"$zipcode"','"$cvv"','"$expmonth"','"$expyear"')");
?>
