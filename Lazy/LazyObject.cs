using System;
using System.Collections.Generic;

namespace DesignPatterns.Lazy
{
    class LazyObject
    {
        private string m_description = string.Empty;
        private static Dictionary<string, LazyObject> m_objectDict = new Dictionary<string, LazyObject>();

        private LazyObject(string description)
        {
            m_description = description;
        }

        public static LazyObject Get(string description)
        {
            LazyObject result;
            if(!m_objectDict.TryGetValue(description, out result))
            {
                result = new LazyObject(description);
                m_objectDict.Add(description, result);
            }
            return result;
        }

        public static void ShowAll()
        {
            foreach(KeyValuePair<string, LazyObject> pair in m_objectDict)
            {
                Console.WriteLine($"Key: {pair.Key}");
            }
        }
    }
}
