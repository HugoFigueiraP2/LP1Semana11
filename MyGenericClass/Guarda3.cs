using System;

namespace MyGenericClass
{
    public class Guarda3<T>
    {
        private T _t1, _t2, _t3;

        // Construtor vazio inicializando as variáveis com os valores padrão do tipo T
        public Guarda3()
        {
            _t1 = default(T);
            _t2 = default(T);
            _t3 = default(T);
        }

    }


}