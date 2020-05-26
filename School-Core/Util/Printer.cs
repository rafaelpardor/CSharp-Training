namespace CoreSchool.Util {
    public static class Printer {
        public static void DrawLine (int ammount = 10) {
            System.Console.WriteLine ("".PadLeft (ammount, '-'));
        }
        public static void WriteTitle (string title) {
            DrawLine(title.Length);
            System.Console.WriteLine (title.ToUpper());
            DrawLine(title.Length);
        }
    }
}