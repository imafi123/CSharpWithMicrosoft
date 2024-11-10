// In this challenge you have to parse the individual "Order IDs", and output the "OrderIDs" sorted and tagged as "Error" if they aren't exactly four characters in length.

// Select and delete all code lines in the Visual Studio Code Editor.

// In Visual Studio Code, add the following code to get the data for the challenge: string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

// Notice in the previous code, the orderStream variable contains a string of multiple Order IDs separated by commas.

// Add code below the previous code to parse the "Order IDs" from the string of incoming orders and store the "Order IDs" in an array.

// Add code to output each "Order ID" in sorted order and tag orders that aren't exactly four characters in length as "- Error".

// Save and run your code

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] items = orderStream.Split(',');
Array.Sort(items);

foreach (var item in items)
{
    if (item.Length == 4)
    {
        Console.WriteLine(item);
    }
    else
    {
        Console.WriteLine(item + "\t- Error");
    }
}