using System;

using R5T.T0132;


namespace R5T.T0164
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        public LastName ToLastName(string value)
        {
            var output = new LastName(value);
            return output;
        }
    }
}
