<?php
  $dbhost     = "localhost";
  $dbname     = "softaware";
  $dbuser     = "manager";
  $dbpass     = "admin";
  $con = mysqli_connect($dbhost, $dbuser, $dbpass) or die("Can't connect");
  mysqli_select_db($con, $dbname) or die(mysqli_error($con));
 ?>
