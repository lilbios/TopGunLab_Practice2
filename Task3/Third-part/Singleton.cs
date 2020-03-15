using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.Third_part
{
    class Singleton
    {

        private static Random random;

        public static Random GetInstance() {
            if (random == null) {
                random = new Random();
            }
            return random;
        }

    }
}
