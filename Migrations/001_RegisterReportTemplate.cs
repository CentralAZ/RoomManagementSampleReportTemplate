// <copyright>
// Copyright by the Central Christian Church
//
// Licensed under the Rock Community License (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.rockrms.com/license
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//
using System;
using Rock.Plugin;

namespace org.rocksolidchurch.RoomManagementTemplates.Migrations
{
    [MigrationNumber( 1, "1.6.0" )]
    public class RegisterReportTemplate : Migration
    {
        public override void Up()
        {
            // Register your custom ReportTemplate "entity type"... that last item on this next line is your own custom GUID.
            RockMigrationHelper.UpdateEntityType( "org.rocksolidchurch.RoomManagementTemplates.SampleReportTemplate", "RockSolidChurch SampleExample Report Template", "org.rocksolidchurch.RoomManagementTemplates.SampleReportTemplate, org.rocksolidchurch.RoomManagementTemplates, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", false, true, "A76C387A-96EA-475C-81D9-ABD73C049E01" ); // use your own custom GUID

            // Register the IsActive attribute for your custom report.  The last item on this next line is another new custom GUID for your attribute.
            RockMigrationHelper.AddEntityAttribute( "org.rocksolidchurch.RoomManagementTemplates.SampleReportTemplate", "1EDAFDED-DFE6-4334-B019-6EECBA89E05A", "", "", "Active", "", "Should Service be used?", 0, "True", "62EC758F-6DD8-47EF-A5C7-F1786AAC6DE4" ); // yep, your own custom guid is the last item here.

            // Now set the IsActive value to True on that new attribute you just added.
            RockMigrationHelper.AddAttributeValue( "62EC758F-6DD8-47EF-A5C7-F1786AAC6DE4", 0, "True", Guid.NewGuid().ToString() );
        }

        public override void Down()
        {
            // Cleanup on uninstall by removing your custom IsActive attribute...
            RockMigrationHelper.DeleteAttribute( "62EC758F-6DD8-47EF-A5C7-F1786AAC6DE4" );

            // ...and your custom report template entity type.
            RockMigrationHelper.DeleteEntityType( "A76C387A-96EA-475C-81D9-ABD73C049E01" );
        }
    }
}