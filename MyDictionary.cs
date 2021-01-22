using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Dictonary
{
    class MyDictionary<Y,N>
    {
        Y[] _yemek;
        N[] _numara;

        public MyDictionary()
        {
            _yemek = new Y[0];
            _numara = new N[0];
        }

        public void Add(Y yemek, N numara)
        {
            Y[] _yemekAc = _yemek;
            N[] _numaraSira = _numara;

            _yemek = new Y[_yemek.Length + 1];
            _numara = new N[_numara.Length + 1];
            for (int i = 0; i < _yemekAc.Length; i++)
            {
                _yemek[i] = _yemekAc[i];
                _numara[i] = _numaraSira[i];
            }

            _yemek[_yemek.Length - 1] = yemek;
            _numara[_numara.Length - 1] = numara;

        }

        public Y[] Yemek
        {
            get { return _yemek; }
        }

        public N[] Numara
        {
            get { return _numara; }
        }
    }
    
}
