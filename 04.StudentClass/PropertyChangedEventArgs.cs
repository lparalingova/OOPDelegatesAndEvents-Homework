namespace _04.StudentClass
{
    using System;

    public class PropertyChangedEventArgs : EventArgs
    {
        public PropertyChangedEventArgs(
            dynamic previousData, 
            dynamic newData, 
            string propName)
        {
            this.PreviousData = previousData;
            this.NewData = newData;
            this.PropName = propName;
        }

        public dynamic PreviousData { get; private set; }

        public dynamic NewData { get; private set; }

        public string PropName { get; private set; }
    }
}