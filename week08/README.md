# I/O - Working with Files and Streams

## Working with Files and Directories
* [File and Stream I/0](https://msdn.microsoft.com/en-us/library/k3352a4t%28v=vs.110%29.aspx)
  * Classes for working with files and directories - `File`, `FileInfo`, `Directory`, `DirectoryInfo`, `Path`

## Streams
Streams are used for reading and writing bytes from and into a source
* [Streams](https://msdn.microsoft.com/en-us/library/k3352a4t(v=vs.110).aspx#Anchor_1), [Basics of .NET Framework File I/O and the File System](https://msdn.microsoft.com/en-us/library/ms172745.aspx)
	* For files we use [FileStream](https://msdn.microsoft.com/en-us/library/system.io.filestream(v=vs.110).aspx)
* [Readers and writers](https://msdn.microsoft.com/en-us/library/k3352a4t(v=vs.110).aspx#Anchor_2) - work on top of streams and provide methods for working with basic data types - numbers, strings etc
* [Using statement](https://msdn.microsoft.com/en-us/library/yh598w02.aspx) - when working with external resources we should make sure we dispose them as soon as we don't need them

```csharp
// Get the directories currently on the C drive.
DirectoryInfo[] cDirs = new DirectoryInfo(@"c:\").GetDirectories();

// Write each directory name to a file.
using (StreamWriter sw = new StreamWriter("CDriveDirs.txt"))
{
    foreach (DirectoryInfo dir in cDirs)
    {
        sw.WriteLine(dir.Name);
    }
}

// Read and show each line from the file.
string line = "";
using (StreamReader sr = new StreamReader("CDriveDirs.txt"))
{
    while ((line = sr.ReadLine()) != null)
    {
        Console.WriteLine(line);
    }
}
```

## Serialization
* [Serialization](https://msdn.microsoft.com/en-us/library/ms233843.aspx), [Serialization How-to Topics](https://msdn.microsoft.com/en-us/library/ms172360%28v=vs.110%29.aspx) - provides an easy to use API for reading and writing complex objects into a stream
	* [Binary Serialization](https://msdn.microsoft.com/en-us/library/4abbf6k0%28v=vs.110%29.aspx)
	* [XML Serialization - Serialize](https://msdn.microsoft.com/en-us/library/szzyf24s%28v=vs.110%29.aspx), [XML Serialization - Deserialize](https://msdn.microsoft.com/en-us/library/fa420a9y%28v=vs.110%29.aspx)
	
```csharp
//Make a class serializable
[Serializable]
public class Person
{
  public string Name {get; set;}
  public string Company {get; set;}
  public int Age {get; set;}
}

var person = new Person()
  {
    Name = "Pesho",
    Company = "Microsoft",
    Age = 20
  };

//Binary serialization and deserialization
IFormatter formatter = new BinaryFormatter();
using(Stream stream = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None))
{
  formatter.Serialize(stream, person);
}

using(Stream stream = new FileStream("MyFile.bin", FileMode.Open, FileAccess.Read, FileShare.Read))
{
  Person p = (Person)formatter.Deserialize(stream);
}

//XML serialization and deserialization
XmlSerializer mySerializer = new XmlSerializer(typeof(Person));

using(StreamWriter myWriter = new StreamWriter("myFileName.xml"))
{
  mySerializer.Serialize(myWriter, person);
}

using(FileStream myFileStream = new FileStream("myFileName.xml", FileMode.Open))
{
  Person p = (Person)mySerializer.Deserialize(myFileStream);
}
```

# Traversing Graphs

* [Breadth-first search algorithm (BFS)](https://en.wikipedia.org/wiki/Breadth-first_search)
* [Depth-first search algorithm (DFS)](https://en.wikipedia.org/wiki/Depth-first_search)
