namespace ClassLibrary1
{
    /// <summary>
    /// An internal class which will not show up in the documentation
    /// </summary>
    internal class Baz
    {
        /// <summary>
        /// A property which also will not show up because it's not visible
        /// </summary>
        public int Prop1 { get; set; }

        /// <summary>
        /// A property which also will not show up because it's not visible
        /// </summary>
        private readonly int _fieldOne = 0;


        /// <summary>
        /// A method which also will not show up because it's not visible
        /// </summary>
        public void DoThing()
        {

        }
    }
}
