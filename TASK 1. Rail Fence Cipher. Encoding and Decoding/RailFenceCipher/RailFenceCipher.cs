namespace RailFenceCipher
{
    public class RailFenceCipher
    {
        public static string Encode(string str, int rails)
        {
            char[,] lines = new char[rails, str.Length];
            int row = 0; int col = 0; int inc = 1;

            foreach (char c in str)
            {
                lines[row, col] = c;
                row += inc;
                col++;
                if (row < 0 || row >= rails)
                {
                    row -= 2 * inc;
                    inc = -inc;
                }
            }

            string encoded = "";

            for (int i = 0; i < rails; ++i)
                for (int j = i; j < str.Length; j++)
                    if (lines[i, j] != 0)
                        encoded += lines[i, j];

            return encoded;
        }

        public static string Decode(string str, int rails)
        {
            char[,] lines = new char[rails, str.Length];
            int row = 0; int col = 0; int inc = 1;

            foreach (char c in str)
            {
                lines[row, col] = '?';
                row += inc;
                col++;
                if (row < 0 || row >= rails)
                {
                    row -= 2 * inc;
                    inc = -inc;
                }
            }

            string decoded = "";
            int k = 0;

            for (int i = 0; i < rails; i++)
                for (int j = i; j < str.Length; j++)
                    if (lines[i, j] == '?')
                        lines[i, j] = str[k++];

            row = 0; col = 0;

            foreach (char c in str)
            {
                decoded += lines[row, col];
                row += inc;
                col++;
                if (row < 0 || row >= rails)
                {
                    row -= 2 * inc;
                    inc = -inc;
                }
            }

            return decoded;
        }
    }
}
