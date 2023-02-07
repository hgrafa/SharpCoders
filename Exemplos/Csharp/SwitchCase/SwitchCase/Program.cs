namespace SwitchCase {

    public class Program {

        static bool IsVowel(char c) {
            switch(c) {
                case 'a': 
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    return true;
                default:
                    return false;
            }
        }

        public static void Main(string[] args) {

        }

    }

}