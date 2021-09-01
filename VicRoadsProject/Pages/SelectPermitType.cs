using System;
using OpenQA.Selenium;
using VicRoadsCodingChallenge.Web;

namespace VicRoadsCodingChallenge.Pages
{
    public class SelectPermitType
    {
        public Element lblTitle = new Element("class", "progress-bar-title");

        public string pageTitle => lblTitle.Text;
    }
}
