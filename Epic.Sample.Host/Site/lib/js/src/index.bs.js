// Generated by BUCKLESCRIPT VERSION 4.0.6, PLEASE EDIT WITH CARE
'use strict';

var ReactDOMRe = require("reason-react/lib/js/src/ReactDOMRe.js");
var ReasonReact = require("reason-react/lib/js/src/ReasonReact.js");
var Router$ReactTemplate = require("./components/Router.bs.js");

var component = ReasonReact.statelessComponent("Stadistic");

function make() {
  return /* record */[
          /* debugName */component[/* debugName */0],
          /* reactClassInternal */component[/* reactClassInternal */1],
          /* handedOffState */component[/* handedOffState */2],
          /* willReceiveProps */component[/* willReceiveProps */3],
          /* didMount */component[/* didMount */4],
          /* didUpdate */component[/* didUpdate */5],
          /* willUnmount */component[/* willUnmount */6],
          /* willUpdate */component[/* willUpdate */7],
          /* shouldUpdate */component[/* shouldUpdate */8],
          /* render */(function () {
              return ReasonReact.element(undefined, undefined, Router$ReactTemplate.make(/* array */[]));
            }),
          /* initialState */component[/* initialState */10],
          /* retainedProps */component[/* retainedProps */11],
          /* reducer */component[/* reducer */12],
          /* jsElementWrapped */component[/* jsElementWrapped */13]
        ];
}

var App = /* module */[
  /* component */component,
  /* make */make
];

ReactDOMRe.renderToElementWithClassName(ReasonReact.element(undefined, undefined, make(/* array */[])), "app");

exports.App = App;
/* component Not a pure module */