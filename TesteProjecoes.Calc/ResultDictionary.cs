using System.Collections;
using System.Collections.Generic;

namespace TesteProjecoes.Calc
{
    public class ResultDictionary : IDictionary<string, double>
    {
        private IDictionary<string, double> _me;

        public ResultDictionary()
        {
            _me = new Dictionary<string, double>();
        }

        public double this[string key] { get => _me[key]; set => _me[key] = value; }

        public ICollection<string> Keys => _me.Keys;

        public ICollection<double> Values => _me.Values;

        public int Count => _me.Count;

        public bool IsReadOnly => _me.IsReadOnly;

        public void Add(string key, double value)
        {
            _me.Add(key, value);
        }

        public void Add(KeyValuePair<string, double> item)
        {
            _me.Add(item);
        }

        public void Clear()
        {
            _me.Clear();
        }

        public bool Contains(KeyValuePair<string, double> item)
        {
            return _me.Contains(item);
        }

        public bool ContainsKey(string key)
        {
            return _me.ContainsKey(key);
        }

        public void CopyTo(KeyValuePair<string, double>[] array, int arrayIndex)
        {
            _me.CopyTo(array, arrayIndex);
        }

        public IEnumerator<KeyValuePair<string, double>> GetEnumerator()
        {
            return _me.GetEnumerator();
        }

        public bool Remove(string key)
        {
            return _me.Remove(key);
        }

        public bool Remove(KeyValuePair<string, double> item)
        {
            return _me.Remove(item);
        }

        public bool TryGetValue(string key, out double value)
        {
            return _me.TryGetValue(key, out value);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _me.GetEnumerator();
        }
    }
}
