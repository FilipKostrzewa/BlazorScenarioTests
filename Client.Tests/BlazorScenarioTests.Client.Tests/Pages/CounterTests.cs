using System.Threading.Tasks;
using BlazorScenarioTests.Client.Pages;
using Bunit;
using ScenarioTests;
using Xunit;

namespace BlazorScenarioTests.Client.Tests.Pages
{
    public partial class CounterTests
    {
        [Scenario]
        public async Task TripleIncrement(ScenarioContext scenario)
        {
            using var context = new TestContext();
            var page = context.RenderComponent<Counter>();

            page.Instance.IncrementCount();
            page.Render();
            scenario.Fact("First increment set currentCount to 1", () =>
            {
                Assert.True(page.Instance.currentCount == 1);
            });
            scenario.Fact("First increment - page contains proper caption", () =>
            {
                var paragraphs = page.FindAll("p");
                var paragraph = paragraphs[0];
                Assert.True(paragraph.InnerHtml == "Current count: 1");
            });

            page.Instance.IncrementCount();
            page.Render();
            scenario.Fact("Second increment set currentCount to 2", () =>
            {
                Assert.True(page.Instance.currentCount == 2);
            });
            scenario.Fact("Second increment - page contains proper caption", () =>
            {
                var paragraphs = page.FindAll("p");
                var paragraph = paragraphs[0];
                Assert.True(paragraph.InnerHtml == "Current count: 2");
            });

            page.Instance.IncrementCount();
            page.Render();
            scenario.Fact("Third increment set currentCount to 3", () =>
            {
                Assert.True(page.Instance.currentCount == 3);
            });
            scenario.Fact("Third increment - page contains proper caption", () =>
            {
                var paragraphs = page.FindAll("p");
                var paragraph = paragraphs[0];
                Assert.True(paragraph.InnerHtml == "Current count: 3");
            });

        }
    }
}
