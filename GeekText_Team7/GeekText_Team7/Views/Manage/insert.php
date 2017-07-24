<?php
$dbhost = "localhost";
$dbuser = "root";
$dbpass = "password";
$dbname = "[dbo.CreditCard]";
$connection = mysqli_connect($dbhost, $dbuser, $dbpass, $dbname);

$firstname = $_POST['firstname'];
$lastname = $_POST['lastname'];
$ccnumber = $_POST['ccnumber'];
$billaddr = $_POST['billaddr'];
$city = $_POST['city'];
$state = $_POST['state'];
$zipcode = $_POST['zipcode'];
$cvv = $_POST['cvv'];
$expmonth = $_POST['expmonth'];
$expyear = $_POST['expyear'];

$firstname = mysqli_real_escape_string($connection, $firstname);
$lastname = mysqli_real_escape_string($connection, $lastname);
$ccnumber = mysqli_real_escape_string($connection, $ccnumber);
$billaddr = mysqli_real_escape_string($connection, $billaddr);
$city = mysqli_real_escape_string($connection, $city);
$state = mysqli_real_escape_string($connection, $state);
$zipcode = mysqli_real_escape_string($connection, $zipcode);
$cvv = mysqli_real_escape_string($connection, $cvv);
$expmonth = mysqli_real_escape_string($connection, $expmonth);
$expyear = mysqli_real_escape_string($connection, $expyear);

$query = "INSERT INTO [dbo.CreditCard] (FirstName, LastName, CCNumber, BillAddr, City, State, ZipCode, CVV, ExpMonth, ExpYear) VALUES ('"$firstname"','"$lastname"','"$ccnumber"','"$billaddr"', '"$city"','"$state"','"$zipcode"','"$cvv"','"$expmonth"','"$expyear"')";

$result = mysqli_query($connection, $query);
?>
