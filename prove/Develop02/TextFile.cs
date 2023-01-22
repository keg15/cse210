using System.IO;

string fileName = "myJournal.txt";
using (StreamWriter outputFile = new StreamWriter(fileName))
{
}

string filename = "myJournal.txt";
string[] lines = System.IO.File.ReadAllLines(filename);