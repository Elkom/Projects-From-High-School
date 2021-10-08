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
								<!-- Wishlist -->
								<div>
									<a href="wishlist.php">
										<i class="fa fa-heart-o"></i>
										<span>Lista želja</span>
										<!-- <div class="qty">2</div> -->
									</a>
								</div>
								<!-- /Wishlist -->

                <!-- Cart -->
								<div class="dropdown">
									<a class="dropdown-toggle" data-toggle="dropdown" aria-expanded="true">
										<i class="fa fa-shopping-cart"></i>
										<span>Vaša korpa</span>
									 	<!-- <div class="qty">3</div> -->
									</a>
									<div class="cart-dropdown">
										<div class="cart-list">
											<?php
											if(isset($_COOKIE["shopping_cart"])){
											 $total = 0;
											 $cookie_data = stripslashes($_COOKIE['shopping_cart']);
											 $cart_data = json_decode($cookie_data, true);
											 foreach($cart_data as $keys => $values){
											 ?>
											<div class="product-widget">
												<div class="product-img">
													<img src="./img/<?php echo $values["item_image"]; ?>.png" alt="">
												</div>
												<div class="product-body">
													<h3 class="product-name"><a href="#"><?php echo $values["item_name"]; ?></a></h3>
													<h5 class="product-price">
														<span class="qty"><?php echo $values["item_quantity"]; ?></span>
														$ <?php echo $values["item_price"]; ?>
														<br><a href="index.php?action=delete&id=<?php echo $values["item_id"]; ?>">Ukloni</a>
													</h5>
												</div>
											</div>
											<?php
											  $total = $total  + ($values["item_quantity"] * $values["item_price"]);
											 }
											 ?>
										</div>
										<div class="cart-summary">
											<h5>Total: $ <?php echo number_format($total, 2); ?></h5>
										</div>
										<?php
											}
										 ?>
										<div class="cart-btns">
											<a href="#">Pogledaj Korpu</a>
											<a href="#">Kupi  <i class="fa fa-arrow-circle-right"></i></a>
										</div>
									</div>
								</div>
								<!-- /Cart -->

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

		<!-- BREADCRUMB -->
		<div id="breadcrumb" class="section">
			<!-- container -->
			<div class="container">
				<!-- row -->
				<div class="row">
					<div class="col-md-12">
            <?php
              if (!(isset($_SESSION['login']) && $_SESSION['login'] != ''))
                echo "<h3 class=\"breadcrumb-header\">Korisnički profil</h3>";
              else
                echo "<h3 class=\"breadcrumb-header\">Korisnički profil - ", $_SESSION['username'], "</h3>";
             ?>
					</div>
				</div>
				<!-- /row -->
			</div>
			<!-- /container -->
		</div>
		<!-- /BREADCRUMB -->

		<!-- SECTION -->
		<div class="section">
			<!-- container -->
			<div class="container">
				<!-- row -->
				<div class="row">

          <?php
            include("conn.php");
            if(!(isset($_SESSION['login']) && $_SESSION['login'] != '')) {
              ?>
              <center>
    						<div>
    							<h1>Korisnik nije prijavljen</h1>
    							<h2><a href="loginpage.php">Morate se prijaviti</a></h2>
    						</div>
    					</center>
              <?php
            }
            else{
              ?>
              <center>
                <div class="col-md-1">
                  <!-- Spacer -->
                </div>
                <div class="col-md-5">
                  <h3>Vaš email</h3>
                  <?php
                    $username = $_SESSION['username'];
                    $userinfo = mysqli_query($con, "SELECT * FROM users WHERE username = '$username'");
                    $checkuser = mysqli_num_rows($userinfo);
                    $dataarr = $userinfo -> fetch_assoc();
                    if($checkuser == 1){
                      echo "<h4>".$dataarr['email']."</h4>";
                    }
                    else{
                      echo "Error: došlo je do greške";
                    }
                   ?>
                   <!-- TODO: Add email change -->
                </div>
                <div class="col-md-1">
                  <!-- Spacer -->
                </div>
                <div class="col-md-4">
                  <h3>Promijenite šifru</h3>
                  <?php
                    if(isset($_POST['promijeniSifru'])){
                      $valid    = true;
                      $invMess  = "";
                      $passOne  = mysqli_real_escape_string($con, $_POST['passOne']);
                      $passTwo  = mysqli_real_escape_string($con, $_POST['passTwo']);
                      $oldPass  = mysqli_real_escape_string($con, $_POST['oldPass']);
                      $oldPassmd5 = md5($oldPass);
                      if(empty($passOne) or empty($passTwo) or empty($oldPass)){
                        $valid = false;
                        $invMess = "Sva polja moraju biti popunjena";
                      }
                      elseif(strlen($passOne) < 8){
                        $valid = false;
                        $invMess = "Lozinka mora biti duža od 8 karaktera";
                      }
                      elseif($passOne != $passTwo){
                        $valid = false;
                        $invMess = "Lozinke se ne podudaraju";
                      }
                      elseif($dataarr['password'] != $oldPassmd5){
                        $valid = false;
                        $invMess = "Stara lozinka nije tačna";
                      }
                      else $valid = true;
                      if($valid == false){
                        echo "<div class=\"alert alert-danger alert-dismissible\">
                              <a href=\"#\" class=\"close\" data-dismiss=\"alert\" aria-label=\"close\">&times;</a>
                              $invMess
                              </div>
                              ";
                      }
                      else{
                        $newPass = md5($passOne);
                        $updateQ = mysqli_query($con, "UPDATE users SET password = '$newPass' WHERE username = '$username' AND password = '$oldPassmd5'");
                        if($updateQ){
                          echo "<div class=\"alert alert-success alert-dismissible\">
                                <a href=\"#\" class=\"close\" data-dismiss=\"alert\" aria-label=\"close\">&times;</a>
                                Šifra uspješno promijenjena!
                                </div>
                                ";
                        }
                        else{
                          echo "<div class=\"alert alert-danger alert-dismissible\">
                                <a href=\"#\" class=\"close\" data-dismiss=\"alert\" aria-label=\"close\">&times;</a>
                                Greška prilikom promijene!
                                </div>
                                ";
                        }
                      }
                    }
                   ?>
                  <form action="korisnik.php" method="post">
                    <div class="form-group">
  										<input class="input" type="password" name="passOne" placeholder="Nova lozinka" required>
  									</div>
                    <div class="form-group">
  										<input class="input" type="password" name="passTwo" placeholder="Potvrdite lozinku" required>
  									</div>
                    <div class="form-group">
  										<input class="input" type="password" name="oldPass" placeholder="Stara lozinka" required>
  									</div>
                    <div class="form-group">
  										<button type="submit" name="promijeniSifru" class="primary-btn cta-btn">Promijeni</button>
  									</div>
                  </form>
      					</div>
              </center>
              <?php
            }
           ?>

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
							<p>Prijavi se na <strong>NEWSLETTER</strong></p>
							<form>
								<input class="input" type="email" placeholder="Enter Your Email">
								<button class="newsletter-btn"><i class="fa fa-envelope"></i> Prijavi se</button>
							</form>
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
