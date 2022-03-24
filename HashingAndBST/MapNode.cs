using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashingAndBST
{
    //Value type Data type KeyValue
    //Value type Data Type KeyValue
    public struct KeyValue<K, V>
    {
        public K Key { get; set; }
        public V Value { get; set; }
    };

    public class MapNode<K, V>
    {
        int size;
        public LinkedList<KeyValue<K, V>>[] items;

        public MapNode(int size)
        {
            this.size = size;
            this.items = new LinkedList<KeyValue<K, V>>[size];
        }



        public void Add(K key, V value)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> LinkedListofPosition = GetLinkedListPosition(position);
            KeyValue<K, V> keyValue = new KeyValue<K, V>()
            {

            }
            return items[position];
        }
        // Check if element is already Present
        public int CheckHash(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> LinkedListofPosition = GetLinkedListPosition(position);
            int count = 1;
            bool found = false;
            KeyValue<K, V> founditem = default(KeyValue<K, V>);

            foreach (KeyValue<K, V> keyValue in LinkedListofPosition)
            {
                if (keyValue.Key.Equals(key))
                {

            {
                LinkedListofPosition.Remove(founditem);
                return count;
            }
            else
            {
                return 1;
            }
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> LinkedListofPosition = GetLinkedListPosition(position);
            foreach (KeyValue<K, V> keyValue in LinkedListofPosition)
            {
                if (keyValue.Key.Equals(key))
                {
                    Console.WriteLine("Key: " + keyValue.Key + "\t Value: " + keyValue.Value);
                }

            }
        }

    }
}