using System;
using System.Threading.Tasks;

public class Example
{
    public class StudentInfo
    {
        public int RollNo;
        public string Name;
    }

    public static async Task<TResult> TaskMethod<TParam, TResult>(TParam num)
    {
        dynamic n = num;
        dynamic sum = 0;
        sum = await Task.FromResult<double>(CalculateSum(n));
        return sum;
    }

    public static int Main()
    {
        Task<double> task1 = Task.Run(() => {
            double sum = 0;

            for(int i=1;i<5;i++)
                sum += i;

            return sum;
        });
        Console.WriteLine("[Task1] Caculate sum : " + task1.Result);

        Task<double> task2 = Task.Run(() => {
            double sum = CalculateSum(5);

            return sum;
        });
        Console.WriteLine("[Task2] Caculate sum : " + task2.Result);

        Task<StudentInfo> task3 = Task.Run(() => {
            StudentInfo info = new StudentInfo()
            {
                RollNo = 55,
                Name = "Lal Bosco"
            };

            return info;
        });
        Console.WriteLine("[Task3] Roll number : " + task3.Result.RollNo);
        Console.WriteLine("[Task3] Name        : " + task3.Result.Name);

        Task<double> Task4 = TaskMethod<int, double>(4);
        Console.WriteLine("[Task4] Value        : " + Task4.Result);

        return 0;
    }

    public static double CalculateSum(int num)
    {
        double sum = 0;

        for(int i=1;i<num;i++)
            sum += i;

        return sum;
    }
}

/*
Output:

    [Task1] Caculate sum : 10
    [Task2] Caculate sum : 10
    [Task3] Roll number : 55
    [Task3] Name        : Lal Bosco
    [Task4] Value        : 6
*/