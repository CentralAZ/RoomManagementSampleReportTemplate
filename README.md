# RoomManagementSampleReportTemplate
A project to hold an example of a fake/sample Report Template for the Room Management plugin for Rock.

All you need to do is:

0) Create a custom project.
1) Add a reference to the com.centralaz.RoomManagement.dll
2) Add a reference to System.ComponentModel.Composition
3) Add this to your report class: using com.centralaz.RoomManagement.ReportTemplates;
4) Implement the required "Exceptions" property
5) Implement the required "GenerateReport(...)" method.
6) That's it.  Well, almost.  You need to add an IsActive attribute with an AttributeValue
   of "True" for your new custom ReportTemplate EntityType.
   One way to do this is to create a migration.  You can look at the example in the Migrations
   folder called 001_RegisterReportTemplate.cs to see how to do this.
   Or you can just write some SQL... but then the person who 'installs' your custom
   report template will need to manually run that SQL (yuck) before the template will show up.
7) Lastly, just compile the project, grab the DLL and drop it into your RockWeb/bin folder.
   When you do that, it will show up in the Reservation Lava block as an option for
   the Report Template block setting.
