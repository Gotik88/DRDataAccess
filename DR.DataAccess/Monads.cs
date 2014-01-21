using System;

namespace DR.DataAccess
{
    public static class Monads
    {
        public static TInput Do<TInput>(this TInput o, Action<TInput> action) where TInput : class
        {
            if (o == null)
            {
                return null;
            }

            action(o);
            return o;
        }
    }
}
