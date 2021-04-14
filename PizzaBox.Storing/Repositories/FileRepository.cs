// using System;
// using System.Collections.Generic;
// using System.IO;
// using System.Xml.Serialization;


// namespace PizzaBox.Storing.Repositories
// {
//     public class FileRepository
//     {
//        // public bool WriteToFile(List<AStore> stores)
//         {
//             try
//             {
//                 // access to path
//                 string path = @"store.xml"; // literal string
//                                             // open to file
//                 StreamWriter writer = new StreamWriter(path);
//                 // class definition.
//                 XmlSerializer xml = new XmlSerializer(typeof(List<AStore>));
//                 // serialize (convert to markup) to xml
//                 xml.Serialize(writer, stores);
//                 // write to file
//                 // close file
//                 return true;
//             }
//             catch (FileNotFoundException e)
//             {
//                 throw new Exception("You have the wrong file", e);
//             }
//             catch
//             {
//                 return false;
//             }
//         }
//         public List<T> ReadFromFile<T>(string path) where T : class
//         {
//             // var path = @"store.xml";
//             var reader = new StreamReader(path);
//          //   var xml = new XmlSerializer(typeof(List<AStore>));
//             List<T> ts = xml.Deserialize(reader) as List<T>;
//             return ts; // if error => null
//         }
//     }
// }