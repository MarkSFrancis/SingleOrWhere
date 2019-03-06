using BenchmarkDotNet.Attributes;
using System.Linq;

namespace SingleOrWhere
{
    public class WhereQueryable : BenchmarkBase
    {
        [Benchmark]
        public void Single()
        {
            _ = _qData.Single(EPredecate);
        }

        [Benchmark]
        public void WhereSingle()
        {
            _ = _qData.Where(EPredecate).Single();
        }

        [Benchmark]
        public void First()
        {
            _ = _qData.First(EPredecate);
        }

        [Benchmark]
        public void WhereFirst()
        {
            _ = _qData.First(EPredecate);
        }
    }
}
