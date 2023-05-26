using csgo_sharecode.CSGOSharecode.Extensions;
using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace csgo_sharecode.CSGOSharecode.Base58
{
    public class CustomBase58
    {
        private const string Base58Alphabet = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefhijkmnopqrstuvwxyz23456789";

        public static int[] Decode(string encoded)
        {
            BigInteger big = BigInteger.Zero;
            foreach (char c in encoded.Reverse().ToCharArray())
                big = big * Base58Alphabet.Length + Base58Alphabet.IndexOf(c);

            byte[] temp = big.ToByteArray().Reverse().ToArray();
            int[] decoded = new int[temp.Length];

            for (int i = 0; i < temp.Length; i++)
                decoded[i] = Convert.ToUInt16(temp[i]);

            // set first char to 0
            if (decoded[0] != 0)
            {
                int[] copy = decoded;
                decoded = new int[copy.Length + 1];
                Array.Copy(copy, 0, decoded, 1, temp.Length - 1);
                decoded[0] = 0;
            }

            return decoded;
        }
    }
}
