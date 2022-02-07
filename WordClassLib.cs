// Cat, Book, Beach, Run, Read, Talk, Him, Fast  

namespace word
{
class word
{
    public string wordValue {get;set;}

}

class noun : word
{ 
    const string wordType = "noun";
    public noun(string word)
    {
        this.wordValue = word;
    }

}

class verb : word
{
    const string wordType = "verb";
    public verb(string word)
    {
        this.wordValue = word;
    }
}
}
