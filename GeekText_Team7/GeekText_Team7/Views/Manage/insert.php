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
$cvv = $_POST['cvv'];
$expmonth = $_POST['expmonth'];
$expyear = $_POST['expyear'];

$firstname = mysqli_real_escape_string($connection, $firstname);
$lastname = mysqli_real_escape_string($connection, $lastname);
$ccnumber = mysqli_real_escape_string($connection, $ccnumber);
$billaddr = mysqli_real_escape_string($connection, $billaddr);
$cvv = mysqli_real_escape_string($connection, $cvv);
$expmonth = mysqli_real_escape_string($connection, $expmonth);
$expyear = mysqli_real_escape_string($connection, $expyear);

$query = "INSERT INTO [dbo.CreditCard] (FirstName, LastName, CCNumber, BillAddr, CVV, ExpMonth, ExpYear) VALUES ('"$firstname"','"$lastname"','"$ccnumber"','"$billaddr"','"$cvv"','"$expmonth"','"$expyear"' )";

$result = mysqli_query($connection, $query);

if ($result) {
header('Location: insert.php');
        } else {
            die("Database query failed. " . mysqli_error($connection)); 
?>
