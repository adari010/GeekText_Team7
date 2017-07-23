// Write your Javascript code.
//SHOPPING  CART
var days = 60;
var now = new Date();
var time = now.getTime();
var expireTime = time + days * 24 * 60 * 60 * 1000
now.setTime(expireTime);
var cname = 'GeekTeam7_books';
var cart = 0;
var payTotal = 0;

var cookie = GetCookie();
var output = '';

function GetCookie() {
    var value = '; ' + document.cookie();
    var items = value.split('; ' + cname + '=');
    cart = items.length();
}


function DisplayCoookie() {
    if (cookie) {

    }
}

function SetCookie(obj) {

    isbn = obj.parent().next().text();
    console.log(isbn);
    cart++;
    bookName = obj.parent().find('p').text();
    bookPrice = parseFloat(obj.parent().next().next().next().next().text());
    payTotal += bookPrice;

    $('#cartItems').prepend('<li><a href="#" class="removeItem" onclick="DeleteCookie( $(this) );" > (X)</a> - <a href="#">' + bookName + ' - ' + isbn + ' - $<span>' + bookPrice + '</a></li>');
    $('#cartAmount').text(cart);
    $('#payTotal').text(payTotal);

    //alert( obj.nextSibling().text() );
    document.cookie = cname + '=' + encodeURIComponent(cookie) + '; expires=' + now.toGMTString() + '; path=/'

    if (cart == 1) {

        $('#cartItems').append('<li><br><a href="/Checkout/" style="background-color: grey; padding: 5px 10px; color: white; margin-top: 50px; ">Checkout</a> <br> <div style="color: black; "> Total: <span id="payTotal">' + bookPrice.toFixed(2) + '</span></div></li>');

    }
}

function DeleteCookie(obj) {

    bookPrice = obj.parent().find('span').text();
    payTotal = parseFloat($('#payTotal').text());
    payTotal -= bookPrice;
    $('#payTotal').text(payTotal.toFixed(2));

    obj.parent().remove();
    cart--;
    $('#cartAmount').text(cart);
    if (cart == 0) {
        $('#cartItems').html('');

    }

}


function ShowCart() {

    $('#cartItems').css('display', 'block');

}

$('.removeItem').click(function (e) {
    e.preventDefault();

});



$(document).ready(function () {


    //    $('#cartItems').toggle(function () {
    //    $('#cartItems').addClass('show');
    //}, function () {
    //    $('#cartItems').removeClass('hide');

    //});



});








