using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bunit;
using Microsoft.AspNetCore.Components;

namespace IdeventTests
{
    /// <summary>
    /// Tests if you can load all pages by checking the h1 tag of each page after navigating to it.
    /// </summary>
    [TestClass]
    public class NavigationTests : TestBase
    {
        private NavigationManager _navManager;

        [TestInitialize]
        public void Inititialise()
        {
            _navManager = _testContext.Services.GetService<NavigationManager>();
        }
        [TestMethod]
        public void DashboardIndexLoads()
        {
            LoadPageTest(_testContext.RenderComponent<IdeventAdminBlazorServer.Pages.Admin.Dashboard.Index>(), "Dashboard", "Home");
        }
        [TestMethod]
        public void ProfileIndexLoads()
        {
            LoadPageTest(_testContext.RenderComponent<IdeventAdminBlazorServer.Pages.Admin.Profile.Index>(), "Profile");
        }
        [TestMethod]
        public void ChipsIndexLoads()
        {
            LoadPageTest(_testContext.RenderComponent<IdeventAdminBlazorServer.Pages.Admin.Chips.Index>(), "Chips Oversigt", "Chips");
        }
        [TestMethod]
        public void CompaniesIndexLoads()
        {
            LoadPageTest(_testContext.RenderComponent<IdeventAdminBlazorServer.Pages.Admin.Companies.Index>(), "Companies");
        }
        [TestMethod]
        public void EventsIndexLoads()
        {
            LoadPageTest(_testContext.RenderComponent<IdeventAdminBlazorServer.Pages.Admin.Events.Index>(), "Events");
        }
        [TestMethod]
        public void OperatorSiteIndexLoads()
        {
            LoadPageTest(_testContext.RenderComponent<IdeventAdminBlazorServer.Pages.Admin.OperatorSite.Index>(), "Operator's Site", "OperatorSite");
        }
        [TestMethod]
        public void ChipActivityLogIndexLoads()
        {
            LoadPageTest(_testContext.RenderComponent<IdeventAdminBlazorServer.Pages.Admin.ChipActivityLog.Index>(), "Chip Activity Log", "ChipActivityLog");
        }
        [TestMethod]
        public void UsersIndexLoads()
        {
            LoadPageTest(_testContext.RenderComponent<IdeventAdminBlazorServer.Pages.Admin.Users.Index>(), "Users");
        }
        [TestMethod]
        public void AddEventLoads()
        {
            LoadPageTest(_testContext.RenderComponent<IdeventAdminBlazorServer.Pages.Admin.Events.AddEvent>(), "Add Event", "AddEvent");
        }
        [TestMethod]
        public void EditEventLoads()
        {
            LoadPageTest(_testContext.RenderComponent<IdeventAdminBlazorServer.Pages.Admin.Events.EditEvent>(), "Edit Event", "EditEvent/1");
        }
        [TestMethod]
        public void EventProductManagementLoads()
        {
            LoadPageTest(_testContext.RenderComponent<IdeventAdminBlazorServer.Pages.Admin.Events.EventProductManagement>(), "Event Product Management", "EventProductManagement/1");
        }
        [TestMethod]
        public void ChipDetailsLoads()
        {
            LoadPageTest(_testContext.RenderComponent<IdeventAdminBlazorServer.Pages.Admin.Chips.ChipDetails>(), "Chip Details", "ChipDetails/1");
        }


        /// <summary>
        /// Tests if a specified page loads with an expected title.
        /// </summary>
        /// <param name="pageComponent">The page component to test.</param>
        /// <param name="pageTitle">The expected content of the page's h1 tag.</param>
        /// <param name="navigationTitle">(optional) If the url is different from "baseuri/pageTitle" you can replace pageTitle with navigationTitle.</param>
        private void LoadPageTest(IRenderedComponent<IComponent> pageComponent, string pageTitle, string navigationTitle = "")
        {
            // Arrange
            var page = pageComponent;
            string url;
            if (string.IsNullOrEmpty(navigationTitle))
            {
                url = $"{_navManager.BaseUri}{pageTitle}";
            }
            else
            {
                url = $"{_navManager.BaseUri}{navigationTitle}";
            }
            string expectedH1Content = $"<h1>{pageTitle}";

            // Act
            _navManager.NavigateTo(url);

            bool containsExpected = page.Markup.Contains(expectedH1Content);

            // Assert
            Assert.IsTrue(containsExpected);
        }

    }
}
