﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assessment_Two
{
    class Card
    {
        // below is an enum list of suites, an enum will keep these values constant and allow easier access then an array. 
        public enum cardType
        {
            Diamonds,
            Clubs,
            Hearts,
            Spades
        }
        // Below are some simple value setting methods. 
        public int cardNumber
        {
            get;
            set;
        }
        public cardType suite
        {
            get;
            set;
        }
        // The below method handles the picture cards such as the king by switching the value 13 with the word king. 
        public string pictureCards
        {
            get
            {
                string name = string.Empty; // initiates a sting variable called name that has now value. 
                switch (cardNumber)
                {
                    case (1): // if the card number equals 1 this case is activated,
                        name = "Ace"; // the name variable is changed to Ace,
                        break; // and the code breaks. 
                    case (11):
                        name = "Jack";
                        break;
                    case (12):
                        name = "Queen";
                        break;
                    case (13):
                        name = "King";
                        break;
                    default: // if none of the above are activated this is run as the default,
                        name = cardNumber.ToString(); // the number is converted to a string so 2 become Two. 
                        break;
                }
                return name; // Returns the name varable. 
            }
        }
        // the below method creates the full name of the card. 
        public string cardName
        {
            get
            {
                return pictureCards + " of " + suite.ToString(); // concatinates the cards number or name and its suite before returning the variable. 
            }
        }
        // below is the construtor for this class it has 2 arguments 1 relates the the cards number the other relates to the cards suite. 
        public Card(int number, cardType suite)
        {
            this.cardNumber = number; // passes the arguments value to the cardNumber get set method before it is used. 
            this.suite = suite;
        }
    }
}
