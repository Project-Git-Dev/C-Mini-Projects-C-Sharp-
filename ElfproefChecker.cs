using System;

namespace methode_unit_tests
{
    public static class ElfproefChecker
    {
        public static bool Elfproef(string? nummer)
        {
            
            if (nummer == null)
                return false;

            if (nummer.Trim().Length == 0)
                return false;

            
            if (nummer.Length != 9)
                return false;

            
            for (int i = 0; i < nummer.Length; i++)
            {
                if (!char.IsDigit(nummer[i]))
                    return false;
            }

            
            bool alleenNullen = true;
            for (int i = 0; i < nummer.Length; i++)
            {
                if (nummer[i] != '0')
                {
                    alleenNullen = false;
                    break;
                }
            }

            if (alleenNullen)
                return false;

           
            int som = 0;
            for (int i = 0; i < 9; i++)
            {
                int cijfer = nummer[i] - '0';
                som += cijfer * (9 - i);
            }

            return som % 11 == 0;
        }
    }
}
