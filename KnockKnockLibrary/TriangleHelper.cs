namespace KnockKnockLibrary
{
    public class TriangleHelper
    {
        public bool IsTriangle(int a, int b, int c)
        {
            return (a >= 1 && b >= 1 && c >= 1) && 
                   (
                       c < a + b &&
                       b < a + c &&
                       a < b + c
                   );
        }

        public TriangleType GetTriangleType(int a, int b, int c)
        {
            return (a.Equals(b) && a.Equals(c)) ? TriangleType.Equilateral :
                (a.Equals(b) || a.Equals(c) || b.Equals(c)) ? TriangleType.Isocoles :
                TriangleType.Scalene;
        }
    }
}
