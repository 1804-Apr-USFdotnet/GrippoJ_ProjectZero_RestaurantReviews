using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using PZModels;

namespace ConsoleApp1
{
    class SerializeConsole
    {
        static void Main(string[] args)
        {
            FranchiseCollection f = null;
            string path = "Franchise.xml";

            XmlSerializer serializer = new XmlSerializer(typeof(FranchiseCollection));

            StreamReader reader = new StreamReader(path);
            f = (FranchiseCollection)serializer.Deserialize(reader);
            reader.Close();

            foreach (Franchise x in f.FranchiseCollectionList)
            {
                Console.WriteLine(x.ToString());
            }

            Console.Read();
        }
    }
    [XmlRoot("FranchiseCollection")]
    public class FranchiseCollection
    {
        [XmlArray("Franchises")]
        [XmlArrayItem("Franchise",typeof(Franchise))]
        public List<Franchise> FranchiseCollectionList { get; set; }
    }
}
