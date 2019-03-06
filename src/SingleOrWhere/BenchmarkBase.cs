using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SingleOrWhere
{
    public class BenchmarkBase
    {
        private const int _dataToFind = 4762;

        protected static readonly IEnumerable<int> _data = 
            new List<int> { 63, 1623, 632, 12, _dataToFind, 742, 7217, 958 };

        protected static readonly IQueryable<int> _qData = _data.AsQueryable();

        protected static bool Predecate(int data)
        {
            return data == _dataToFind;
        }

        protected static readonly Expression<Func<int, bool>> EPredecate = d => d == _dataToFind;
    }
}
