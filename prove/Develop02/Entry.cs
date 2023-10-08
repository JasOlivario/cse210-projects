using System.Runtime.CompilerServices;

public class Entry
{
    public string _date;
    public string _response;
    public string _prompt;



    public string CreateEntry()
    {
        string oneEntry = $"Date: {_date} - Prompt: {_prompt} \n {_response}";
        return oneEntry;
    }



}