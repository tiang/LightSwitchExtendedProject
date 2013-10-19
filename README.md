LightSwitchExtendedProject
==========================

How to add Web API and MVC to a LightSwitch 2013 project

This is an update for the RTM of Visual Studio 2013.  Unfortunately Microsoft broke the scaffolding availability under LightSwitch projects.  I believe this is because up until the RTM, the scaffolding was part of a separate install from asp.net.  RTM included this as part of the core product.  Some of the hazards of working with anything but RTM products.

There has been some adjustments from the first posts so make sure you read thru and don’t take anything for granted.  I’ve also put the  code up on GitHub so as to try and keep the text to a minimum.

Visual Studio LightSwitch is a great product. But it’s not the end all and most professional development projects require a mix of technologies to be considered successful. By following these steps, you’ll end up with a LightSwitch project that has the HTML Client, Silverlight Client, MVC, Web API and Web Forms with the naming conventions of your choosing. Giving you a solution without restrictions!

First time thru the tutorial it may still take you 15 minutes.  So give it a try and see what you think…
1.Start Visual Studio 2013
2.Create a new project: File, New Project…
3.Select the LightSwitch Desktop Application, this is a change
4.Name the project: myTest
5.Name the solution: myTest
6.Double click on the properties file for the myTest project
7.Enable forms authentication, and allow Security Admin for debug
8.Save the solution, do a full build
9.Right Click on the myTest project, add Client, HTML Client
10.Name the client: App
11.Once the client has been installed
12.Right click on the DesktopClient and select Remove
13.Right click on the solution, Open folder in file explorer
14.Delete the DesktopClient folder
15.In your server project, Data Sources, Create a Table
16.Name it: TestItem with 1 property, Name
17.In your App project, create a browse screen with TestItems
18.Include an add/edit screen so you can verify data gets saved
19.Build the app, run, and add some data
20.Close your browser, and back into Visual Studio

We now have a core LightSwitch app running.  Now lets go add the additional frameworks.
1.Go to GitHub and download the source files from here
2.Back in Visual Studio
3.Open up VS Package Manager, Tools, Library Package Manager, Package Manager Console
4.Make sure the selected Default Project in the console is your server project
5.Run the following command:  install-package Microsoft.AspNet.Mvc
6.Run the following command:  install-package Microsoft.AspNet.WebApi
7.Run the following command:  install-package Microsoft.AspNet.Web.Optimization
8.Open up the web.config file in the root of your Server project
9.From the zip file from GitHub, add the code from the web.config.merge.txt file into your web.config
10.Pay attention to the comments in the txt file on where to paste it in your web.config
11.Also from the GitHub zip, copy the other folders into the root of your project
12.In Visual Studio, show all files, refresh, to show all the folders you copied
13.Right click on the new folders and include in your project
14.Add a Global.asax file to the root of your project
15.Copy the code from the Global.asax.Merge.txt file into your new Global.asax file
16.Add the following using statements in your Global.asax A.System.Web.Mvc
B.System.Web.Http
C.System.Web.Routing

17.Finally, in the root of your server project open the default.aspx file
18.Remove the first line with the <%@
19.Select Build, Clean Solution
20.Select Build, Rebuild Solution
21.Run your app

Your LightSwitch html app will run first with your custom URL path
http://localhost:{port}/App

Moving on, let’s test access to the ApplicationData.svc file
http://localhost:{port}/ApplicationData.svc

So far so good eh? How about our MVC?
http://localhost:{port}/
http://localhost:{port}/Home

Yay! Looking good… now our default.aspx file in the root…
http://localhost:{port}/default.aspx

Yep that works too… final test… the Web.Api side…
http://localhost:{port}/api/Test

You can now go in and clean up the project, delete the test screen, test table, etc.
 Save the solution again.

This would be the point when you would add your project into source control.

Going forward, we will be having all of our Web projects starting with this base. We are able to create a full MVC website, Desktop SPA application and our LightSwitch Mobile app all within the same project and sharing code.

One of the great features out of this is we can use Visual Studio LightSwitch to do all of our data management without having to go down into the Entity Framework.

Next post we’ll dig into User Management with an HTML interface vs. Silverlight.

Happy coding!

