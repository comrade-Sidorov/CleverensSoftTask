// See https://aka.ms/new-console-template for more information

using System.Text;

var r = Compression("xaxabbcccddeee");
Console.WriteLine(r);

string Compression(string text)
{
    if(String.IsNullOrEmpty(text))
        return String.Empty;
    if(text.Length <= 1)
        return text;
    StringBuilder result = new StringBuilder();
    result.Append(" ");
    int count = 1;
    for (int i = 0; i < text.Length; i++)
    {
        if (result.ToString().Last() != text[i])
        {
            if (count > 1)
            {
                result.Append(count.ToString());
                count = 1;
            }
            result.Append(text[i]);
                
        }
        else
        {
            count++;
        }
    }

    if (count > 1)
    {
        result.Append(count.ToString());
    }

    result.Remove(0, 1);
    return result.ToString();
}