namespace LeetCode.Practice
{
    
    public class DepthFirstSearch
    {
        public int[][] graphExample = [[1], [0, 2, 3, 4], [1], [1, 4], [1, 3]];
        public bool[] checkExample = [false, false, false, false, false];

        public void Example(int[][] graph, int current, bool[] check)
        {
            check[current] = true;
            Console.WriteLine(current);
            for (int i = 0; i < graph[current].Length; i++)
            {
                if (!check[graph[current][i]])
                {
                    Example(graph, graph[current][i], check);
                }
            }

            Console.WriteLine("Ending current...");
        }
    }
}