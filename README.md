LightSwitchExtendedProject
==========================

How to add Web API and MVC to a LightSwitch 2013 project

<em><strong>This is an update for the RTM of Visual Studio 2013.</strong>  Unfortunately Microsoft broke the scaffolding availability under LightSwitch projects.  I believe this is because up until the RTM, the scaffolding was part of a separate install from asp.net.  RTM included this as part of the core product.  Some of the hazards of working with anything but RTM products.</em>

<em>There has been some adjustments from the first posts so make sure you read thru and don't take anything for granted.  I've also put the  code up on GitHub so as to try and keep the text to a minimum.</em>

Visual Studio LightSwitch is a great product. But it's not the end all and most professional development projects require a mix of technologies to be considered successful. By following these steps, you'll end up with a LightSwitch project that has the HTML Client, Silverlight Client, MVC, Web API and Web Forms with the naming conventions of your choosing. Giving you a solution without restrictions!

First time thru the tutorial it may still take you 15 minutes.  So give it a try and see what you think…
<ol>
	<li value="1">Start Visual Studio 2013</li>
	<li>Create a new project: File, New Project…</li>
	<li>Select the LightSwitch Desktop Application, <em>this is a change</em></li>
	<li>Name the project: myTest</li>
	<li>Name the solution: myTest</li>
	<li>Double click on the properties file for the myTest project</li>
	<li>Enable forms authentication, and allow Security Admin for debug</li>
	<li>Save the solution, do a full build</li>
	<li>Right Click on the myTest project, add Client, HTML Client</li>
	<li>Name the client: App</li>
	<li>Once the client has been installed</li>
	<li>Right click on the DesktopClient and select Remove</li>
	<li>Right click on the solution, Open folder in file explorer</li>
	<li>Delete the DesktopClient folder</li>
	<li>In your server project, Data Sources, Create a Table</li>
	<li>Name it: TestItem with 1 property, Name</li>
	<li>In your App project, create a browse screen with TestItems</li>
	<li>Include an add/edit screen so you can verify data gets saved</li>
	<li>Build the app, run, and add some data</li>
	<li>Close your browser, and back into Visual Studio</li>
</ol>
We now have a core LightSwitch app running.  Now lets go add the additional frameworks.
<ol>
	<li value="1">Go to GitHub and download the source files from <a title="here" href="https://github.com/dwm9100b/LightSwitchExtendedProject" target="_blank">here</a></li>
	<li>Back in Visual Studio</li>
	<li>Open up VS Package Manager, Tools, Library Package Manager, Package Manager Console</li>
	<li>Make sure the selected Default Project in the console is your server project</li>
	<li>Run the following command:  <strong>install-package Microsoft.AspNet.Mvc</strong></li>
	<li>Run the following command:  <strong>install-package Microsoft.AspNet.WebApi</strong></li>
	<li>Run the following command:  <strong>install-package Microsoft.AspNet.Web.Optimization</strong></li>
	<li>Open up the web.config file in the root of your Server project</li>
	<li>From the zip file from GitHub, add the code from the web.config.merge.txt file into your web.config</li>
	<li>Pay attention to the comments in the txt file on where to paste it in your web.config</li>
	<li>Also from the GitHub zip, copy the other folders into the root of your project</li>
	<li>In Visual Studio, show all files, refresh, to show all the folders you copied</li>
	<li>Right click on the new folders and include in your project</li>
	<li>Add a Global.asax file to the root of your project</li>
	<li>Copy the code from the Global.asax.Merge.txt file into your new Global.asax file</li>
	<li>Add the following using statements in your Global.asax
<ol>
	<li value="1">System.Web.Mvc</li>
	<li>System.Web.Http</li>
	<li>System.Web.Routing</li>
</ol>
</li>
	<li>Finally, in the root of your server project open the default.aspx file</li>
	<li>Remove the first line with the &lt;%@</li>
	<li>Select Build, Clean Solution</li>
	<li>Select Build, Rebuild Solution</li>
	<li>Run your app</li>
</ol>
Your LightSwitch html app will run first with your custom URL path
<a href="http://localhost:{port}/App">http://localhost:{port}/App</a>

Moving on, let's test access to the ApplicationData.svc file
<a href="http://localhost:{port}/ApplicationData.svc">http://localhost:{port}/ApplicationData.svc</a>

So far so good eh? How about our MVC?
<a href="http://localhost:{port}/">http://localhost:{port}/</a>
<a href="http://localhost:{port}/Home">http://localhost:{port}/Home</a>

Yay! Looking good… now our default.aspx file in the root…
<a href="http://localhost:{port}/default.aspx">http://localhost:{port}/default.aspx</a>

Yep that works too… final test… the Web.Api side…
<a href="http://localhost:{port}/api/Test">http://localhost:{port}/api/Test</a>

You can now go in and clean up the project, delete the test screen, test table, etc.
Save the solution again.

This would be the point when you would add your project into source control.

Going forward, we will be having all of our Web projects starting with this base. We are able to create a full MVC website, Desktop SPA application and our LightSwitch Mobile app all within the same project and sharing code.

One of the great features out of this is we can use Visual Studio LightSwitch to do all of our data management without having to go down into the Entity Framework.

Next post we'll dig into User Management with an HTML interface vs. Silverlight.

Happy coding!
