using System;

using R5T.T0150;
using R5T.T0151;


namespace R5T.T0164
{
    /// <summary>
    /// Someone's full name.
    /// Note: this is not just first-name and last-name, as people might have many names (middle, multiple-middle).
    /// </summary>
    [StrongTypeMarker]
    public class FullName : TypedString, IStrongTypeMarker
    {
        public FullName(string value)
            : base(value)
        {
        }
    }
}
