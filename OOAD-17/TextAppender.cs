using System;
using System.Collections.Generic;
using System.Text;

public class TextAppender
{
    private List<string> _text { get; set; }
    public TextAppender()
    {
        _text = new List<string>();
    }
    public TextAppender Append(string text)
    {
        _text.Add(text);
        return this;
    }
    public string GetFullText()
    {
        var str = new StringBuilder();
        foreach(var text in _text)
        {
            str.Append(text);
        }
        return str.ToString();
    }

}