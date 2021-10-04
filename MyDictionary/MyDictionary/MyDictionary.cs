using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<A, B>
    {
        A[] _key;
        B[] _value;


        A[] _tempKey;
        B[] _tempValue;


        public MyDictionary()
        {

            _key = new A[0];
            _value = new B[0];
        }

        public void Add(A key , B value)
        {
            _key = _tempKey;
            _value = _tempValue;

            _key = new A[_key.Length + 1];
            _value = new B[_value.Length + 1];

            for (int i = 0; i < _tempKey.Length; i++)
            {
                _key[i] = _tempKey[i];
                _value[i] = _tempValue[i];
            }

            _key[_key.Length - 1] = key;
            _value[_value.Length - 1] = value;
        }
    }
}
