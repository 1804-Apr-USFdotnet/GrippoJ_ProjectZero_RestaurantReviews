using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using PZModels;

namespace ConsoleApp1
{
    class FranchiseSerialization
    {
        public List<Franchise> GetFranchisesXML()
        {
            FranchiseCollection f = null;
            string path = "Franchise.xml";

            XmlSerializer serializer = new XmlSerializer(typeof(FranchiseCollection));

            using (StreamReader reader = new StreamReader(path))
                f = (FranchiseCollection)serializer.Deserialize(reader);
            return f.FranchiseCollectionList;

        }
    }

    [XmlRoot("FranchiseCollection")]
    public class FranchiseCollection
    {
        [XmlArray("Franchises")]
        [XmlArrayItem("Franchise", typeof(Franchise))]
        public List<Franchise> FranchiseCollectionList { get; set; }
    }
}
