using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<String, String> trToEng = new MyDictionary<string, string>();
            trToEng.Add("elma", "apple");
            trToEng.Add("muz", "banana");
            trToEng.Add("ben", "I");
            trToEng.Add("sen", "you");
            trToEng.Add("biz", "we");

            trToEng.Yaz();

        }
    }

    class MyDictionary<Key,Value>
    {
        Key[] keys;
        Value[] values;

        public MyDictionary()
        {
            keys = new Key[0];
            values = new Value[0];
        }
        
        public void Add(Key key,Value value)
        {
            Key[] tempKeys=keys;
            Value[] tempValues=values;
            keys = new Key[tempKeys.Length+1];
            values = new Value[tempKeys.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
            }
            keys[keys.Length-1] = key;
            values[keys.Length-1] = value;
        }

        public void Yaz()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine(keys[i]+"\t"+values[i]);
            }
        }

    }
}
