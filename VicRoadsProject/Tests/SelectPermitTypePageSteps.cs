using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using VicRoadsCodingChallenge.Pages;
using VicRoadsCodingChallenge.Web;

namespace MyNamespace
{
    [Binding]
    public class SelectPermitTypePageSteps
    {
        public CalculateFeePage calculateFeePage;

        [Given(@"I am on the VicRoads Homepage")]
        public void GivenIAmOnTheVicRoadsHomepage()
        {
            Browser.GoToUrl("https://www.vicroads.vic.gov.au/registration/limited-use-permits/unregistered-vehicle-permits/get-an-unregistered-vehicle-permit");
        }

        [When(@"I click on the next button")]
        public void WhenIClickOnTheNextButton()
        {
            calculateFeePage.clickNext();
        }

        [When(@"I enter the following data into the Calculate Fee Page")]
        public void WhenIEnterTheFollowingDataIntoTheCalculateFeePage(Table table)
        {
            CalculateFeePageDetails details = table.CreateInstance<CalculateFeePageDetails>();
            calculateFeePage = new CalculateFeePage();
            calculateFeePage.EnterCalculateFeePageDetails(details);
        }

        [Then(@"I am on the “(.*)” page")]
        public void ThenIAmOnTheStepOfSelectPermitTypePage(string pageTitle)
        {
            Assert.AreEqual(new SelectPermitType().pageTitle, pageTitle);
        }
    }
}
