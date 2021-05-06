using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace unit_test
{
    [TestClass]
    public class UnitTest1
    {
        private static readonly Todo[] TestTodos = new[]
        {
            new Todo
            {
                Id = 1,
                Title = "Todo1",
                Description = "Desc1",
                Priority = 0,
                ColumnId = 1,
                Deadline = DateTime.ParseExact("2021-01-01T12:00", "yyyy-MM-ddTHH:mm", null)
            },
            new Todo
            {
                Id = 2,
                Title = "Todo2",
                Description = "Desc2",
                Priority = 0,
                ColumnId = 1,
                Deadline = DateTime.ParseExact("2021-01-01T12:00", "yyyy-MM-ddTHH:mm", null)
            },
            new Todo
            {
                Id = 3,
                Title = "Todo3",
                Description = "Desc3",
                Priority = 0,
                ColumnId = 2,
                Deadline = DateTime.ParseExact("2021-01-01T12:00", "yyyy-MM-ddTHH:mm", null)
            }
        };

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
