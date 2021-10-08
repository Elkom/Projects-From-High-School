<?php
	$cookieName = "shopping_cart";
	$cart_data = array();
	$item_data = "";
	$message = "";
	$doReload = false;
	if(!isset($_COOKIE["shopping_cart"])){
		setcookie($cookieName, "[]", time() + 86400);
		$doReload = true;
	}


	if(isset($_POST["add_to_cart"])) {
		if(isset($_COOKIE["shopping_cart"])){
			$cookie_data = stripslashes($_COOKIE['shopping_cart']);
		  $cart_data = json_decode($cookie_data, true);
		}
		else{
			$cart_data = array();
		}
		$item_id_list = array_column($cart_data, 'item_id');
		if(in_array($_POST["hidden_id"], $item_id_list)){
			foreach($cart_data as $keys => $values){
		   if($cart_data[$keys]["item_id"] == $_POST["hidden_id"]){
		    $cart_data[$keys]["item_quantity"] = $cart_data[$keys]["item_quantity"] + $_POST["quantity"];
		   }
		  }
		 }
		 else{
		  $item_array = array(
		   'item_id'   => $_POST["hidden_id"],
		   'item_name'   => $_POST["hidden_name"],
		   'item_price'  => $_POST["hidden_price"],
		   'item_quantity'  => $_POST["quantity"],
			 'item_image' => $_POST['hidden_image']
		  );
		  $cart_data[] = $item_array;
		 }
		 $item_data = json_encode($cart_data);
		 setcookie('shopping_cart', $item_data, time() + (86400 * 30));
		 header("location:index.php?success=1");
		}

		if(isset($_GET["action"]))
		{
		 if($_GET["action"] == "delete")
		 {
		  $cookie_data = stripslashes($_COOKIE['shopping_cart']);
		  $cart_data = json_decode($cookie_data, true);
		  foreach($cart_data as $keys => $values)
		  {
		   if($cart_data[$keys]['item_id'] == $_GET["id"])
		   {
		    unset($cart_data[$keys]);
		    $item_data = json_encode($cart_data);
		    setcookie("shopping_cart", $item_data, time() + (86400 * 30));
		    header("location:index.php?remove=1");
		   }
		  }
		 }
		}

		if(isset($_GET["success"]))
		{
		 $message = '
		 <div class="alert alert-success alert-dismissible">
		    <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
		    Dodano u korpu
		 </div>
		 ';
		}

		if(isset($_GET["remove"]))
		{
		 $message = '
		 <div class="alert alert-success alert-dismissible">
		  <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
		  Uklonjeno iz korpe
		 </div>
		 ';
		}
 ?>

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

		<!-- jQuery - Hosted by Google -->
		<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>

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
									<button class="search-btn">Pretraži</button>
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

								<?php
									if ($doReload) {
										echo '<script type="text/javascript">',
												 'window.location.reload();',
												 '</script>';
										$doReload = false;
									}
								 ?>

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
					<!-- shop -->
					<div class="col-md-4 col-xs-6">
						<div class="shop">
							<div class="shop-img">
								<img src="./img/shop01.png" alt="">
							</div>
							<div class="shop-body">
								<h3>Kolekcija<br>Laptopa</h3>
								<a href="laptopi.php" class="cta-btn">Pogledaj <i class="fa fa-arrow-circle-right"></i></a>
							</div>
						</div>
					</div>
					<!-- /shop -->

					<!-- shop -->
					<div class="col-md-4 col-xs-6">
						<div class="shop">
							<div class="shop-img">
								<img src="./img/shop03.png" alt="">
							</div>
							<div class="shop-body">
								<h3>Kolekcija<br>Slušalica</h3>
								<a href="slusalice.php" class="cta-btn">Pogledaj <i class="fa fa-arrow-circle-right"></i></a>
							</div>
						</div>
					</div>
					<!-- /shop -->

					<!-- shop -->
					<div class="col-md-4 col-xs-6">
						<div class="shop">
							<div class="shop-img">
								<img src="./img/shop02.png" alt="">
							</div>
							<div class="shop-body">
								<h3>Kolekcija<br>Kamera</h3>
								<a href="kamere.php" class="cta-btn">Pogledaj <i class="fa fa-arrow-circle-right"></i></a>
							</div>
						</div>
					</div>
					<!-- /shop -->
					<div class="col-md-4">
						<!--
							The purpose of this div is to put some space so the next one is
							on the center of the page
						-->
					</div>
					<div class="col-md-4">
						<center>
							<?php echo $message; ?>
						</center>
					</div>
				</div>
				<!-- /row -->
			</div>
			<!-- /container -->
		</div>
		<!-- /SECTION -->

		<!-- SECTION -->
		<div class="section">
			<!-- container -->
			<div class="container">
				<!-- row -->
				<div class="row">

					<!-- section title -->
					<div class="col-md-12">
						<div class="section-title">
							<h3 class="title">Novi artikli</h3>
							<div class="section-nav">
								<ul class="section-tab-nav tab-nav">
									<li class="active"><a data-toggle="tab" href="#tab1">Laptopi</a></li>
									<li><a data-toggle="tab" href="#tab1">Pametni Telefoni</a></li>
									<li><a data-toggle="tab" href="#tab1">Kamere</a></li>
									<li><a data-toggle="tab" href="#tab1">Dodaci</a></li>
								</ul>
							</div>
						</div>
					</div>
					<!-- /section title -->

					<!-- Products tab & slick -->
					<div class="col-md-12">
						<div class="row">
							<div class="products-tabs">
								<!-- tab -->
								<div id="tab1" class="tab-pane active">
									<div class="products-slick" data-nav="#slick-nav-1">

										<!-- product -->
										<div class="product">
											<div class="product-img">
												<img src="./img/product01.png" alt="">
												<div class="product-label">
													<span class="sale">-30%</span>
													<span class="new">NOVO</span>
												</div>
											</div>
											<div class="product-body">
												<p class="product-category">Laptopi</p>
												<h3 class="product-name"><a href="#">Laptop 1</a></h3>
												<h4 class="product-price">$980.00 <del class="product-old-price">$990.00</del></h4>
												<div class="product-rating">
												</div>
												<div class="product-btns">
													<button class="add-to-wishlist"><i class="fa fa-heart-o"></i><span class="tooltipp">dodaj na listu želja</span></button>
													<button class="quick-view"><i class="fa fa-eye"></i><span class="tooltipp">Pogledaj</span></button>
												</div>
											</div>
											<div class="add-to-cart">
												<form method="post">
													<input type="hidden" name="quantity" value="1">
													<input type="hidden" name="hidden_name" value="Laptop_1">
													<input type="hidden" name="hidden_price" value="980">
													<input type="hidden" name="hidden_id" value="1">
													<input type="hidden" name="hidden_image" value="product01">
													<button type="submit" name="add_to_cart" class="add-to-cart-btn"><i class="fa fa-shopping-cart"></i> dodaj u korpu</button>
												</form>
											</div>
										</div>
										<!-- /product -->

										<!-- product -->
										<div class="product">
											<div class="product-img">
												<img src="./img/product02.png" alt="">
												<div class="product-label">
													<span class="new">NOVO</span>
												</div>
											</div>
											<div class="product-body">
												<p class="product-category">Slušalice</p>
												<h3 class="product-name"><a href="#">Slušalice 1</a></h3>
												<h4 class="product-price">$80.00</h4>
												<div class="product-rating">
												</div>
												<div class="product-btns">
													<button class="add-to-wishlist"><i class="fa fa-heart-o"></i><span class="tooltipp">dodaj na listu želja</span></button>
													<button class="quick-view"><i class="fa fa-eye"></i><span class="tooltipp">Pogledaj</span></button>
												</div>
											</div>
											<div class="add-to-cart">
												<form method="post">
													<input type="hidden" name="quantity" value="1">
													<input type="hidden" name="hidden_name" value="Slusalice_1">
													<input type="hidden" name="hidden_price" value="80">
													<input type="hidden" name="hidden_id" value="2">
													<input type="hidden" name="hidden_image" value="product02">
													<button type="submit" name="add_to_cart" class="add-to-cart-btn"><i class="fa fa-shopping-cart"></i> dodaj u korpu</button>
												</form>
											</div>
										</div>
										<!-- /product -->

										<!-- product -->
										<div class="product">
											<div class="product-img">
												<img src="./img/product03.png" alt="">
												<div class="product-label">
													<span class="sale">-30%</span>
												</div>
											</div>
											<div class="product-body">
												<p class="product-category">Laptopi</p>
												<h3 class="product-name"><a href="#">Laptop 3</a></h3>
												<h4 class="product-price">$686.00 <del class="product-old-price">980.00</del></h4>
												<div class="product-rating">
												</div>
												<div class="product-btns">
													<button class="add-to-wishlist"><i class="fa fa-heart-o"></i><span class="tooltipp">dodaj na listu želja</span></button>
													<button class="quick-view"><i class="fa fa-eye"></i><span class="tooltipp">Pogledaj</span></button>
												</div>
											</div>
											<div class="add-to-cart">
												<form method="post">
													<input type="hidden" name="quantity" value="1">
													<input type="hidden" name="hidden_name" value="Laptop_3">
													<input type="hidden" name="hidden_price" value="686">
													<input type="hidden" name="hidden_id" value="3">
													<input type="hidden" name="hidden_image" value="product03">
													<button type="submit" name="add_to_cart" class="add-to-cart-btn"><i class="fa fa-shopping-cart"></i> dodaj u korpu</button>
												</form>
											</div>
										</div>
										<!-- /product -->

										<!-- product -->
										<div class="product">
											<div class="product-img">
												<img src="./img/product04.png" alt="">
											</div>
											<div class="product-body">
												<p class="product-category">Tablet</p>
												<h3 class="product-name"><a href="#">Tablet 1</a></h3>
												<h4 class="product-price">$270.00</h4>
												<div class="product-rating">
												</div>
												<div class="product-btns">
													<button class="add-to-wishlist"><i class="fa fa-heart-o"></i><span class="tooltipp">dodaj na listu želja</span></button>
													<button class="quick-view"><i class="fa fa-eye"></i><span class="tooltipp">Pogledaj</span></button>
												</div>
											</div>
											<div class="add-to-cart">
												<form method="post">
													<input type="hidden" name="quantity" value="1">
													<input type="hidden" name="hidden_name" value="Tablet_1">
													<input type="hidden" name="hidden_price" value="270">
													<input type="hidden" name="hidden_id" value="4">
													<input type="hidden" name="hidden_image" value="product04">
													<button type="submit" name="add_to_cart" class="add-to-cart-btn"><i class="fa fa-shopping-cart"></i> dodaj u korpu</button>
												</form>
											</div>
										</div>
										<!-- /product -->

										<!-- product -->
										<div class="product">
											<div class="product-img">
												<img src="./img/product05.png" alt="">
											</div>
											<div class="product-body">
												<p class="product-category">Slušalice</p>
												<h3 class="product-name"><a href="#">Slušalice 2</a></h3>
												<h4 class="product-price">$85.00 <del class="product-old-price">$120.00</del></h4>
												<div class="product-rating">
												</div>
												<div class="product-btns">
													<button class="add-to-wishlist"><i class="fa fa-heart-o"></i><span class="tooltipp">dodaj na listu želja</span></button>
													<button class="quick-view"><i class="fa fa-eye"></i><span class="tooltipp">Pogledaj</span></button>
												</div>
											</div>
											<div class="add-to-cart">
												<form method="post">
													<input type="hidden" name="quantity" value="1">
													<input type="hidden" name="hidden_name" value="Slusalice_2">
													<input type="hidden" name="hidden_price" value="85">
													<input type="hidden" name="hidden_id" value="5">
													<input type="hidden" name="hidden_image" value="product05">
													<button type="submit" name="add_to_cart" class="add-to-cart-btn"><i class="fa fa-shopping-cart"></i> dodaj u korpu</button>
												</form>
											<div>
										</div>
										<!-- /product -->
										</div>
									</div>
								</div>
								</div>
								<!-- /tab -->
							</div>
							<div id="slick-nav-1" class="products-slick-nav"></div>
						</div>
					</div>
					<!-- Products tab & slick -->
				</div>
				<!-- /row -->
			</div>
			<!-- /container -->
		</div>
		<!-- /SECTION -->

		<!-- HOT DEAL SECTION -->
		<div id="hot-deal" class="section">
			<!-- container -->
			<div class="container">
				<!-- row -->
				<div class="row">
					<!-- script for countdown -->
					<script type="text/javascript">
						// Set the date we're counting down to
						var countDownDate = new Date("May 1, 2020 15:00:00").getTime();
						// Update the count down every 1 second
						var x = setInterval(function() {
						  // Get today's date and time
						  var now = new Date().getTime();
						  // Find the distance between now and the count down date
						  var distance = countDownDate - now;
						  // Time calculations for days, hours, minutes and seconds
						  var day = Math.floor(distance / (1000 * 60 * 60 * 24));
						  var hr = Math.floor((distance % (1000 * 60 * 60 * 24)) / (1000 * 60 * 60));
						  var min = Math.floor((distance % (1000 * 60 * 60)) / (1000 * 60));
						  var sec = Math.floor((distance % (1000 * 60)) / 1000);
						  // Output the result in an element with id="demo"
						  document.getElementById("day").innerHTML = day;
							document.getElementById("hr").innerHTML = hr;
							document.getElementById("min").innerHTML = min;
							document.getElementById("sec").innerHTML = sec;
						  // If the count down is over, write some text
						  if (distance < 0) {
						    clearInterval(x);
						    document.getElementById("demo").innerHTML = "EXPIRED";
						  }
						}, 1000);
					</script>
					<div class="col-md-12">
						<div class="hot-deal">
							<ul class="hot-deal-countdown">
								<li>
									<div>
										<h3 id="day"></h3>
										<span>Dana</span>
									</div>
								</li>
								<li>
									<div>
										<h3 id="hr"></h3>
										<span>sati</span>
									</div>
								</li>
								<li>
									<div>
										<h3 id="min"></h3>
										<span>Minuta</span>
									</div>
								</li>
								<li>
									<div>
										<h3 id="sec"></h3>
										<span>Sekunde</span>
									</div>
								</li>
							</ul>
							<h2 class="text-uppercase">do kraja akcije</h2>
							<p>Novi artikli - do 50% popusta</p>
							<a class="primary-btn cta-btn" href="#">Pogledaj</a>
						</div>
					</div>
				</div>
				<!-- /row -->
			</div>
			<!-- /container -->
		</div>
		<!-- /HOT DEAL SECTION -->

		<!-- SECTION -->
		<div class="section">
			<!-- container -->
			<div class="container">
				<!-- row -->
				<div class="row">

					<!-- section title -->
					<div class="col-md-12">
						<div class="section-title">
							<h3 class="title">Najprodavanije</h3>
							<div class="section-nav">
								<ul class="section-tab-nav tab-nav">
									<li class="active"><a data-toggle="tab" href="#tab2">Laptopi</a></li>
									<li><a data-toggle="tab" href="#tab2">Pametni Telefoni</a></li>
									<li><a data-toggle="tab" href="#tab2">Kamere</a></li>
									<li><a data-toggle="tab" href="#tab2">Dodaci</a></li>
								</ul>
							</div>
						</div>
					</div>
					<!-- /section title -->

					<!-- Products tab & slick -->
					<div class="col-md-12">
						<div class="row">
							<div class="products-tabs">
								<!-- tab -->
								<div id="tab1" class="tab-pane active">
									<div class="products-slick" data-nav="#slick-nav-1">

										<!-- product -->
										<div class="product">
											<div class="product-img">
												<img src="./img/product03.png" alt="">
												<div class="product-label">
													<span class="sale">-30%</span>
												</div>
											</div>
											<div class="product-body">
												<p class="product-category">Laptopi</p>
												<h3 class="product-name"><a href="#">Laptop 3</a></h3>
												<h4 class="product-price">$686.00 <del class="product-old-price">980.00</del></h4>
												<div class="product-rating">
												</div>
												<div class="product-btns">
													<button class="add-to-wishlist"><i class="fa fa-heart-o"></i><span class="tooltipp">dodaj na listu želja</span></button>
													<button class="quick-view"><i class="fa fa-eye"></i><span class="tooltipp">Pogledaj</span></button>
												</div>
											</div>
											<div class="add-to-cart">
												<form method="post">
													<input type="hidden" name="quantity" value="1">
													<input type="hidden" name="hidden_name" value="Laptop_3">
													<input type="hidden" name="hidden_price" value="686">
													<input type="hidden" name="hidden_id" value="3">
													<input type="hidden" name="hidden_image" value="product03">
													<button type="submit" name="add_to_cart" class="add-to-cart-btn"><i class="fa fa-shopping-cart"></i> dodaj u korpu</button>
												</form>
											</div>
										</div>
										<!-- /product -->

										<!-- product -->
										<div class="product">
											<div class="product-img">
												<img src="./img/product04.png" alt="">
											</div>
											<div class="product-body">
												<p class="product-category">Tablet</p>
												<h3 class="product-name"><a href="#">Tablet 1</a></h3>
												<h4 class="product-price">$270.00</h4>
												<div class="product-rating">
												</div>
												<div class="product-btns">
													<button class="add-to-wishlist"><i class="fa fa-heart-o"></i><span class="tooltipp">dodaj na listu želja</span></button>
													<button class="quick-view"><i class="fa fa-eye"></i><span class="tooltipp">Pogledaj</span></button>
												</div>
											</div>
											<div class="add-to-cart">
												<form method="post">
													<input type="hidden" name="quantity" value="1">
													<input type="hidden" name="hidden_name" value="Tablet_1">
													<input type="hidden" name="hidden_price" value="270">
													<input type="hidden" name="hidden_id" value="4">
													<input type="hidden" name="hidden_image" value="product04">
													<button type="submit" name="add_to_cart" class="add-to-cart-btn"><i class="fa fa-shopping-cart"></i> dodaj u korpu</button>
												</form>
											</div>
										</div>
										<!-- /product -->

										<!-- product -->
										<div class="product">
											<div class="product-img">
												<img src="./img/product02.png" alt="">
												<div class="product-label">
													<span class="new">NOVO</span>
												</div>
											</div>
											<div class="product-body">
												<p class="product-category">Slušalice</p>
												<h3 class="product-name"><a href="#">Slušalice 1</a></h3>
												<h4 class="product-price">$80.00</h4>
												<div class="product-rating">
												</div>
												<div class="product-btns">
													<button class="add-to-wishlist"><i class="fa fa-heart-o"></i><span class="tooltipp">dodaj na listu želja</span></button>
													<button class="quick-view"><i class="fa fa-eye"></i><span class="tooltipp">Pogledaj</span></button>
												</div>
											</div>
											<div class="add-to-cart">
												<form method="post">
													<input type="hidden" name="quantity" value="1">
													<input type="hidden" name="hidden_name" value="Slusalice_1">
													<input type="hidden" name="hidden_price" value="80">
													<input type="hidden" name="hidden_id" value="2">
													<input type="hidden" name="hidden_image" value="product02">
													<button type="submit" name="add_to_cart" class="add-to-cart-btn"><i class="fa fa-shopping-cart"></i> dodaj u korpu</button>
												</form>
											</div>
										</div>
										<!-- /product -->

										<!-- product -->
										<div class="product">
											<div class="product-img">
												<img src="./img/product01.png" alt="">
												<div class="product-label">
													<span class="sale">-30%</span>
													<span class="new">NOVO</span>
												</div>
											</div>
											<div class="product-body">
												<p class="product-category">Laptopi</p>
												<h3 class="product-name"><a href="#">Laptop 1</a></h3>
												<h4 class="product-price">$980.00 <del class="product-old-price">$990.00</del></h4>
												<div class="product-rating">
												</div>
												<div class="product-btns">
													<button class="add-to-wishlist"><i class="fa fa-heart-o"></i><span class="tooltipp">dodaj na listu želja</span></button>
													<button class="quick-view"><i class="fa fa-eye"></i><span class="tooltipp">Pogledaj</span></button>
												</div>
											</div>
											<div class="add-to-cart">
												<form method="post">
													<input type="hidden" name="quantity" value="1">
													<input type="hidden" name="hidden_name" value="Laptop_1">
													<input type="hidden" name="hidden_price" value="980">
													<input type="hidden" name="hidden_id" value="1">
													<input type="hidden" name="hidden_image" value="product01">
													<button type="submit" name="add_to_cart" class="add-to-cart-btn"><i class="fa fa-shopping-cart"></i> dodaj u korpu</button>
												</form>
											</div>
										</div>
										<!-- /product -->

										<!-- product -->
										<div class="product">
											<div class="product-img">
												<img src="./img/product05.png" alt="">
											</div>
											<div class="product-body">
												<p class="product-category">Slušalice</p>
												<h3 class="product-name"><a href="#">Slušalice 2</a></h3>
												<h4 class="product-price">$85.00 <del class="product-old-price">$120.00</del></h4>
												<div class="product-rating">
												</div>
												<div class="product-btns">
													<button class="add-to-wishlist"><i class="fa fa-heart-o"></i><span class="tooltipp">dodaj na listu želja</span></button>
													<button class="quick-view"><i class="fa fa-eye"></i><span class="tooltipp">Pogledaj</span></button>
												</div>
											</div>
											<div class="add-to-cart">
												<form method="post">
													<input type="hidden" name="quantity" value="1">
													<input type="hidden" name="hidden_name" value="Slusalice_2">
													<input type="hidden" name="hidden_price" value="85">
													<input type="hidden" name="hidden_id" value="5">
													<input type="hidden" name="hidden_image" value="product05">
													<button type="submit" name="add_to_cart" class="add-to-cart-btn"><i class="fa fa-shopping-cart"></i> dodaj u korpu</button>
												</form>
											<div>
										</div>
										<!-- /product -->
										</div>
									</div>
								</div>
								</div>
								<!-- /tab -->
							</div>
						</div>
					</div>
					<!-- Products tab & slick -->
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
											echo "<br><a href=\"index.php\">Pokušajte ponovo</a>";
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
							<form action="index.php" method="post">
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
