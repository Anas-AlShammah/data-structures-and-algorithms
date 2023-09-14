using Microsoft.VisualBasic;
using System;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class HashMap
    {
        private LinkedList<KeyValuePair<string, string>>[] map { get; set; }
        public HashMap(int size)
        {
            map= new LinkedList<KeyValuePair<string, string>>[size];
        }
        public int Hash (string key)
        {
            int hashValue = 0;

            char[] letters = key.ToCharArray();

            for (int i = 0; i < letters.Length; i++)
            {
                hashValue += letters[i]; /// Integer representation
            }

            //0 - 9
            hashValue = (hashValue * 599) % map.Length;

            return hashValue;
        }
        public void Set(string key, string value)
        {
            int hashKey = Hash(key);
            if (map[hashKey] == null)
            {
                map[hashKey] = new LinkedList<KeyValuePair<string, string>>();

            }
            KeyValuePair<string,string> entry = new KeyValuePair<string, string>(key, value);
            map[hashKey].Insert(entry);
        }
        public string Get(string key)
        {
            for (int i = 0; i < map.Length; i++)
            {
                if (map[i] != null)
                {
                    Node<KeyValuePair<string, string>> current = map[i].Head;
                    while (current != null)
                    {
                        if (current.Value.Key == key)
                        { return current.Value.Value; }
                        current = current.Next;
                    }
                }
            }
            return null;
        }
        public List<string> Key()
        {
            List<string> list = new List<string>();
            for (int i = 0; i < map.Length; i++)
            {
                if (map[i] != null)
                {
                    Node<KeyValuePair<string, string>> current = map[i].Head;
                    while (current != null)
                    {
                        list.Add(current.Value.Key);
                        current = current.Next;
                    }
                }
            }
            return list;
        }
        public bool Has(string key)
        {
            for (int i = 0; i < map.Length; i++)
            {
                if (map[i] != null)
                {
                    Node<KeyValuePair<string, string>> current = map[i].Head;
                    while (current != null)
                    {
                        if (current.Value.Key == key)
                        { return true; }
                        current = current.Next;
                    }
                }
            }
            return false;
        }
        public void Remove (string key) 
        {
            
        }
        public void Print()
        {
            for (int i = 0;i<map.Length;i++)
            {
                if (map[i] != null)
                {
                    Console.WriteLine($"Bucket {i}: ");
                    Node<KeyValuePair<string, string>> current = map[i].Head;
                    while(current != null)
                    {
                        Console.Write($"[{current.Value.Key} : {current.Value.Value}] => ");
                        current=current.Next;
                    }
                    Console.WriteLine();
                }else
                {
                    Console.WriteLine($"bucket {i}:Empty");
                }
            }
        }
    }
}
