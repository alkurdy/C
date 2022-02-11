// Cat, Book, Beach, Run, Read, Talk, Him, Fast  

namespace word
{
class noun
{ 
    public const string wordType = "noun";
    public string nounValue { get; set; }
    public int nounNumber { get; set; }

    public noun(string word)
    {
        this.nounValue = word;
    }

    static void FindWord(){}



}

class verb
{
    const string wordType = "verb";
    public string verbValue { get; set; }
    public verb(string word)
    {
        this.verbValue = word;
    }
}
}
