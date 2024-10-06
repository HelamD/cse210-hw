using System;

    public class Journal
    {
        public List<Entry> _entry = new List<Entry>();

        public void AddEntry(Entry entry)
        {
            _entry.Add(entry);
        }

        public void DisplayAll()
        {
            foreach (Entry entry in _entry)
            {
                entry.Display();
            }
        }
        public void SaveToFile()
        {
            string fileName = "text.txt";
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (Entry entry in _entry)
                {
                    writer.WriteLine($"{entry._date} | {entry._promptText} | {entry._entryText}");
                
                }
            }
        Console.WriteLine("journal saved successfully to " + fileName);
        
         }  

        public void LoadFromFile()


        {
            string fileName = "text.txt";
            using (StreamReader reader = new StreamReader(fileName))
            {
                string[] lines = File.ReadAllLines(fileName);
                foreach (string line in lines)
                {
                    string[] parts = line.Split('|');
                    string date = parts[0];
                    string prompt = parts[1];
                    string response = parts[2];

                    Entry entry = new Entry(date, prompt, response);
                    _entry.Add(entry);
                }
                Console.WriteLine("Journal loaded successfully.");

            }
        }


    } 
