namespace AutoFramework.Pages
{
    using OpenQA.Selenium;
    using SeleniumExtras.PageObjects;

    //Css path for test cases link
    public class TestCasesPage
    {
        public TestCasesPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }
        [FindsBy(How = How.CssSelector, Using = "#main-content > article.mh-loop-item.mh-clearfix.post-74.post.type-post.status-publish.format-standard.has-post-thumbnail.hentry.category-test-cases > div > header > h3 > a")]
        public IWebElement UsernameCase { get; set; }
    }
}
