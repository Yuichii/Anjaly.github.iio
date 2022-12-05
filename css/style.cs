@font-face {
  font-family: bold;
  src: url("../Footage/font/Poppins-Bold.otf");
}
@font-face {
  font-family: semibold;
  src: url("../Footage/font/Poppins-SemiBold.otf");
  font-weight: 600;
}
@font-face {
  font-family: regular;
  src: url("../Footage/font/Poppins-Regular.otf");
  font-weight: 100;
}
@font-face {
  font-family: yeseva;
  src: url("../Footage/font/YesevaOne-Regular.ttf");
  font-weight: 100;
}
*, *:before, *:after {
  box-sizing: border-box;
}

html, body, div, span, object, iframe, figure, h1, h2, h3, h4, h5, h6, p, blockquote, pre, a, code, em, img, small, strike, strong, sub, sup, tt, b, u, i, ol, ul, li, fieldset, form, label, table, caption, tbody, tfoot, thead, tr, th, td, main, canvas, embed, footer, header, nav, section, video {
  margin: 0;
  padding: 0;
  border: 0;
  font-size: 100%;
  font: inherit;
  vertical-align: baseline;
  text-rendering: optimizeLegibility;
  -webkit-font-smoothing: antialiased;
  text-size-adjust: none;
}

footer, header, nav, section, main {
  display: block;
}

body {
  line-height: 1;
}

ol, ul {
  list-style: none;
}

blockquote, q {
  quotes: none;
}

blockquote:before, blockquote:after, q:before, q:after {
  content: "";
  content: none;
}

table {
  border-collapse: collapse;
  border-spacing: 0;
}

input {
  -webkit-appearance: none;
  border-radius: 0;
}

a, button {
  text-decoration: none;
}

nav {
  background-color: rgba(255, 255, 255, 0.93);
  padding: 20px 0;
  position: fixed;
  right: 0;
  left: 0;
  top: 0;
}
nav .navigasi {
  display: flex;
  justify-content: center;
}
nav .navigasi a {
  color: #252525;
  padding: 0 30px;
  font-family: semibold;
  letter-spacing: 0.08em;
  font-size: 1em;
  text-transform: uppercase;
}

header {
  background-color: #97BBE5;
  height: 93vh;
  display: flex;
  align-items: center;
}
header .bg_header {
  margin: 0px 450px 0px 200px;
}
header .bg_header > * {
  padding-bottom: 15px;
}
header .bg_header p, header .bg_header button {
  font-family: regular;
  color: #313131;
  font-size: 0.9em;
  letter-spacing: 0.04em;
}
header .bg_header h1 {
  font-family: yeseva;
  display: flex;
  letter-spacing: 0.04em;
  font-size: 2.5em;
  color: #252525;
  margin: 0;
}
header .bg_header p {
  line-height: 1.6em;
}
header .bg_header button {
  padding: 6px 10px;
  border: 1px solid rgba(49, 49, 49, 0.9);
  border-radius: 2%;
  background-color: #97BBE5;
  text-transform: uppercase;
}

.section1 {
  height: 90vh;
  display: flex;
  align-items: center;
}
.section1 .expertise_bg {
  background-color: #252525;
  width: 100%;
  height: 71vh;
}
.section1 h1::before {
  content: "";
  border-bottom: 1.5px solid #fff;
  width: 25%;
  position: absolute;
  left: 0;
}
.section1 h1::after {
  content: "";
  border-bottom: 1.5px solid #fff;
  width: 25%;
  position: absolute;
  right: 0;
}
.section1 h1 {
  text-align: center;
  color: #fff;
  font-size: 1.6em;
  font-family: semibold;
  letter-spacing: 0.04em;
  margin: 60px 350px 50px 350px;
  position: relative;
  display: flex;
  justify-content: center;
  align-items: center;
}
.section1 .expertise {
  display: flex;
  justify-content: center;
}
.section1 .expertise div {
  background-color: #444444;
  width: 30vh;
  height: 30vh;
  margin: 0px 15px;
  display: inline-grid;
  align-content: center;
  justify-items: center;
}
.section1 .expertise p {
  color: #DDDDDD;
  font-family: regular;
  font-size: 1em;
  padding-top: 13px;
  align-content: center;
}

.section2 {
  height: 500vh;
  width: 100%;
  background-color: rgba(238, 242, 246, 0.8666666667);
  display: flex;
  justify-content: center;
}
.section2 .portfolio {
  margin: 100px 0px 0px 0px;
}
.section2 .portfolio h1, .section2 .portfolio h2 {
  color: #252525;
  text-align: center;
}
.section2 .portfolio h1 {
  font-family: semibold;
  font-size: 1em;
  text-transform: uppercase;
  letter-spacing: 0.3em;
  padding-bottom: 10px;
}
.section2 .portfolio h2 {
  font-family: bold;
  font-size: 1.7em;
  letter-spacing: 0.04em;
}
.section2 .portfolio .button {
  padding-top: 35px;
  display: flex;
  justify-content: center;
}
.section2 .portfolio .button button {
  font-family: regular;
  font-size: 0.9em;
  color: #444444;
  padding: 0 25px;
  border: none;
  background: none;
}

.collection img {
  max-width: 100%;
  object-fit: cover;
  display: flex;
  height: 70vh;
  flex-wrap: wrap;
}

/*# sourceMappingURL=style.cs.map */
