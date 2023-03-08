using System;

using R5T.T0150;
using R5T.T0151;


namespace R5T.T0164
{
    /// <summary>
    /// Someone's first name.
    /// It seems reasonable that in the list of someone's names, there is always a first.
    /// </summary>
    [StrongTypeMarker]
    public class FirstName : TypedString, IStrongTypeMarker
    {
        public FirstName(string value)
            : base(value)
        {
        }
    }
}
