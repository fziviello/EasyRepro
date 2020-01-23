﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Dynamics365.UIAutomation.Api.UCI;


namespace Microsoft.Dynamics365.UIAutomation.Sample.UCI
{
    [TestClass]
    public class AssignAccount : TestsBase
    {
        [TestInitialize]
        public override void InitTest() => base.InitTest();

        [TestCleanup]
        public override void FinishTest() => base.FinishTest();

        public override void NavigateToHomePage() => _xrmApp.Navigation.OpenSubArea("Sales", "Accounts");

        [TestMethod]
        public void UCITestAssignAccount()
        {
            _xrmApp.Grid.OpenRecord(0);

            _xrmApp.ThinkTime(2000);

            _xrmApp.CommandBar.ClickCommand("Assign");

            _xrmApp.Dialogs.Assign(Dialogs.AssignTo.User, "Grant");
        }
    }
}
