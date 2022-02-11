// Cat, Book, Beach, Run, Read, Talk, Him, Fast  

namespace word
{

class word
{
    public string wordValue { get; set; }
}
class noun : word
{ 
    public const string partOfSpeech = "noun";
    public int count { get; set; }

    public noun(string word)
    {
        this.wordValue = word;
    }

    public string getpartOfSpeech{get {return partOfSpeech;}}

    static void FindWord(){}



}

class verb : word
{
    const string partOfSpeech = "verb";
    public verb(string word)
    {
        this.wordValue = word;
    }
}
}
