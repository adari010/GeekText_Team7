//SHOPPING  CART
var days = 60;
var now = new Date();
var time = now.getTime();
var expireTime = time + days * 24 * 60 * 60 * 1000
now.setTime(expireTime);
var cname = 'GeekTeam7_books';
var cart = 0;
var payTotal = 0;

var cookie;
var output = '';

initialize();

function initialize() {
    cookie = GetCookie();
    checkout();
}


function checkout() {

    var cartItems = $('#cartContent');

    if (cartItems.length != 0) {

        if (cookie != '') {


            cookie = cookie.split('*');
            if (cookie.length > 0) {

                totalPrice = $('#price');

                addItems = '';
                //addItems = '<input type="hidden" name="item_name_1" value="Item Name 1">' +
                //    '<input type="hidden" name="amount_1" value="1.00">' +
                //    '<input type="hidden" name="item_name_2" value="Item Name 2">' +
                //    '<input type="hidden" name="amount_2" value="2.00">' +
                //    '<input type="submit" value="PayPal">';

                //cookie = cookie.split(',');

                payTotal = 0;

                for (i = 0; i < cookie.length; i++) {
                    book = cookie[i].split('|');
                    price = parseFloat(book[1]);
                    payTotal += price;

                    addItems += '<input type="text" readonly="true" name="item_name_' + (i + 1) + '" value="' + book[0].replace('%3A', ':') + ' - $' + price + '">' +
                        '<input type="hidden" name="amount_' + (i + 1) + '" value="' + price + '"><br/>';

                    //$('#cartItems').prepend('<li><a href="#" class="removeItem" onclick="DeleteCookie( $(this) );" > (X)</a> - <a href="#">' + book[0].trim() + ' - ' + book[2].trim() + ' - $<span>' + book[1].trim() + '</a></li>');
                    //value += (value == '') ? book[0].trim() + '|' + book[2].trim() + '|' + book[1].trim() : ',' + book[0] + '|' + book[2] + '|' + book[1];
                }

                cartItems.append(addItems + '<br/><span>Total: $' + payTotal.toFixed(2) + '</span><br/><input type="submit" value="Pay">');

            }
        }
        else {
            cartItems.text('No items in Shopping Cart');

        }
    }
}

function GetCookie() {
    var value = '; ' + decodeURIComponent(decodeURIComponent(document.cookie) );
    var items = value.split('; ' + cname + '=');
    //cart = items.length;
    if (items.length > 1) {

        //items = items[1].split('%2C');
        items = items[1].split('*');

        payTotal = 0;
        value = '';

        for (i = 0; i < items.length; i++) {
            book = items[i].split('|');

            if (book.length == 1) continue;

            payTotal += parseFloat(book[1]);

            $('#cartItems').prepend('<li><a href="#" class="removeItem" onclick="DeleteCookie( $(this) );" > (X)</a> - <a href="#">' + book[0].trim().replace('%3A', ':') + ' - ' + book[2].trim() + ' - $<span>' + book[1].trim() + '</a></li>');
            value += (value == '') ? book[0].trim() + '|' + book[1].trim() + '|' + book[2].trim() : '*' + book[0] + '|' + book[1] + '|' + book[2];

            cart++;
        }
        //cart = i - 1;

        if (cart > 0) {
            $('#cartAmount').text(cart);
            //$('#payTotal').text(payTotal.toFixed(2));
            $('#cartItems').append('<li><br><a href="/Checkout/Index" style="background-color: #5ca212; padding: 5px 10px; color: white; margin-top: 50px; ">Checkout</a> <br> <div style="color: black; padding-top: 10px; "> Total: <span id="payTotal">' + payTotal.toFixed(2) + '</span></div></li>');

        }
        
        return value;
    }

    return '';
}


function DisplayCoookie() {
    if (cookie) {

    }
}

function SetCookie(obj) {

    //isbn = obj.parent().next().text().replace(' ', '').replace(' ', '').replace('\n', '').replace('\n', '');
    isbn = "1";
    console.log(isbn);
    cart++;
    bookName = obj.parent('td').find('p').text();
    bookPrice = parseFloat(obj.parent('td').find('span').text());
    payTotal += bookPrice;

    $('#cartItems').prepend('<li><a href="#" class="removeItem" onclick="DeleteCookie( $(this) );" > (X)</a> - <a href="#">' + bookName + ' - ' + isbn + ' - $<span>' + bookPrice + '</a></li>');
    $('#cartAmount').text(cart);
    $('#payTotal').text(payTotal);

    if (typeof cookie != 'undefined' || cookie == '')
        cookie += '*' + bookName.trim() + '|' + bookPrice + '|' + isbn.trim();
    else
        cookie = bookName.trim() + '|' + bookPrice + '|' + isbn.trim();


    //alert( obj.nextSibling().text() );
    document.cookie = cname + '=' + encodeURIComponent(cookie) + '; expires=' + now.toGMTString() + '; path=/'

    if (cart == 1) {

        $('#cartItems').append('<li><br><a href="/Checkout/Index" style="background-color: #5ca212; padding: 5px 10px; color: white; margin-top: 50px; ">Checkout</a> <br> <div style="color: black; padding-top: 10px;"> Total: <span id="payTotal">' + bookPrice.toFixed(2) + '</span></div></li>');

    }
}

function DeleteCookie(obj) {

    bookName = obj.parent().text().replace(' - ', ' ');
    isbn = bookName;
    isbn = isbn.substring((isbn.indexOf('-') + 1), isbn.replace('-', ' ').indexOf('-')).trim();
    bookName = bookName.substring(5, bookName.indexOf('-') - 1).trim();
    bookPrice = obj.parent().find('span').text().trim();
    payTotal = parseFloat($('#payTotal').text());
    payTotal -= bookPrice;
    $('#payTotal').text(payTotal.toFixed(2));

    obj.parent().remove();
    cart--;
    $('#cartAmount').text(cart);
    if (cart == 0) {
        $('#cartItems').html('');

    }

    cookie = cookie.toString().replace('*' + bookName + '|' + bookPrice + '|' + isbn, '');
    cookie = cookie.replace(bookName + '|' + bookPrice + '|' + isbn +'*', '');
    cookie = cookie.replace(bookName + '|' + bookPrice + '|' + isbn, '');

    document.cookie = cname + '=' + encodeURIComponent(cookie) + '; expires=' + now.toGMTString() + '; path=/'


    location.reload();

}


function ShowCart() {

    $('#cartItems').toggle('slow');
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

$('#searchDropdownBox').on('change', function () {
    $('#passID').val($(this).val() );
});

