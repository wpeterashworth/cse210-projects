using System;

class Entry
// create the Entry class
{
    public string _date = "";
    public string _prompt = "";
    public string _text = "";
    // provide empty strings to be used later

    public Entry(string _date, string _prompt, string _text)
    // create the constructor 
    {
        this._date = _date;
        this._prompt = _prompt;
        this._text = _text;
        // this constructor retrieves the information provided in the Journal class and assigns them in order to have meaning
    }

    public void Display()
    // Display to the console the content of the user's entry, _date of entry, and the _prompt that was given
    {
        Console.WriteLine($"{this._prompt} [{_date}]\n{this._text}\n");
    }

    public void Save()
    // Save contents of journal into a file
    {
        Console.WriteLine("What file would you like to save to? ");
        string fileName = Console.ReadLine();
        string fileContents = File.ReadAllText(fileName);
        // retrieve input from user to find a file and then read all of the contents of that file

        if (!fileContents.Contains(_text))
        // if the file contents do not contain the _text the user inputted into the journal, then access the following code
        {
            if (File.Exists(fileName))
            // if the file that the user gave exists, access the following code
            {
                using (StreamWriter writer = new StreamWriter(fileName, true)) //this "true" is very important because it tells the streamwriter that the file exists
                // accessing the file and closing it upon finding it and then using the following code strip
                {
                    writer.Write($"{this._prompt} [{this._date}]\n{this._text}\n");
                    // write to the file
                }
            }
            else
            // the same as last pieces of code except this one writes to a new file
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.Write($"{this._prompt} [{this._date}]\n{this._text}\n");
                }
            }
        }
    }
}