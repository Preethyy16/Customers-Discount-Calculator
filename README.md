# Customer Discount Calculator
## Overview
Customer Discount Calculator is a C# console application that calculates the discount on a customer's purchase and displays the final payable amount.
## Features
- Accepts customer details, including name and age.
- Accepts purchase details, including the number of units and total purchase amount.
- Calculates the discount on the purchase.
- Applies a coupon code to provide an additional discount.
- Displays the final payable amount and total savings.
## How It Works
1. The program accepts the customer's details like name and age from the user.
2. It accepts the number of units purchased and the total purchase amount.
3. It calculates the purchase discount.
4. It applies the coupon discount if the coupon is valid.
5. It subtracts the discounts from the original purchase amount.
6. It displays the final amount payable and the total savings using :
    Final Amount = Original Amount − Purchase Discount − Coupon Discount
    Total Savings = Purchase Discount + Coupon Discount
    
##Discount Rules
The application applies discounts based on the total purchase amount:
•	₹5,000 and above – 25% discount

•	₹4,000 and above – 20% discount

•	₹2,000 and above – 10% discount

•	₹1,000 and above – 5% discount

•	Below ₹1,000 – 2% discount

Coupon Discount Rules
An additional coupon discount is applied based on the discounted amount and the number of units purchased:

•	Discounted amount of ₹600 or more and at least 6 units – ₹300 coupon discount

•	Discounted amount of ₹400 or more and at least 4 units – ₹200 coupon discount

•	Discounted amount of ₹200 or more and at least 2 units – ₹100 coupon discount

If none of these conditions are met, no coupon discount is applied.

## Example
---Enter the details below----------
Enter a Customer name: preethi
Enter age: 20
Enter purchased units: 2
Enter Total amount of the purchase: 2000
---------------Final purchase statment -------------
customer Details: 
Customer name:preethi Age : 20
Order Details: 
Ordered units are2the total amount2000
Discount details
The Discount amount for your purchase is: Rs.200
After the Discount!! Your TOTAL AMOUNT will be Rs:1800
yayyy cupon applied of rs.100
The Final amount = 1700

C# Concepts Practised
•	Console input and output
•	Variables and data types
•	Conditional statements (if, else if, else)
•	Classes and objects
•	Inheritance
•	Access specifiers.
