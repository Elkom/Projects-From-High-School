<!DOCTYPE html>
<html lang="en">
	<head>
		<meta charset="utf-8">
		<meta http-equiv="X-UA-Compatible" content="IE=edge">
		<meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="shortcut icon" href="favicon.ico">
		<title>SoftaWare</title>

 		<!-- Google font -->
 		<link href="https://fonts.googleapis.com/css?family=Montserrat:400,500,700" rel="stylesheet">

 		<!-- Bootstrap -->
 		<link type="text/css" rel="stylesheet" href="css/bootstrap.min.css"/>

 		<!-- Slick -->
 		<link type="text/css" rel="stylesheet" href="css/slick.css"/>
 		<link type="text/css" rel="stylesheet" href="css/slick-theme.css"/>

 		<!-- nouislider -->
 		<link type="text/css" rel="stylesheet" href="css/nouislider.min.css"/>

 		<!-- Font Awesome Icon -->
 		<link rel="stylesheet" href="css/font-awesome.min.css">

 		<!-- Custom stlylesheet -->
 		<link type="text/css" rel="stylesheet" href="css/style.css"/>

		<script src="js/konami.js"></script>

 		<!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
 		<!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
 		<!--[if lt IE 9]>
 		  <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
 		  <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
 		<![endif]-->

    </head>
	<body>
		<!-- HEADER -->
		<header>
			<!-- TOP HEADER -->
			<div id="top-header">
				<div class="container">
					<ul class="header-links pull-left">
						<li><a href="#"><i class="fa fa-phone"></i> 060-321-3705</a></li>
						<li><a href="#"><i class="fa fa-envelope-o"></i> support@softaware.com</a></li>
						<li><a href="#"><i class="fa fa-map-marker"></i> Nasa adresa</a></li>
					</ul>
					<ul class="header-links pull-right">
						<li><a href="#"><i class="fa fa-dollar"></i> USD</a></li>
						<li>
							<?PHP
								session_start();
								if (!(isset($_SESSION['login']) && $_SESSION['login'] != '')) {
									print("<a href=\"loginpage.php\"><i class=\"fa fa-user-o\"></i> Moj Profil - Log IN</a>");
									print("</li>");
								}
								else {
									print("<a href=\"korisnik.php\"><i class=\"fa fa-user-o\"></i> ");
									print($_SESSION['username']);
									print("</a></li>");
									print("<li><a href=\"logout.php\"><i class=\"fa fa-power-off\"></i> Odjava</a></li>");
								}
							?>
					</ul>
				</div>
			</div>
			<!-- /TOP HEADER -->

			<!-- MAIN HEADER -->
			<div id="header">
				<!-- container -->
				<div class="container">
					<!-- row -->
					<div class="row">
						<!-- LOGO -->
						<div class="col-md-3">
							<div class="header-logo">
								<a href="index.php" class="logo">
									<img src="./img/logo.png" alt="">
								</a>
							</div>
						</div>
						<!-- /LOGO -->

						<!-- SEARCH BAR -->
						<div class="col-md-6">
							<div class="header-search">
								<form>
									<select class="input-select">
										<option value="0">All Categories</option>
										<option value="1">Laptops</option>
										<option value="1">Cameras</option>
										<option value="3">Headphones</option>
									</select>
									<input class="input" placeholder="Pretrazi">
									<button class="search-btn">Pretrazi</button>
								</form>
							</div>
						</div>
						<!-- /SEARCH BAR -->

						<!-- ACCOUNT -->
						<div class="col-md-3 clearfix">
							<div class="header-ctn">

								<!-- Menu Toogle -->
								<div class="menu-toggle">
									<a href="#">
										<i class="fa fa-bars"></i>
										<span>Menu</span>
									</a>
								</div>
								<!-- /Menu Toogle -->
							</div>
						</div>
						<!-- /ACCOUNT -->
					</div>
					<!-- row -->
				</div>
				<!-- container -->
			</div>
			<!-- /MAIN HEADER -->
		</header>
		<!-- /HEADER -->

		<!-- NAVIGATION -->
		<nav id="navigation">
			<!-- container -->
			<div class="container">
				<!-- responsive-nav -->
				<div id="responsive-nav">
					<!-- NAV -->
					<ul class="main-nav nav navbar-nav">
						<li class="active"><a href="#">Početak</a></li>
						<li><a href="akcija.php">Akcija</a></li>
						<li><a href="kategorije.php">Kategorije</a></li>
						<li><a href="laptopi.php">Laptopi</a></li>
						<li><a href="pametniTelefoni.php">Pametni Telefoni</a></li>
						<li><a href="kamere.php">Kamere</a></li>
						<li><a href="dodaci.php">Dodaci</a></li>
					</ul>
					<!-- /NAV -->
				</div>
				<!-- /responsive-nav -->
			</div>
			<!-- /container -->
		</nav>
		<!-- /NAVIGATION -->

		<!-- SECTION -->
		<div class="section">
			<!-- container -->
			<div class="container">
				<!-- row -->
				<div class="row">
					<center>
						<div id="er404">
							<h1>404</h1>
							<h2>Oh, noes! Someone took my nose!</h2>
							<h3>This page does not exist</h3>
						</div>
					</center>
				</div>
				<!-- /row -->
			</div>
			<!-- /container -->
		</div>
		<!-- /SECTION -->

		<!-- NEWSLETTER -->
		<div id="newsletter" class="section">
			<!-- container -->
			<div class="container">
				<!-- row -->
				<div class="row">
					<div class="col-md-12">
						<div class="newsletter">
							<p>Prijavi se na <strong><a name="newslet">NEWSLETTER</a></strong></p>
							<?php
								if(isset($_POST['submitNews'])){
									include("conn.php");
									if($_SERVER['REQUEST_METHOD'] == 'POST'){
										$email = mysqli_real_escape_string($con, $_POST['email']);
										$querymail = mysqli_query($con, "SELECT * FROM newsletter WHERE email = '$email'");
										$checkmail = mysqli_num_rows($querymail);
										if($checkmail != 0){
											echo "<h2>Greška, ".$email." je vec u upotrebi</h2>";
											echo "<br><a href=\"custom404.php\">Pokušajte ponovo</a>";
										}
										else{
											$insert_email = mysqli_query($con, "INSERT INTO newsletter (email) VALUES ('$email')");
											if($insert_email)
												echo "<h1>Uspješno ste se prijavili</h1>";
											else
												echo "<h2>Greška prilikom prijave</h2>";
											echo "<script type=\"text/javascript\">",
												   "window.location.hash = \"newslet\"",
													 "</script>";
										}
									}
								}
								else{
							?>
							<form action="custom404.php" method="post">
								<input class="input" type="email" placeholder="Enter Your Email" name="email">
								<button type="submit" name="submitNews" class="newsletter-btn"><i class="fa fa-envelope"></i> Prijavi se</button>
							</form>
							<?php
								}
							?>
							<ul class="newsletter-follow">
								<li>
									<a href="#"><i class="fa fa-facebook"></i></a>
								</li>
								<li>
									<a href="#"><i class="fa fa-twitter"></i></a>
								</li>
								<li>
									<a href="#"><i class="fa fa-instagram"></i></a>
								</li>
								<li>
									<a href="#"><i class="fa fa-pinterest"></i></a>
								</li>
							</ul>
						</div>
					</div>
				</div>
				<!-- /row -->
			</div>
			<!-- /container -->
		</div>
		<!-- /NEWSLETTER -->

		<!-- FOOTER -->
		<footer id="footer">
			<!-- top footer -->
			<div class="section">
				<!-- container -->
				<div class="container">
					<!-- row -->
					<div class="row">
						<div class="col-md-3 col-xs-6">
							<div class="footer">
								<h3 class="footer-title">O nama</h3>
								<p>Mi smo SoftaWare prodavnica hardverske opreme</p>
								<ul class="footer-links">
									<li><a href="#"><i class="fa fa-map-marker"></i>Nasa adresa</a></li>
									<li><a href="#"><i class="fa fa-phone"></i>060-321-3705</a></li>
									<li><a href="#"><i class="fa fa-envelope-o"></i>support@softaware.com</a></li>
								</ul>
							</div>
						</div>

						<div class="col-md-3 col-xs-6">
							<div class="footer">
								<h3 class="footer-title">Kategorije</h3>
								<ul class="footer-links">
									<li><a href="#">Akcija</a></li>
									<li><a href="#">Laptopi</a></li>
									<li><a href="#">Pametni Telefoni</a></li>
									<li><a href="#">Kamere</a></li>
									<li><a href="#">Dodaci</a></li>
								</ul>
							</div>
						</div>

						<div class="clearfix visible-xs"></div>

						<div class="col-md-3 col-xs-6">
							<div class="footer">
								<h3 class="footer-title">Infomacije</h3>
								<ul class="footer-links">
									<li><a href="#">O nama</a></li>
									<li><a href="#">Kontaktirajte nas</a></li>
									<li><a href="#">Privacy Policy</a></li>
									<li><a href="#">Narudžbe i povratnice</a></li>
									<li><a href="#">Terms & Conditions</a></li>
								</ul>
							</div>
						</div>

						<div class="col-md-3 col-xs-6">
							<div class="footer">
								<h3 class="footer-title">Servisi</h3>
								<ul class="footer-links">
									<li><a href="#">Moj Profil</a></li>
									<li><a href="#">Pogledaj korpu</a></li>
									<li><a href="#">Lista želja</a></li>
									<li><a href="#">Prati narudžbu</a></li>
									<li><a href="#">Pomoć</a></li>
								</ul>
							</div>
						</div>
					</div>
					<!-- /row -->
				</div>
				<!-- /container -->
			</div>
			<!-- /top footer -->

			<!-- bottom footer -->
			<div id="bottom-footer" class="section">
				<div class="container">
					<!-- row -->
					<div class="row">
						<div class="col-md-12 text-center">
							<ul class="footer-payments">
								<li><a href="#"><i class="fa fa-cc-visa"></i></a></li>
								<li><a href="#"><i class="fa fa-credit-card"></i></a></li>
								<li><a href="#"><i class="fa fa-cc-paypal"></i></a></li>
								<li><a href="#"><i class="fa fa-cc-mastercard"></i></a></li>
								<li><a href="#"><i class="fa fa-cc-discover"></i></a></li>
								<li><a href="#"><i class="fa fa-cc-amex"></i></a></li>
							</ul>
							<span class="copyright">
								Copyright &copy;<script>document.write(new Date().getFullYear());</script> All rights reserved
							</span>


						</div>
					</div>
						<!-- /row -->
				</div>
				<!-- /container -->
			</div>
			<!-- /bottom footer -->
		</footer>
		<!-- /FOOTER -->

		<!-- jQuery Plugins -->
		<script src="js/jquery.min.js"></script>
		<script src="js/bootstrap.min.js"></script>
		<script src="js/slick.min.js"></script>
		<script src="js/nouislider.min.js"></script>
		<script src="js/jquery.zoom.min.js"></script>
		<script src="js/main.js"></script>

	</body>
</html>
