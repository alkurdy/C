// Cat, Book, Beach, Run, Read, Talk, Him, Fast  

namespace word
{

class Word
{
    public string wordValue { get; set; }
    public string partOfSpeech;
    public string getpartOfSpeech{get {return partOfSpeech;}}

    public string capitalizeWord(string word){return (word.Substring(0,1).ToUpper()) + (word.Substring(1));}
}
class Noun : Word
{ 
    public int count { get; set; }
    public bool isPerson = false;
    public bool isAnmial = false;
    public bool isPlace = false;
    public bool isThing = false;

    public Noun(string word)
    {
        this.wordValue = word;
        this.partOfSpeech = "noun";
    }

    static void FindWord(){}


}

class Verb : Word
{
    public Verb(string word)
    {
        this.wordValue = word;
        this.partOfSpeech = "verb";
    }
}

class Adverb : Word
{

}

class Adjective : Word
{

}

    class Pronoun : Word
    {
        string[,] pronounArray = new string[8,5]
        {
            {"I","me","mine","my","myself"},
            {"you","you","yours","your","yourself"},
            {"he","him","his","his","himself"},
            {"she","her","hers","hers","herself"},
            {"it","it","its","its","itself"},
            {"we","us","ours","our","ourselves"},
            {"you","you","yours","your","yourselves"},
            {"They","them","theirs","their","themselves"}
        };
        public Pronoun(string word)
        {
            this.wordValue = word;
            this.partOfSpeech = "Pronoun";
        }


    }

}
