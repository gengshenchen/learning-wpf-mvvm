using System.Windows;

namespace karl
{

    // 
    //     public static class Extensions
    //     {
    //         // EXTENSION METHODS
    //         public static void Print(this object obj)
    //         {
    //             Console.WriteLine(obj.ToString());
    //         }
    //     }

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //             bool? b = null;
            //             int? nullable = null; // short hand for Nullable<int>
            //             Console.WriteLine("Nullable variable: " + nullable);
            //             bool hasValue = nullable.HasValue; // true if not null
            // 
            //             int notNullable = nullable ?? 0; // 0
            // 
            //             // ?. is an operator for null-propagation - a shorthand way of checking for null
            //             nullable?.Print();
            //             notNullable.Print();
            // 
            //             using (StreamWriter writer = new StreamWriter("log.txt"))
            //             {
            //                 writer.WriteLine("Nothing suspicious here");
            //                 // At the end of scope, resources will be released.
            //                 // Even if an exception is thrown.
            //             }
            // 
            //             var words = new List<string> { "dog", "cat", "horse", "pony" };
            // 
            //             Parallel.ForEach(words,
            //                 new ParallelOptions() { MaxDegreeOfParallelism = 4 },
            //                 word =>
            //                 {
            //                     Console.WriteLine(word);
            //                 }
            //             );


        }

    }
}
