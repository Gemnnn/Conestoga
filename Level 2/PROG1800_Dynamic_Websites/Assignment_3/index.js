// Assignment 3
// Name: Byounguk Min
// Studnet number: 8703561

var express = require('express');
var path = require('path');
var bodyParser = require('body-parser');
const { check, validationResult} = require('express-validator');

var myApp = express();

myApp.set('views', path.join(__dirname, 'views'));
myApp.set('view engine', 'ejs');
myApp.use(express.static(__dirname + '/public'));

myApp.use(bodyParser.urlencoded({ extended: false}))
myApp.use(bodyParser.json())

myApp.get('/', function(req,res){
    res.render('index');
});

myApp.get('/order', function(req,res){
    res.render('order');
});

myApp.post('/order',[
        check('name', 'Must have a name').not().isEmpty(),
        check('address', 'Must have an address').not().isEmpty(),
        check('city', 'Must have a City').not().isEmpty(),
        check('province', 'Must have a province').not().isEmpty(),
        check('number', 'Phone number must be numeric').isNumeric(),
        check('email', 'Email format is wrong').isEmail(),
    ],
    function(req,res){
        var errors = validationResult(req);
        var priceError = "Total price must be greater than $10";
        if (isNaN(req.body.tshirt1)){
            check1 = 0;
        }
        else{
            var check1 = parseInt(req.body.tshirt1);
        }
        if (isNaN(req.body.tshirt2)){
            check2 = 0;
        }
        else{
            var check2 = parseInt(req.body.tshirt2);
        }
        if (isNaN(req.body.tshirt3)){
            check3 = 0;
        }
        else{
            var check3 = parseInt(req.body.tshirt3);
        }
        if (isNaN(req.body.tshirt4)){
            check4 = 0;
        }
        else{
            var check4 = parseInt(req.body.tshirt4);
        }
        if (isNaN(req.body.tshirt5)){
            check5 = 0;
        }
        else{
            var check5 = parseInt(req.body.tshirt5);
        }
        if (isNaN(req.body.tshirt6)){
            check6 = 0;
        }
        else{
            var check6 = parseInt(req.body.tshirt6);
        }

        var total = check1 + check2 + check3 +
        check4 + check5 + check6;
        console.log(req.body);
        if (!errors.isEmpty()){
            res.render('order', {
                errors:errors.array()
            });
        }
        else if (errors.isEmpty() && total<10){
            res.render('order', {
                priceError:priceError
            });
            console.log(priceError);
        }
        else {
            var name = req.body.name;
            var address = req.body.address;
            var city = req.body.city;
            var province = req.body.province;
            var number = req.body.number;
            var email = req.body.email;
            var taxTotal = total * 1.13;
            res.render('invoice', {
                name:name,
                address:address,
                city:city,
                province:province,
                number:number,
                email:email,
                total:total,
                taxTotal:taxTotal,
            });
        }
    }
);

myApp.listen(8080);