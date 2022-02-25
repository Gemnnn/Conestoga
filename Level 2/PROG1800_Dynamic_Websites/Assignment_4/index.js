const express = require('express');
const path = require('path');
const bodyParser = require('body-parser');
const { check, validationResult } = require('express-validator');

// setup database
const mongoose = require('mongoose');
mongoose.connect('mongodb://localhost:27017/shop',{
    useNewUrlParser: true,
    useUnifiedTopology: true
});

// set up model
const Records = mongoose.model('orders',{
    name : String,
    email : String,
    phone : String,
    address : String,
    city : String,
    postcode : String,
    province : String,
    item1 : Number,
    item2 : Number,
    item3 : Number,
    priceItem1 : Number,
    priceItem2 : Number,
    priceItem3 : Number,
    shippingCharges : Number,
    pirceTotal : Number,
    tax : Number,
    total : Number,
});


// set up variables to use packages
var myApp = express();
myApp.use(bodyParser.urlencoded({extended:false}));

// set path to public folders and view folders
myApp.set('views', path.join(__dirname, 'views'));
myApp.use(express.static(__dirname + '/public'));
myApp.set('view engine', 'ejs');

myApp.use(bodyParser.json());

// home page
myApp.get('/', function(req,res){
    res.render('form');
});


// form submission
myApp.post('/', [
    check('name', 'Must have a name').not().isEmpty(),
    check('email', 'Email format is wrong').isEmail(),
    check('phone', 'Must have a phone number').not().isEmpty(),
    check('address', 'Must have an address').not().isEmpty(),
    check('postcode', 'Must have a post code').not(),
    check('province', 'Must select a province').not(),
],
function(req, res){
    var errors = validationResult(req);
    var totalError = "You must buy at least 2 products";
    var item1;
    var item2;
    var item3;
    if (req.body.product1 == ""){
        item1 = 0;
    }
    else{
        item1 = parseInt(req.body.product1);
    }
    if (req.body.product2 == ""){
        item2 = 0;
    }
    else{
        item2 = parseInt(req.body.product2);
    }
    if (req.body.product3 == ""){
        item3 = 0;
    }
    else{
        item3 = parseInt(req.body.product3);
    }

    var totalProducts = item1 + item2 + item3;

    if (!errors.isEmpty()){
        res.render('form', {
            errors:errors.array()
        });
    }
    else if (errors.isEmpty() && totalProducts < 2){
        res.render('form', {
            totalError:totalError
        });
    }
    else {
        var name = req.body.name;
        var email = req.body.email;
        var phone = req.body.phone;
        var address = req.body.address;
        var city = req.body.city;
        var postcode = req.body.postcode;
        var province = req.body.province;
        var priceItem1 = item1 * 10;
        var priceItem2 = item2 * 20;
        var priceItem3 = item3 * 30;
        var shippingCharges = 20;
        var pirceTotal = priceItem1 + priceItem2 + priceItem3 + shippingCharges;
        var tax = pirceTotal * 0.13;
        var total = pirceTotal + tax;

        var pageData = {
            name : name,
            email : email,
            phone : phone,
            address : address,
            city : city,
            postcode : postcode,
            province : province,
            item1 : item1,
            item2 : item2,
            item3 : item3,
            priceItem1 : priceItem1,
            priceItem2 : priceItem2,
            priceItem3 : priceItem3,
            shippingCharges : shippingCharges,
            pirceTotal : pirceTotal,
            tax : tax,
            total : total,
        }
        var customerRecords = new Records(pageData);
        customerRecords.save().then( ()=>{
            console.log('Customer records are saved in database');
        });

        res.render('form', pageData);
    }
});

// render information page
myApp.get('/result', function(req,res){
    Records.find({}).exec(function(err,orders){
        res.render('result', {orders,orders});
    });
});

// start the server and listen at a port
myApp.listen(8080);

// tell if everything was ok
console.log('Everything fine - website at port 8080');