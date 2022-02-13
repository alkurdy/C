using word;
using System;
using System.Xml;

namespace Wordsmith
{
    class Wordwriter
    {
        public Noun writeNoun {get; set;}
        public Verb writeVerb {get; set;}
        public Adverb writeAdverb {get; set;}
        public Adverb writeAdjective {get; set;}
        public Pronoun writePronoun {get; set;}

    }

    class Wordfinder
    {
        public Noun findNoun {get; set;}
        public Noun findVerb {get; set;}
        public Noun findAdverb {get; set;}
        public Noun findAdjective {get; set;}
        public Noun findPronoun {get; set;}
        
    }

    //Search text file for words with all caps
    //remove caps
    //store word
    //search for same word and then ,n ,a ,v ..etc
    //use this value to label word function 

    //XML file with: 
    //word
    //function
    //definition
}