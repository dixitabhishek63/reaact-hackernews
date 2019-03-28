// var seneca = require("seneca")()
// .use("email")
// .use("sms")
// .use("post");
// seneca.listen({port: 1932, host: "10.0.0.7"});

var Seneca  = require("seneca");
var Express = require("express");
var Web     = require("seneca-web");

var seneca = Seneca();
var server = Express();

var config = {
    routes:{
        prefix : "/my-api",
        pin: "role:api,cmd:*",
        map:{
            bazinga: {
                GET: true
            }
        }
    }
};

seneca.use(Web, { adapter: require('seneca-web-adapter-express'), context: server });

//seneca.use(Web, { adapter: "express", context: server })

seneca.act("role:web", config);

seneca.add("role:api,cmd:bazinga", bazinga);

server.listen(3000);

function bazinga(args, done){

    done(null, {
        bar: "Bazinga!"
    });
}













// // var express = require('express');
// // var server = express();
// // var seneca = require('seneca')();
// // //tell senecaa to use senecaa-web explicitely
// // var Web = require("seneca-web");

// // seneca.add('role:api,cmd:bazinga', function (args, done) {
// //     done(null, { bar: "Bazinga!" });
// // });

// // seneca.act('role:web', {
// //     use: {
// //         prefix: '/my-api',
// //         pin: { role: 'api', cmd: '*' },
// //         map: {
// //             bazinga: { GET: true }
// //         }
// //     }
// // });


// // seneca.use(Web, { adapter: require('seneca-web-adapter-express'), context: server });


// // server.listen(3002, function () {
// //     console.log('listening on port 3002');
// // });

