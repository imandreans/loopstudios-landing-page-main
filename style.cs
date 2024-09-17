@import url("https://fonts.googleapis.com/css2?family=Josefin+Sans:ital,wght@0,100..700;1,100..700&display=swap");
@import url("https://fonts.googleapis.com/css2?family=Alata&display=swap");
html {
  font-family: "Josefin Sans";
}

* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
}

.container {
  width: 1200px;
  margin: auto;
}

h1 {
  font-weight: 200;
  text-transform: uppercase;
  font-size: 4.7em;
}

#hero {
  background-image: url("images/desktop/image-hero.jpg");
  background-blend-mode: multiply;
  background-repeat: no-repeat;
  background-size: cover;
  aspect-ratio: 600/271;
  padding: 65px 165px;
  width: 100%;
  margin-bottom: 180px;
}
#hero nav {
  margin-bottom: 120px;
}
#hero nav ul {
  display: flex;
  justify-content: flex-end;
  color: white;
  align-items: center;
  gap: 32px;
  list-style-type: none;
}
#hero nav ul li:not(:first-child) {
  cursor: pointer;
}
#hero nav ul li:not(:first-child):hover {
  border-bottom: 1px solid white;
}
#hero nav ul li:first-child {
  margin-right: auto;
}
#hero .sidebar {
  margin: 0;
  background-color: black;
  flex-direction: column;
  justify-content: flex-start;
  align-items: center;
  display: none;
  position: fixed;
  top: 0;
  right: 0;
  height: 100vh;
  min-width: 100%;
  text-transform: uppercase;
  font-weight: 500;
  padding: 0 30px;
  z-index: 999;
  padding-top: 60px;
}
#hero .sidebar li:first-child {
  display: flex;
  flex-wrap: wrap;
  align-items: center;
  width: 100%;
}
#hero .sidebar li:first-child #close-menu {
  display: block;
  margin-left: auto;
}
#hero .sidebar li:first-child #close-menu,
#hero .sidebar li:first-child #logo {
  cursor: pointer;
}
#hero #menu,
#hero .sidebar {
  display: none;
}
#hero #hero-title {
  border: 3px solid white;
  color: white;
  width: 700px;
  padding: 38px;
  margin-bottom: 80px;
}

#about {
  position: relative;
  margin-bottom: 180px;
}
#about img {
  width: 60%;
}
#about #description {
  position: absolute;
  top: 160px;
  right: 360px;
  max-width: 640px;
  padding: 80px;
  background-color: white;
}
#about #description h1 {
  text-transform: uppercase;
  font-weight: 300;
  font-size: 3.2em;
  margin-bottom: 30px;
}
#about #description p {
  color: hsl(0, 0%, 41%);
  line-height: 1.7;
}

#content {
  margin-bottom: 180px;
}
#content .container {
  display: grid;
  grid-template-columns: 1fr 1fr;
  margin-bottom: 90px;
}
#content h1 {
  text-transform: uppercase;
  font-family: "Josefin Sans";
  font-weight: 300;
  font-size: 3em;
  margin-bottom: 30px;
  margin: 0;
}
#content button {
  justify-self: flex-end;
  background-color: white;
  border: 1px solid black;
  width: 150px;
  height: 40px;
  text-transform: uppercase;
  font-family: "Alata";
  letter-spacing: 2px;
  cursor: pointer;
}
#content button:active {
  background-color: black;
  color: white;
}
#content .products {
  grid-column: 1/3;
  display: flex;
  row-gap: 60px;
  flex-wrap: wrap;
  place-items: center;
  justify-content: space-between;
}
#content .products .product {
  position: relative;
  max-width: 256px;
  height: 450px;
  place-content: end;
  padding: 40px;
}
#content .products .product h1 {
  color: white;
  font-family: "Josefin Sans";
  font-weight: 300;
  text-transform: uppercase;
  font-size: 2em;
  max-width: 170px;
  text-align: start;
  z-index: 1;
}
#content .products #deep-earth {
  background-image: linear-gradient(to top, rgba(0, 0, 0, 0.7), rgba(0, 0, 0, 0)), url("images/desktop/image-deep-earth.jpg");
  background-repeat: no-repeat;
  width: 100%;
  background-size: cover;
}
#content .products #night-arcade {
  background-image: linear-gradient(to top, rgba(0, 0, 0, 0.7), rgba(0, 0, 0, 0)), url("images/desktop/image-night-arcade.jpg");
  background-repeat: no-repeat;
  width: 100%;
  background-size: cover;
}
#content .products #soccer-team {
  background-image: linear-gradient(to top, rgba(0, 0, 0, 0.7), rgba(0, 0, 0, 0)), url("images/desktop/image-soccer-team.jpg");
  background-repeat: no-repeat;
  width: 100%;
  background-size: cover;
}
#content .products #grid {
  background-image: linear-gradient(to top, rgba(0, 0, 0, 0.7), rgba(0, 0, 0, 0)), url("images/desktop/image-grid.jpg");
  background-repeat: no-repeat;
  width: 100%;
  background-size: cover;
}
#content .products #from-above {
  background-image: linear-gradient(to top, rgba(0, 0, 0, 0.7), rgba(0, 0, 0, 0)), url("images/desktop/image-from-above.jpg");
  background-repeat: no-repeat;
  width: 100%;
  background-size: cover;
}
#content .products #pocket-borealis {
  background-image: linear-gradient(to top, rgba(0, 0, 0, 0.7), rgba(0, 0, 0, 0)), url("images/desktop/image-pocket-borealis.jpg");
  background-repeat: no-repeat;
  width: 100%;
  background-size: cover;
}
#content .products #curiosity {
  background-image: linear-gradient(to top, rgba(0, 0, 0, 0.7), rgba(0, 0, 0, 0)), url("images/desktop/image-curiosity.jpg");
  background-repeat: no-repeat;
  width: 100%;
  background-size: cover;
}
#content .products #fisheye {
  background-image: linear-gradient(to top, rgba(0, 0, 0, 0.7), rgba(0, 0, 0, 0)), url("images/desktop/image-fisheye.jpg");
  background-repeat: no-repeat;
  width: 100%;
  background-size: cover;
}

footer {
  background-color: black;
  color: white;
  height: 200px;
  place-content: center;
}
footer .container {
  display: grid;
  grid-template-columns: 1fr 1fr;
  grid-template-rows: 1fr 1fr;
  align-items: center;
  row-gap: 20px;
}
footer ul {
  list-style-type: none;
  display: flex;
  gap: 30px;
}
footer .contacts,
footer p {
  display: flex;
  justify-content: flex-end;
  color: hsl(0, 0%, 41%);
}
footer .contacts {
  gap: 30px;
}

@media (max-width: 1000px) {
  * {
    padding: 0;
    margin: 0;
  }
  .container {
    max-width: 90%;
    margin: auto;
  }
  h1 {
    font-size: 3rem;
  }
  #hero {
    padding: 0;
    background-image: url("images/mobile/image-hero.jpg");
    height: 1300px;
    padding-top: 50px;
  }
  #hero .container {
    display: flex;
    flex-direction: column;
    align-items: center;
  }
  #hero .container .hideOnMobile {
    display: none;
  }
  #hero .container nav ul {
    width: 90vw;
  }
  #hero .container nav #menu {
    display: flex;
  }
  #hero .container #hero-title {
    border: 3px solid white;
    color: white;
    width: 100%;
    margin: 80px 0px;
    padding: 30px;
    font-size: 4em;
    font-weight: 300;
  }
  #about {
    position: static;
  }
  #about .container {
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
  }
  #about img {
    width: 100%;
  }
  #about #description {
    text-align: center;
    position: static;
  }
  #about #description h1 {
    font-size: 2.7em;
  }
  #about #description p {
    font-size: 1.4em;
  }
  #content .container {
    display: flex;
    flex-direction: column;
    align-items: center;
  }
  #content .container button {
    order: 3;
    margin-top: 60px;
    height: 60px;
    width: 220px;
    font-size: 1.5em;
  }
  #content .products {
    justify-content: center;
  }
  #content .products .product {
    max-width: 100%;
    height: 240px;
  }
  #content .products .product h1 {
    max-width: 220px;
    font-size: 2.6em;
  }
  #content .products #deep-earth {
    background-image: linear-gradient(to top, rgba(0, 0, 0, 0.7), rgba(0, 0, 0, 0)), url("images/mobile/image-deep-earth.jpg");
    background-repeat: no-repeat;
  }
  #content .products #night-arcade {
    background-image: linear-gradient(to top, rgba(0, 0, 0, 0.7), rgba(0, 0, 0, 0)), url("images/mobile/image-night-arcade.jpg");
    background-repeat: no-repeat;
  }
  #content .products #soccer-team {
    background-image: linear-gradient(to top, rgba(0, 0, 0, 0.7), rgba(0, 0, 0, 0)), url("images/mobile/image-soccer-team.jpg");
    background-repeat: no-repeat;
  }
  #content .products #grid {
    background-image: linear-gradient(to top, rgba(0, 0, 0, 0.7), rgba(0, 0, 0, 0)), url("images/mobile/image-grid.jpg");
    background-repeat: no-repeat;
  }
  #content .products #from-above {
    background-image: linear-gradient(to top, rgba(0, 0, 0, 0.7), rgba(0, 0, 0, 0)), url("images/mobile/image-from-above.jpg");
    background-repeat: no-repeat;
  }
  #content .products #pocket-borealis {
    background-image: linear-gradient(to top, rgba(0, 0, 0, 0.7), rgba(0, 0, 0, 0)), url("images/mobile/image-pocket-borealis.jpg");
    background-repeat: no-repeat;
  }
  #content .products #curiosity {
    background-image: linear-gradient(to top, rgba(0, 0, 0, 0.7), rgba(0, 0, 0, 0)), url("images/mobile/image-curiosity.jpg");
    background-repeat: no-repeat;
  }
  #content .products #fisheye {
    background-image: linear-gradient(to top, rgba(0, 0, 0, 0.7), rgba(0, 0, 0, 0)), url("images/mobile/image-fisheye.jpg");
    background-repeat: no-repeat;
  }
  footer {
    padding: 80px;
    height: fit-content;
  }
  footer .container {
    display: flex;
    flex-direction: column;
  }
  footer .container .contacts {
    order: 2;
  }
  footer .container ul {
    order: 1;
    text-align: center;
    flex-direction: column;
    font-size: 1.4em;
    margin: 30px 0;
  }
  footer .container p {
    order: 4;
  }
}

/*# sourceMappingURL=style.cs.map */
