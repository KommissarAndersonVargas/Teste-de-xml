using System;
using System.Xml.Linq;
using System.Xml.Serialization;

public class clsPerson
{
    public string FirstName;
    public string MI;
    public string LastName;
}

class class1
{
    static void Main(string[] args)
    {
        clsPerson p = new clsPerson();
        p.FirstName = "Beef Back to the future";
        p.MI = "A";
        p.LastName = "Price";

      

        XmlSerializer mySerializer = new XmlSerializer(typeof(clsPerson));
        // To write to a file, create a StreamWriter object.  
        StreamWriter myWriter = new StreamWriter(@"C:\Users\Usuario\Documents\Videos\myFileName.xml");
        mySerializer.Serialize(myWriter, p);
        myWriter.Close();
    }
}