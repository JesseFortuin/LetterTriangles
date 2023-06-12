Letter triangles

Similar to Coloured triangles.

But this one sums indexes of letters in alphabet.

Examples

c o d e w a r s
c is 3
o is 15
15+3=18
18. letter in the alphabet is r
then append r
next is o d
sum is 19
append s
do this until you iterate through whole string
now, string is rsibxsk
repeat whole cycle until you reach 1 character
then return the char
output is l
codewars -> l
triangle -> d
C O D E W A R S
 R S I B X S K
  K B K Z Q D
   M M K Q U
    Z X B L
     X Z N
      X N
       L
A B C D
 C E G
  H L
   T
More examples

youhavechosentotranslatethiskata -> a
cod -> k
yes -> b
hours -> y
circlecipher -> z
lettertriangles -> o
cod -> rs -> k
abcd -> ceg -> hl -> t
codewars -> rsibxsk -> kbkzqd -> mmkqu -> zxbl -> xzn -> xn -> l
Note, if the sum is bigger than 26, then start over

Input will always be lowercase letters. Random tests contains strings up to 30 letters.

-------------------------------------------------------
Solutions

    string str = "";
    while  (row.Length > 1) {
      for (int i = 0; i < row.Length - 1; i++) {
        int ascii = (row[i] - 96) + (row[i+1] - 96);
        if (ascii > 26) { ascii -= 26; }
        str += (char)(ascii + 96);
      }
      row = str;
      str = "";
    }
    return row;

------------

        string current = row;
        StringBuilder sb = new();
        while(current.Length > 1) {
            for(int i = 1; i < current.Length; i++) {
                int sum = (current[i - 1] - 96) + (current[i] - 96);
                if(sum > 26) sum -= 26;
                sb.Append((char)(sum + 96));
            }
            current = sb.ToString();
            sb.Clear();
        }
        return current;

--------------
            if (s.Length == 1)
                return s;
            char[] chars = new char[s.Length - 1];
            for (int i = 0; i < s.Length - 1; i++)
                chars[i] = nextColor(s[i], s[i + 1]);
            return recursive(new string(chars));
        }
        private static char nextColor(char c1, char c2)
        {
            int c = ((int)c1 + (int)c2 - 192) % 26 + 96;
            if(c== 96) c = 122;
            return (char)c;



