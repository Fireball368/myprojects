
"use strict";

/*
   New Perspectives on HTML5 and CSS3, 7th Edition
   Tutorial 10
   Case Problem 4

   Author: Benjamin Evans
   Date: 2/14/2023   
   
   Filename: vw_results.js
   
   Functions:
   
   The calcSum() function is a callback function used to
   calculte the total value from items within an array
   
   The calcPercent(value, sum) function calculates the percentage given
   a value and a sum
   
   The createBar(partyType, percent) function writes a different
   table data table based on the candidates party affilication.
   
      
*/

var salaries = [36548, 29740,59337,98599,75665];

var raise = .035;

for (var i = 0; i < salaries.length; i++){

alert("A salary of  " + salaries[i] + " with a raise of  "  + raise * salaries[i] + " would be " + (raise * salaries[i] ) + salaries[i] );

}