using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

public class xmlManager<T>
{
	public Type Type { get; private set; }

	public T Load(string path)
    {
        T instance;
        using (TextReader reader = new StreamReader(path))
        {
            xmlSerializer xml = new xmlSerializer(Type);
            instance = (T)xml.Deserialize(reader);
        }
        return instance;
    }

    public void save(string path, object obj)
    {
        using (TextWriter = new StreamWriter(path))
        {
            XmlSerializer xml = new XmlSerializer(Type);
            xml.Serialzer(writer, obj)
        }
    }
}
