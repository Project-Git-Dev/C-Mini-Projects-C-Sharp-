using System;
using System.Numerics;

namespace methode_unit_tests
{
    public static class IbanChecker
    {
        public static bool IsGeldigIban(string? iban)
        {
            if (string.IsNullOrWhiteSpace(iban))
                return false;

            
            iban = iban.Replace(" ", "").ToUpperInvariant();

            
            if (iban.Length < 15 || iban.Length > 34)
                return false;

            
            for (int i = 0; i < iban.Length; i++)
            {
                if (!char.IsLetterOrDigit(iban[i]))
                    return false;
            }

            
            string verplaatst = iban.Substring(4) + iban.Substring(0, 4);

            //ALles hier onder heb ik AI gebruikt
            string numeriek = "";

            for (int i = 0; i < verplaatst.Length; i++)
            {
                
                char c = verplaatst[i];

                if (char.IsLetter(c))
                {
                    int waarde = c - 'A' + 10;
                    numeriek += waarde.ToString();
                }
                else
                {
                    numeriek += c;
                }
            }

            
            BigInteger getal = BigInteger.Parse(numeriek);
            return getal % 97 == 1;
        }
    }
}
