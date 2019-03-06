using BenchmarkDotNet.Attributes;
using System.Linq;

namespace SingleOrWhere
{
    public class WhereEnumerable : BenchmarkBase
    {
        [Benchmark]
        public void Single()
        {
            _ = _data.Single(Predecate);
        }

        [Benchmark]
        public void WhereSingle()
        {
            _ = _data.Where(Predecate).Single();
        }

        [Benchmark]
        public void First()
        {
            _ = _data.First(Predecate);
        }

        [Benchmark]
        public void WhereFirst()
        {
            _ = _data.First(Predecate);
        }
    }
}
