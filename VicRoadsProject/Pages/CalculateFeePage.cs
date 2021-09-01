using System;
using OpenQA.Selenium;
using VicRoadsCodingChallenge.Web;

namespace VicRoadsCodingChallenge.Pages
{
    public class CalculateFeePage
    {
        public Element cboVehicleType = new Element("id", "ph_pagebody_0_phthreecolumnmaincontent_0_panel_VehicleType_DDList");
        public Element cboPassengerVehicleType = new Element("id", "ph_pagebody_0_phthreecolumnmaincontent_0_panel_PassengerVehicleSubType_DDList");
        public Element txtAddress = new Element("id", "ph_pagebody_0_phthreecolumnmaincontent_0_panel_AddressLine_SingleLine_CtrlHolderDivShown");
        public Element cboPermitDuration = new Element("id", "ph_pagebody_0_phthreecolumnmaincontent_0_panel_PermitDuration_DDList");
        public Element btnNext = new Element("name", "ph_pagebody_0$phthreecolumnmaincontent_0$panel$btnNext");

        public void EnterCalculateFeePageDetails(CalculateFeePageDetails details)
        {
            cboVehicleType.select(details.vehicleType);
            cboPassengerVehicleType.select(details.passengerVehicleType);
            txtAddress.Text = details.address +Keys.Enter;
            cboPermitDuration.select(details.permitDuration);
        }

        public void clickNext() => btnNext.click();

    }

    public class CalculateFeePageDetails
    {
        public string vehicleType { get; set; }
        public string passengerVehicleType { get; set; }
        public string address { get; set; }
        public string permitDuration { get; set; }
    }
}
