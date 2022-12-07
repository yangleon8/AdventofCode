int total = 0;
foreach (string line in System.IO.File.ReadLines(@"c:\Users\user\Documents\input2.txt"))
{
    Console.WriteLine(line);
    //X :lose Y:draw Z: win
    //A B C
    string[] letters = line.Split(' ');
   

    if (letters[0] == "A" && letters[1] == "X")
    {
        total = total + 3;
    }
    else if (letters[0] == "A" && letters[1] == "Z")
    {
        total = total + 6 + 2;
    }
    else if (letters[0] == "A" && letters[1] == "Y")
    {
        total = total + 3 + 1;
    }

    if (letters[0] == "B" && letters[1] == "X")
    {
        total = total + 1;
    }
    else if (letters[0] == "B" && letters[1] == "Z")
    {
        total = total + 6 + 3;
    }
    else if (letters[0] == "B" && letters[1] == "Y")
    {
        total = total + 3 + 2;
    }

    if (letters[0] == "C" && letters[1] == "X")
    {
        total = total + 2;
    }
    else if (letters[0] == "C" && letters[1] == "Z")
    {
        total = total + 6 + 1;
    }
    else if (letters[0] == "C" && letters[1] == "Y")
    {
        total = total + 3 + 3;
    }

}
Console.WriteLine(total);
