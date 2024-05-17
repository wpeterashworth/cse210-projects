using System;

class Entry
{
    public string date = "";
    public string prompt = "";
    public string text = "";

    public Entry(string date, string prompt, string text)
    {
        this.date = date;
        this.prompt = prompt;
        this.text = text;
    }

    public void Display()
    {
        Console.WriteLine($"{this.prompt} [{date}]\n{this.text}\n");
    }

    public void Save()
    {
        Console.WriteLine("What file would you like to save to? ");
        string fileName = Console.ReadLine();
        string fileContents = File.ReadAllText(fileName);

        if (!fileContents.Contains(text))
        {
            if (File.Exists(fileName))
            {
                using (StreamWriter writer = new StreamWriter(fileName, true))
                {
                    writer.Write($"{this.prompt} [{this.date}]\n{this.text}\n");
                }
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.Write($"{this.prompt} [{this.date}]\n{this.text}\n");
                }
            }
        }
    }
}