namespace _04.StudentClass
{
    using System;

    public static class Program
    {
        public static void Main()
        {
            var st = new Student("Videlin", 30);
            st.OnPropertyChange += EventChanges;
            st.Name = "Pesho";
            st.Name = "Videlin";
            st.Age = 18;
        }

        private static void EventChanges(object sender, PropertyChangedEventArgs args)
        {
            Console.WriteLine(
                $"{args.PropName} property has chnaged from {args.PreviousData} to {args.NewData}");
        }
    }
}
