namespace Pathoschild.Stardew.LookupAnything.Framework.DebugFields
{
    /// <summary>A generic debug field containing a raw datamining value.</summary>
    internal class GenericDebugField : IDebugField
    {
        /*********
        ** Accessors
        *********/
        /// <summary>A short field label.</summary>
        public string Label { get; protected set; }

        /// <summary>The field value.</summary>
        public string Value { get; protected set; }

        /// <summary>Whether the field should be displayed.</summary>
        public bool HasValue { get; protected set; }


        /*********
        ** Public methods
        *********/
        /// <summary>Construct an instance.</summary>
        /// <param name="label">A short field label.</param>
        /// <param name="value">The field value.</param>
        /// <param name="hasValue">Whether the field should be displayed (or <c>null</c> to check the <paramref name="value"/>).</param>
        public GenericDebugField(string label, object value, bool? hasValue = null)
        {
            this.Label = label;
            this.Value = TextHelper.Stringify(value);
            this.HasValue = hasValue ?? !string.IsNullOrWhiteSpace(this.Value);
        }
    }
}