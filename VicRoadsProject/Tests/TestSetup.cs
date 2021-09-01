using System;
using TechTalk.SpecFlow;
using VicRoadsCodingChallenge.Web;

namespace VicRoadsCodingChallenge.Tests
{
    [Binding]
    public class TestSetup
    {
        [BeforeScenario]
        public static void OpenBrowser()
        {
            Browser.GoToUrl("https://www.vicroads.vic.gov.au/registration/limited-use-permits/unregistered-vehicle-permits/get-an-unregistered-vehicle-permit");
        }

        [AfterScenario]
        public static void CloseBrowser()
        {
            Browser.Driver.Quit();
        }
    }
}
