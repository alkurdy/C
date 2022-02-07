// Cat, Book, Beach, Run, Read, Talk, Him, Fast  

namespace word
{
class noun
{ 
    public const string wordType = "noun";
    public string wordValue { get; set; }
    public noun(string word)
    {
        this.wordValue = word;
    }

}

class verb
{
    const string wordType = "verb";
    public string wordValue { get; set; }
    public verb(string word)
    {
        this.wordValue = word;
    }
}
}
