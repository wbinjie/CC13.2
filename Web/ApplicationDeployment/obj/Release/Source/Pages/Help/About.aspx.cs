#region License

// Copyright (c) 2013, MatrixPACS Inc.
// All rights reserved.
// http://www.MatrixPACS.ca
//
// This file is part of the MatrixPACS RIS/PACS open source project.
//
// The MatrixPACS RIS/PACS open source project is free software: you can
// redistribute it and/or modify it under the terms of the GNU General Public
// License as published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
//
// The MatrixPACS RIS/PACS open source project is distributed in the hope that it
// will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General
// Public License for more details.
//
// You should have received a copy of the GNU General Public License along with
// the MatrixPACS RIS/PACS open source project.  If not, see
// <http://www.gnu.org/licenses/>.

#endregion

using System;
using System.Threading;
using MatrixPACS.Common;
using MatrixPACS.ImageServer.Web.Application.Pages.Common;
using Resources;
using MatrixPACS.ImageServer.Web.Common.Extensions;

namespace MatrixPACS.ImageServer.Web.Application.Pages.Help
{
    [ExtensibleAttribute(ExtensionPoint = typeof(AboutPageExtensionPoint))]
    public partial class About : BasePage, IAboutPage
    {
        public string LicenseKey { get; set; }

        public About()
        {
            try
            {
                if (Thread.CurrentPrincipal.IsInRole(MatrixPACS.ImageServer.Common.Authentication.AuthorityTokens.Admin.Configuration.ServerPartitions))
                {
                    LicenseInformation.Reset();
                    LicenseKey = LicenseInformation.LicenseKey;
                }
            }
            catch (Exception)
            {
            }
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            ForeachExtension<IAboutPageExtension>(ext => ext.OnAboutPageInit(this));
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            SetPageTitle(Titles.AboutPageTitle);            
        }

        #region IAboutPage Members

        public System.Web.UI.Control ExtensionContentParent
        {
            get
            {
                return ExtensionContentPlaceHolder;
            }
        }

        #endregion
    }
}