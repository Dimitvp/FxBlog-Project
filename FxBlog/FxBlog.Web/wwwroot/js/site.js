//$(function() {

//    $.ajax({
//        type: "GET",
//        url:
//            "https://forex.1forge.com/1.0.3/quotes?pairs=EURUSD,EURTRY,USDTRY&api_key=5k4GDj5VzLtTe5app2Dl6qsae7NEoruX",
//        contentType: "application/json; charset=utf-8",
//        dataType: "json",
//        success: function currency(data) {

//        }

//    })
//})
//const ForexDataClient = require("../src/ForexDataClient");

//let client = new ForexDataClient('5k4GDj5VzLtTe5app2Dl6qsae7NEoruX');


//client.connect((client) => {
//    //Subscribe to a single currency pair
//    client.subscribeTo('EURUSD');

//    //Subscribe to an array of currency pairs
//    client.subscribeTo([
//        'GBPJPY',
//        'AUDCAD',
//        'EURCHF',
//    ]);

//    //Subscribe to all currency pairs
//    client.subscribeToAll();

//    //Unsubcribe after 5 seconds and disconnect
//    setTimeout(function () {
//        //Unsubscribe from a single currency pair
//        client.unsubscribeFrom('EURUSD');

//        //Unsubscribe from an array of currency pairs
//        client.unsubscribeFrom([
//            'GBPJPY',
//            'AUDCAD',
//            'EURCHF'
//        ]);

//        //Unsubscribe from all currency pairs
//        client.unsubscribeFromAll();

//        //Disconnect from the server
//        client.disconnect();

//    }, 5000);
//});

////Handle incoming price updates from the server
//client.onUpdate((symbol, data) => {
//    console.log(symbol, data);
//});

////Handle non-price update messages
//client.onMessage((message) => {
//    console.log(message);
//});

////Handle disconnection from the server
//client.onDisconnect(() => {
//    console.log("Disconnected from server");
//});