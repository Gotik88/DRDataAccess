using System;

namespace DR.DataAccess.Test.Framework.NUnit.TestExtensions
{
    public interface ITimeCounter
    {
        void Start();
        void Pause();
        void Stop();
        TimeSpan Get();
    }
}
