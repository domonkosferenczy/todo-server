using System;
using Xunit;
using todo_server.Models;

namespace todo_server.Test
{
    public class UnitTest
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

        /*[Fact]
        public void TestInserting()
        {
            using (var testScope = TestWebAppFactory.Create())
            {
                testScope.AddSeedEntities(TestColumns);
                testScope.AddSeedEntities(TestTodos);
                var client = testScope.CreateClient();

                int id = 4;
                var response = await client.GetAsync($"/api/todos/{id}");

                Assert.AreEqual(System.Net.HttpStatusCode.NotFound, response.StatusCode);
            }
        }*/
    }
}
