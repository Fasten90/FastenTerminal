using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarKonLogApplication
{
    
    static class ConfigHandler
    {

        static public bool LoadConfigFromXml( String ConfigFile, ref Config config )
        {

            // Then in some other function.
            //Person person = XmlSerialization.ReadFromXmlFile<Person>("C:\person.txt");
            //List<Person> people = XmlSerialization.ReadFromXmlFile<List<Person>>("C:\people.txt");
            try
            {
                config = XmlSerialization.ReadFromXmlFile<Config>(ConfigFile);
                // EXCEPTION: ha nem találja az adott fájlt

                //Log.SendEventLog("Users.xml flashFile loaded succesful.");
                Console.WriteLine("Config.xml has loaded.");

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to load Config.xml");
                Console.WriteLine(ex.Message);

                return false;
            }

        }

        static public void SaveConfigToXml( String ConfigFile, Config config )
        {
            // And then in some function.
            //Person person = new Person() { Name = "Dan", Age = 30; HomeAddress = new Address() { StreetAddress = "123 My St", City = "Regina" }};
            //List<Person> people = GetListOfPeople();
            //XmlSerialization.WriteToXmlFile<Person>("C:\person.txt", person);
            //XmlSerialization.WriteToXmlFile<List<People>>("C:\people.txt", people);
            XmlSerialization.WriteToXmlFile<Config>(ConfigFile, config);

            //Log.SendEventLog("Save to xml has been successful.");
            Console.WriteLine("Config.xml has saved.");
        }


  
    }
}
