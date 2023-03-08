using System;

using R5T.T0150;
using R5T.T0151;


namespace R5T.T0164
{
    /// <summary>
    /// Someone's last name.
    /// It seems reasonable that in the list of someone's names, there is always a last.
    /// </summary>
    [StrongTypeMarker]
    public class LastName : TypedString, IStrongTypeMarker
    {
        public LastName(string value)
            : base(value)
        {
        }
    }
}
