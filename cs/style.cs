/*Fonts*/
@import url("https://fonts.googleapis.com/css2?family=Josefin+Sans&display=swap");
/*Variables*/
header {
  text-align: center;
  top: 0px;
  width: 100%;
}

.menu {
  display: flex;
  justify-content: space-between;
  font-size: 25px;
  background-color: #E8D5B7;
  color: #0E2430;
  margin-bottom: 2em;
  position: fixed;
  top: 0px;
  left: 0px;
  right: 0px;
}
.menu h1 {
  font-size: 30px;
  font-family: fantasy;
}
.menu ul {
  display: flex;
  justify-content: space-around;
  text-align: center;
  list-style: none;
  display: inline-block;
  margin-top: 30px;
  margin-bottom: 30px;
}
.menu ul li {
  padding: 30px;
  display: inline;
}
.menu ul li a {
  text-decoration: none;
  color: #0E2430;
  border: solid #0E2430 2px;
}
.menu ul li a:hover {
  background-color: #0E2430;
  color: #E8D5B7;
  transition: 0.5s;
}

.logoText {
  display: flex;
  justify-content: space-around;
}

.logoText img {
  margin-left: 1.5em;
  margin-right: 0.7em;
}

.des {
  text-align: center;
  background-image: url("../scr/Media/fotos/work.png");
  background-repeat: no-repeat;
  background-size: 100%;
  padding-bottom: 30px;
}
.des p {
  font-size: 40px;
  text-align: justify;
  padding-bottom: 70px;
  margin: 1em;
  color: #E8D5B7;
}
.des a {
  color: #E8D5B7;
  background-color: #0E2430;
  font-size: 35px;
  border: solid #E8D5B7 5px;
  border-radius: 15px;
  text-decoration: none;
  padding: 20px;
}
.des a:hover {
  background-color: #E8D5B7;
  color: #0E2430;
  border: #0E2430 solid 5px;
  transition: 0.5s;
}

.slogan {
  display: flex;
  justify-content: center;
}
.slogan h2 {
  padding-left: 1em;
  padding-right: 1em;
  text-align: justify;
  padding-top: 30px;
  font-size: 70px;
  color: #E8D5B7;
}

.destacadas {
  background-image: url("../scr/Media/fotos/destacada.png");
  background-repeat: no-repeat;
  background-size: 100%;
}
.destacadas h2 {
  text-align: center;
  margin-top: 4em;
  font-size: 3em;
}

.app {
  margin-top: 5em;
  display: flex;
  justify-content: center;
  text-align: center;
}
.app div {
  width: 70%;
  display: flex;
  justify-content: space-around;
}
.app div img {
  background-color: #0E2430;
  border-radius: 15px;
  border: 1em groove wheat;
}
.app div img:hover {
  transform: rotate(3deg);
  transition: 0.5s;
}

/*# sourceMappingURL=style.cs.map */
