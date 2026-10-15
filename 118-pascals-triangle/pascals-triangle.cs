public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        IList<IList<int>> x = new List<IList<int>>();
        for(int i=0;i<numRows;i++){
            x.Add(new List<int>());
            for(int j=0;j<=i;j++){
                x[i].Add(Combination(i,j));
            }
        }
        return x;
    }
    public static int Combination(int n, int r)
    {
        if (r < 0 || r > n) return 0;
        if (r == 0 || r == n) return 1;
        if (r > n - r) r = n - r; 
        int result = 1;
        for (int i = 1; i <= r; i++)
        {
            result *= (n - r + i);
            result /= i;
        }
        return result;
    }
}