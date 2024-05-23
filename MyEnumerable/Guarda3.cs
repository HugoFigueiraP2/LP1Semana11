using System;
using System.Collections;
using System.Collections.Generic;

namespace MyEnumerable
{
    public class Guarda3<T> : IEnumerable<T>
    {
        private T _t1, _t2, _t3;

        // Construtor vazio inicializando as variáveis com os valores padrão do tipo T
        public Guarda3() 
        {
            _t1 = default(T);
            _t2 = default(T);
            _t3 = default(T);
        }

        public IEnumerator<T> GetEnumerator()
        {
            yield return _t1;
            yield return _t2;
            yield return _t3;
        }

        public T GetItem(int i)
        {
            if (i == 0) return _t1;
            else if (i == 1) return _t2;
            else if (i == 2) return _t3;
            else throw new IndexOutOfRangeException();

            
        }

        public void SetItem(int i, T item)
        {
            if (i < 0 || i > 2) 
            {
                throw new IndexOutOfRangeException();
            }

            switch (i)
            {
                case 0:
                    _t1 = item;
                    break;
                case 1:
                    _t2 = item;
                    break;
                case 2:
                    _t3 = item; 
                    break;
            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
            throw new NotImplementedException();
        }
    }


}