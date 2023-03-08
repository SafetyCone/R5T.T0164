using System;


namespace R5T.T0164.Extensions
{
    public static class StringExtensions
    {
        public static LastName ToLastName(this string value)
        {
            var output = Instances.StringOperator.ToLastName(value);
            return output;
        }
    }
}
