"use strict";

/*
   New Perspectives on HTML5 and CSS3, 7th Edition
   Tutorial 10
   Case Problem 1
  
    Author: Benjamin Evans 
    Date: 2/7/2023  
     
   Filename: tc_order.js  

   The item array contains the ID numbers of the items ordered by the customer
   The itemDescription array contains the description of each item
   The itemPrice array contains the price of each item
   The itemQty array contains the quantity ordered of each item
   
*/

var item = [10582,23015,41807,10041];

var itemDescription = ["1975 Green Bay Packers Football(signed), item 10582", "Tom Landry 1955 Football Card(unsigned), item 23015",
"1916 Army-Navy Game, Framed Photo(signed), item 41807", "Protective Card Sheets, item 10041"];

var itemPrice = [149.93, 89.98, 334.93, 22.67];

var itemQty = [1,1,1,4];

var orderTotal = 0;

var cartHTML = "<table>" +
			"<tr>" +
			"<th>Item</th><th>Description</th><th>Price</th><th>Qty</th><th>Total</th>" +
			"</tr>";
			
			document.getElementById("cart").innerHTML = cartHTML;
			
			
for (var i = 0; i < item.length; i++){
cartHTML += "<tr>" +
			"<td><img src='tc_item.png' 'alt=item[i]' /></td>";
}


