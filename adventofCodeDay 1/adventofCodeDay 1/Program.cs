using System.Diagnostics.Metrics;
string text = System.IO.File.ReadAllText(@"C:\input.txt");
List<int> calList = new List<int>();
int cumVal = 0;
foreach (string line in System.IO.File.ReadLines(@"c:\input.txt"))
{
    if(line != "")
    {
        cumVal = cumVal +Int32.Parse(line);
        
    }
    else
    {
        calList.Add(cumVal);
        cumVal = 0;
    }

}
calList.Sort();
var t = calList[calList.Count - 1] + calList[calList.Count - 2] + calList[calList.Count - 3];
Console.WriteLine(t);