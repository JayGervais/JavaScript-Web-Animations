//***** CSS ANIMATIONS *****//

.hideme {
  opacity: 0;
}

.animation-element {
  opacity: 0;
  position: relative;
}

.animation-element.slide-right {
  opacity: 0;
  -moz-transition: all 500ms linear;
  -webkit-transition: all 500ms linear;
  -o-transition: all 500ms linear;
  transition: all 500ms linear;
  -moz-transform: translate3d(100px, 0px, 0px);
  -webkit-transform: translate3d(100px, 0px, 0px);
  -o-transform: translate(100px, 0px);
  -ms-transform: translate(100px, 0px);
  transform: translate3d(100px, 0px, 0px);
}

.animation-element.slide-right.in-view {
  opacity: 1;
  -moz-transform: translate3d(0px, 0px, 0px);
  -webkit-transform: translate3d(0px, 0px, 0px);
  -o-transform: translate(0px, 0px);
  -ms-transform: translate(0px, 0px);
  transform: translate3d(0px, 0px, 0px);
}

.animation-element.slide-left {
  opacity: 0;
  -moz-transition: all 500ms linear;
  -webkit-transition: all 500ms linear;
  -o-transition: all 500ms linear;
  transition: all 500ms linear;
  -moz-transform: translate3d(-100px, 0px, 0px);
  -webkit-transform: translate3d(-100px, 0px, 0px);
  -o-transform: translate(-100px, 0px);
  -ms-transform: translate(-100px, 0px);
  transform: translate3d(-100px, 0px, 0px);
}

.animation-element.slide-left.in-view {
  opacity: 1;
  -moz-transform: translate3d(0px, 0px, 0px);
  -webkit-transform: translate3d(0px, 0px, 0px);
  -o-transform: translate(0px, 0px);
  -ms-transform: translate(0px, 0px);
  transform: translate3d(0px, 0px, 0px);
}

/* FadeInUp - Animation */

@keyframes slide-up {
  from {
    transform: translate3d(0, 40px, 0);
  }

  to {
    transform: translate3d(0, 0, 0);
    opacity: 1;
  }
}

@-webkit-keyframes slide-up {
  from {
    transform: translate3d(0, 40px, 0);
  }

  to {
    transform: translate3d(0, 0, 0);
    opacity: 1;
  }
}

.animation-element {
  animation-duration: 1.5s;
  animation-fill-mode: both;
  -webkit-animation-duration: 1.5s;
  -webkit-animation-fill-mode: both;
}

.animation-element.slide-up {
  opacity: 0;
}

.animation-element.slide-up.in-view {
  opacity: 0;
  animation-name: slide-up;
  -webkit-animation-name: slide-up;
}
