<<<<<<< HEAD
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Linq;

namespace Helper
{
    public class ThreadSafeDictionary<TKey, TValue>
    {
        protected readonly Dictionary<TKey, TValue> _impl = new Dictionary<TKey, TValue>();
        public TValue this[TKey key]
        {
            get
            {
                lock (_impl)
                {
                    return _impl[key];
                }
            }
            set
            {
                lock (_impl)
                {
                    _impl[key] = value;
                }
            }
        }

        public void Add(TKey key, TValue value)
        {
            lock (_impl)
            {
                _impl.Add(key, value);
            }
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            lock (_impl)
            {
                return _impl.TryGetValue(key, out value);
            }
        }

        public bool Remove(TKey key)
        {
            lock (_impl)
            {
                return _impl.Remove(key);
            }
        }

        public void Clear()
        {
            lock (_impl)
            {
                _impl.Clear();
            }
        }
    }
=======
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Linq;

namespace Helper
{
    public class ThreadSafeDictionary<TKey, TValue>
    {
        protected readonly Dictionary<TKey, TValue> _impl = new Dictionary<TKey, TValue>();
        public TValue this[TKey key]
        {
            get
            {
                lock (_impl)
                {
                    return _impl[key];
                }
            }
            set
            {
                lock (_impl)
                {
                    _impl[key] = value;
                }
            }
        }

        public void Add(TKey key, TValue value)
        {
            lock (_impl)
            {
                _impl.Add(key, value);
            }
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            lock (_impl)
            {
                return _impl.TryGetValue(key, out value);
            }
        }

        public bool Remove(TKey key)
        {
            lock (_impl)
            {
                return _impl.Remove(key);
            }
        }

        public void Clear()
        {
            lock (_impl)
            {
                _impl.Clear();
            }
        }
    }
>>>>>>> 5988ed10343d9064ee2c94a2c0ed2dec3b54cb96
}